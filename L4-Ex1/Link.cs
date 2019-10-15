namespace L4_Ex1
{
    public class Link
    {
        private int data;
        private Link nextLink;


        public Link(int newItem)
        {
            data = newItem;
        }

        public Link(int newItem, Link newLink)
        {
            data = newItem;
            nextLink = newLink;

        }

        public int Value
        {
            get => data;
            set => data = value;
        }

        public Link NextLink
        {
            get => nextLink;
            set => nextLink = value;
        }
    }
}