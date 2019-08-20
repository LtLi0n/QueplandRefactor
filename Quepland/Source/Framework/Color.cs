namespace Quepland
{
    public struct Color
    {
        public byte A { get; }
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public Color(byte r, byte g, byte b) : this(r, g, b, byte.MaxValue) { }

        public Color(byte r, byte g, byte b, byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public static explicit operator Color(int aColor) =>
            new Color(
                r: (byte)((aColor >> 16) & 0xFF),
                g: (byte)((aColor >> 8) & 0xFF),
                b: (byte)((aColor) & 0xFF),
                a: (byte)((aColor >> 24) & 0xFF));

        public static implicit operator int(Color color) =>
            (color.A & 0xff) << 24 |
            (color.R & 0xff) << 16 |
            (color.G & 0xff) << 8 |
            (color.B & 0xff);

        public static Color Black => new Color(0, 0, 0);
        public static Color Blue => new Color(0, 0, 255);
    }
}
