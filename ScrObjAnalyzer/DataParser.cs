using System.Collections.Generic;
using TempestWave.TWx;
using LitJson;

namespace ScrObjAnalyzer
{
    public class DataParser
    {
        public double SecPerTick { get; set; }

        public DataParser()
        {
            
        }

        public string ParseToTWx(int twxMode, List<ListData> data, List<BPMData> bpm, byte[] color, Metadata meta)
        {
            List<Note> NoteList = new List<Note>();
            int bpmIndex = -1;

            for(int i = 0; i < data.Count; i++)
            {
                while (bpmIndex < bpm.Count - 1 && data[i].Time >= bpm[bpmIndex + 1].Time) { bpmIndex++; }

                int mode = 0, size = 0, flick = 0;
                if (data[i].Type.Equals(0)) { mode = 0; size = 0; flick = 0; }
                else if (data[i].Type.Equals(1)) { mode = 0; size = 1; flick = 0; }
                else if (data[i].Type.Equals(2)) { mode = 0; size = 0; flick = 1; }
                else if (data[i].Type.Equals(3)) { mode = 0; size = 0; flick = 3; }
                else if (data[i].Type.Equals(4)) { mode = 0; size = 0; flick = 2; }
                else if (data[i].Type.Equals(5)) { mode = 1; size = 0; flick = 0; }
                else if (data[i].Type.Equals(6)) { mode = 2; size = 0; flick = 0; }
                else if (data[i].Type.Equals(7)) { mode = 1; size = 1; flick = 0; }
                else if (data[i].Type.Equals(8)) { mode = 0; size = 2; flick = 0; }

                double start = data[i].StartPos + 1;

                Note note = new Note();
                note.CreateNote(data[i].ID, size, data[i].NoteColor, mode, flick, data[i].Time, data[i].Tick, data[i].Speed, start, data[i].EndPos + 1.0, new int[] { 0 });
                NoteList.Add(note);
                if (data[i].Type.Equals(5) || data[i].Type.Equals(7))
                {
                    int newflick = 0;
                    if (data[i].EndType.Equals(0)) { newflick = 0; }
                    else if (data[i].EndType.Equals(1)) { newflick = 1; }
                    else if (data[i].EndType.Equals(2)) { newflick = 3; }
                    else if (data[i].EndType.Equals(3)) { newflick = 2; }
                    Note tail = new Note();
                    tail.CreateNote(data[i].ID + 1, size, data[i].SubColor[0], mode, newflick, data[i].Time + (data[i].TickDistance * bpm[bpmIndex].SecPerTick), data[i].Tick + data[i].TickDistance, data[i].Speed, start, data[i].EndPos + 1, new int[] { data[i].ID });
                    NoteList.Add(tail);
                }
                else if (data[i].Type.Equals(6))
                {
                    for (int j = 1; j < data[i].SubPos.Count; j++)
                    {
                        Note sub = new Note();
                        sub.CreateNote(data[i].ID + j, size, data[i].SubColor[j - 1], mode, 0, data[i].Time + (data[i].SubTick[j] * bpm[bpmIndex].SecPerTick), data[i].Tick + data[i].SubTick[j], data[i].Speed, data[i].SubPos[j] + 1, data[i].SubPos[j] + 1, new int[] { data[i].ID + j - 1 });
                        if (j.Equals(data[i].SubPos.Count - 1))
                        {
                            int newflick = 0;
                            if (data[i].EndType.Equals(0)) { newflick = 0; }
                            else if (data[i].EndType.Equals(1)) { newflick = 1; }
                            else if (data[i].EndType.Equals(2)) { newflick = 3; }
                            else if (data[i].EndType.Equals(3)) { newflick = 2; }
                            sub.Flick = newflick;
                        }
                        NoteList.Add(sub);
                    }
                }
            }

            NoteData notedata = new NoteData();
            notedata.metadata = meta;
            notedata.notes = NoteList.ToArray();

            string json = JsonMapper.ToJson(notedata);
            return json;
        }

        private double ConvertStartPos(int twxMode, double value)
        {
            double start = (twxMode + 1) / 2.0;

            if (twxMode.Equals(2))
            {
                start = (11.0 / 9.0) + ((5.0 / 9.0) * value);
            }
            else if (twxMode.Equals(4))
            {
                start = (15.0 / 9.0) + ((5.0 / 9.0) * value);
            }
            else if (twxMode.Equals(6))
            {
                start = (19.0 / 9.0) + ((5.0 / 9.0) * value);
            }

            return start;
        }
    }
}
