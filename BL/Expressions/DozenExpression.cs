namespace NumbersToWords.BL
{
    class DozenExpression : IExpression
    {
        public string Zero() =>  " zero"; 
        public string One() => " ten"; 
        public string Two() => " twenty"; 
        public string Three() => " thirty"; 
        public string Four() => " forty"; 
        public string Five() => " fifty"; 
        public string Six() => " sixty";
        public string Seven() => " seventy";
        public string Eight() => " eighty";
        public string Nine() => " ninety";
    }
}
