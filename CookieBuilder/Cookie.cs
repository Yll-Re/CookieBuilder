namespace CookieBuilder
{
    public class Cookie : ICookieBuilder
    {
        private string flourType;
        private string sugarType;
        private string chocolateType;

        public string FlourType { get { return flourType; } }
        public string SugarType { get { return sugarType; } }
        public string ChocolateType { get { return chocolateType; } }

        private Cookie()
        {

        }

        public class CookieBuilder
        {
            private readonly Cookie _cookie;

            public CookieBuilder()
            {
                _cookie = new Cookie();
            }

            public CookieBuilder WithFlourType(string flourType)
            {
                _cookie.flourType = flourType;
                return this;
            }

            public CookieBuilder WithSugarType(string sugarType)
            {
                _cookie.sugarType = sugarType;
                return this;
            }

            public CookieBuilder WithChocolateType(string ChocolateType)
            {
                _cookie.chocolateType = ChocolateType;
                return this;
            }

            public Cookie Build()
            {
                return _cookie;
            }
        }
    }
}
