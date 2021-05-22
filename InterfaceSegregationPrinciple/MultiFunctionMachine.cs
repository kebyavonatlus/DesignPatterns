namespace InterfaceSegregationPrinciple
{
    public class MultiFunctionMachine : IMultifunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionMachine(IScanner scanner, IPrinter printer)
        {
            this.scanner = scanner;
            this.printer = printer;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        } // decorator
    }
}
