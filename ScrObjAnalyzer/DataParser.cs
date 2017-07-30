using System;
using System.Collections.Generic;
using LitJson;

namespace ScrObjAnalyzer
{
    public class NoteData
    {
        public Note[] notes { get; set; }

        public NoteData()
        {

        }
    }

    public class Note
    {
        public int ID { get; set; }
        public int Size { get; set; }
        public byte[] Color { get; set; }
        public int Mode { get; set; }
        public int Flick { get; set; }
        public double Time { get; set; }
        public double Speed { get; set; }
        public double StartLine { get; set; }
        public double EndLine { get; set; }
        public int[] PrevIDs { get; set; }

        public Note()
        {
            Color = new byte[4];
        }

        public Note(int prevLength)
        {
            Color = new byte[4];
            PrevIDs = new int[prevLength];
        }

        public void CreateNote(int id, int size, byte[] color, int mode, int flick, double time, double speed, double start, double end, int[] prev)
        {
            ID = id;
            Size = size;
            Color = color;
            Mode = mode;
            Flick = flick;
            Time = time;
            Speed = speed;
            StartLine = start;
            EndLine = end;
            PrevIDs = prev;
        }
    }

    public class DataParser
    {
        public double SecPerTick { get; set; }

        public DataParser()
        {
            
        }

        public string ParseToTWx(int twxMode, List<ListData> data, List<BPMData> bpm, byte[] color)
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

                double start = ConvertStartPos(twxMode, data[i].StartPos);

                Note note = new Note();
                note.CreateNote(data[i].ID, size, color, mode, flick, data[i].Time, data[i].Speed, start, data[i].EndPos + 1.0, new int[] { 0 });
                NoteList.Add(note);
                if (data[i].Type.Equals(5) || data[i].Type.Equals(7))
                {
                    int newflick = 0;
                    if (data[i].EndType.Equals(0)) { newflick = 0; }
                    else if (data[i].EndType.Equals(1)) { newflick = 1; }
                    else if (data[i].EndType.Equals(2)) { newflick = 3; }
                    else if (data[i].EndType.Equals(3)) { newflick = 2; }
                    Note tail = new Note();
                    tail.CreateNote(data[i].ID + 1, size, color, mode, newflick, data[i].Time + (data[i].TickDistance * bpm[bpmIndex].SecPerTick), data[i].Speed, start, data[i].EndPos + 1, new int[] { data[i].ID });
                    NoteList.Add(tail);
                }
                else if (data[i].Type.Equals(6))
                {
                    for (int j = 1; j < data[i].SubPos.Count; j++)
                    {
                        Note sub = new Note();
                        sub.CreateNote(data[i].ID + j, size, color, mode, 0, data[i].Time + (data[i].SubTick[j] * bpm[bpmIndex].SecPerTick), data[i].Speed, ConvertStartPos(twxMode, data[i].SubPos[j]), data[i].SubPos[j] + 1, new int[] { data[i].ID + j - 1 });
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
            notedata.notes = NoteList.ToArray();

            string json = JsonMapper.ToJson(notedata);
            return json;
        }

        private double ConvertStartPos(int twxMode, double value)
        {
            double start = (twxMode + 1) / 2.0;

            if (twxMode.Equals(2))
            {
                /*
                if (value.Equals(-1)) { start = 0.666666; }
                else if (value.Equals(0)) { start = 1.222222; }
                else if (value.Equals(1)) { start = 1.777777; }
                else if (value.Equals(2)) { start = 2.333333; }
                */
                start = (11.0 / 9.0) + ((5.0 / 9.0) * value);
            }
            else if (twxMode.Equals(4))
            {
                /*
                if (value.Equals(-2)) { start = 0.555555; }
                else if (value.Equals(-1)) { start = 1.111111; }
                else if (value.Equals(0)) { start = 1.666666; }
                else if (value.Equals(1)) { start = 2.222222; }
                else if (value.Equals(2)) { start = 2.777777; }
                else if (value.Equals(3)) { start = 3.333333; }
                else if (value.Equals(4)) { start = 3.888888; }
                else if (value.Equals(5)) { start = 4.444444; }
                */
                start = (15.0 / 9.0) + ((5.0 / 9.0) * value);
            }
            else if (twxMode.Equals(6))
            {
                /*
                if (value.Equals(-2)) { start = 1.0; }
                else if (value.Equals(-1)) { start = 1.555555; }
                else if (value.Equals(0)) { start = 2.111111; }
                else if (value.Equals(1)) { start = 2.666666; }
                else if (value.Equals(2)) { start = 3.222222; }
                else if (value.Equals(3)) { start = 3.777777; }
                else if (value.Equals(4)) { start = 4.333333; }
                else if (value.Equals(5)) { start = 4.888888; }
                else if (value.Equals(6)) { start = 5.444444; }
                else if (value.Equals(7)) { start = 6.0; }
                */
                start = (19.0 / 9.0) + ((5.0 / 9.0) * value);
            }

            return start;
        }
    }
}
