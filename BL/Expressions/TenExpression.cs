namespace NumbersToWords.BL
{
    class TenExpression : Expression
    {
        public override string Zero() => " ten"; 
        public override string One() => " eleven";
        public override string Two() => " twelve";
        public override string Three() => " thirteen";
        public override string Four() => " fourteen";
        public override string Five() => " fifteen";
        public override string Six() => " sixteen";
        public override string Seven() => " seventeen";
        public override string Eight() => " eighteen";
        public override string Nine() => " nineteen";
    }
}
