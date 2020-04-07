namespace AssemblyOne
{
    public class Motorcycle
    {
        public int MaxSpeedPublic;
        private int MaxSpeedPrivate;
        internal int MaxSpeedInternal;
        protected int MaxSpeedProtected;
        private protected void MaxSpeedPrivateProtected()
        {
        }
        protected internal void MaxSpeedInternalProtected()
        {
        }
    }
}
