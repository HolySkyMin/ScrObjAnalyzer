namespace TempestWave.TWx
{
    public class NoteData
    {
        public int version { get; }
        public Metadata metadata { get; set; }
        public Note[] notes { get; set; }

        public NoteData()
        {
            version = 2;
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
        public int Tick { get; set; }
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

        public void CreateNote(int id, int size, byte[] color, int mode, int flick, double time, int tick, double speed, double start, double end, int[] prev)
        {
            ID = id;
            Size = size;
            Color = color;
            Mode = mode;
            Flick = flick;
            Time = (float)time;
            Tick = tick;
            Speed = speed;
            StartLine = start;
            EndLine = end;
            PrevIDs = prev;
        }
    }

    public class Metadata
    {
        public int level { get; set; }
        public string artist { get; set; }
        public string mapper { get; set; }
        public int density { get; set; }

        public Metadata()
        {

        }
    }
}
