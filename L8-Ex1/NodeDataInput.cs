using System;

namespace L8_Ex1
{
    public struct NodeDataInput <T> where T : IComparable
    {
        private readonly Sides _side;
        private readonly T _data;

        public NodeDataInput(Sides side, T data)
        {
            _side = side;
            _data = data;
        }
        
        public NodeDataInput(T data)
        {
            _side = Sides.None;
            _data = data;
        }

        public Sides Side => _side;

        public T Data => _data;
    }
}