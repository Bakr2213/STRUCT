namespace Struct
{
    public class DigitalSize
    {
        private long bit;

        public string Bit => $"{(bit / BitsInBit):N0} Bit";
        public string Byte => $"{(bit / BitsInByte):N0} Byte";
        public string KB => $"{(bit / BitsInKB):N0} KB";
        public string MB => $"{(bit / BitsInMB):N0} MB";
        public string GB => $"{(bit / BitsInGB):N0} GB";
        public string TB => $"{(bit / BitsInTB):N0} TB";

        private const long BitsInBit = 1;
        private const long BitsInByte = 8;
        private const long BitsInKB = BitsInByte * 1024;
        private const long BitsInMB = BitsInKB * 1024;
        private const long BitsInGB = BitsInMB * 1024;
        private const long BitsInTB = BitsInGB * 1024;

        public DigitalSize(long initialValue)
        {
            this.bit = initialValue;
        }

        public DigitalSize AddBit(long bit)
        {
            return Add(bit, BitsInBit);
        }

        public DigitalSize AddByte(long byteValue)
        {
            return Add(byteValue, BitsInByte);
        }

        public DigitalSize AddKB(long kbValue)
        {
            return Add(kbValue, BitsInKB);
        }

        public DigitalSize AddMB(long mbValue)
        {
            return Add(mbValue, BitsInMB);
        }

        public DigitalSize AddGB(long gbValue)
        {
            return Add(gbValue, BitsInGB);
        }

        public DigitalSize AddTB(long tbValue)
        {
            return Add(tbValue, BitsInTB);
        }

        private DigitalSize Add(long value, long scale)
        {
            return new DigitalSize(this.bit + value * scale);
        }
    }
}
