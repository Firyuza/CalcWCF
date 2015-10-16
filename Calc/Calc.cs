namespace Calc
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Calc
    {
        [DataMember]
        public double First;

        [DataMember]
        public double Second;
    }
}
