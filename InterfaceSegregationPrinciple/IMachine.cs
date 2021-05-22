namespace InterfaceSegregationPrinciple
{
    public interface IMachine
    {
        void Print(Document doc);
        void Scan(Document doc);
        void Fax(Document doc);
    }
}
