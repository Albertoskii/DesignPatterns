using System.Collections.Generic;

namespace Builder
{
    class HtmlElement 
    {
        internal string Name, Text;
        internal List<HtmlElement> Elements = new List<HtmlElement>();
        internal const int indentSize = 2;
        internal HtmlElement() { }
        internal HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        // factory method
        public static HtmlBuilder Create(string name) => new HtmlBuilder(name);

    }
    class HtmlBuilder
    {
        protected readonly string rootName;
        protected HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }
        public override string ToString() => root.ToString();

        public static implicit operator HtmlElement(HtmlBuilder builder) => builder.root;

        public HtmlElement Build() => root;

    }

}
