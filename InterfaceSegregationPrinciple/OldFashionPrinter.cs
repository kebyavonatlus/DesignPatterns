using System;

namespace InterfaceSegregationPrinciple
{
    public class OldFashionPrinter : IMachine
    {
        public void Fax(Document doc)
        {
            //
        }

        public void Print(Document doc)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document doc)
        {
            throw new NotImplementedException();
        }
    }
}
