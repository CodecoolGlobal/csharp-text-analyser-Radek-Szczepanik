using System;

namespace csharp_text_analyser_Radek_Szczepanik
{
    public interface IIterator
    {
        public bool HasNext();
        public string MoveNext();
        public void Remove();
    }
    
}
