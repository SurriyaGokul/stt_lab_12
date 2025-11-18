namespace OrderPipeline
{
    public class ShipEventArgs : EventArgs
    {
        public string Product { get; }
        public bool Express { get; }

        public ShipEventArgs(string p, bool ex)
        {
            Product = p;
            Express = ex;
        }
    }
}
