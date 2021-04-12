namespace NumbersToWords.BL
{
    class DozenExpression : Expression
    {
        public override string Zero() =>  " zero"; 
        public override string One() => " ten"; 
        public override string Two() => " twenty"; 
        public override string Three() => " thirty"; 
        public override string Four() => " forty"; 
        public override string Five() => " fifty"; 
        public override string Six() => " sixty";
        public override string Seven() => " seventy";
        public override string Eight() => " eighty";
        public override string Nine() => " ninety";
    }
}
