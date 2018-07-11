using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Route
    {
        public Guid Id { get; protected set; }
        public Node StartNode { get; protected set; }
        public Node EndNode { get; protected set; }

        protected Route()
        {
        }

        protected Route(Node startNode, Node endNode)
        {
            Id = Guid.NewGuid();
            StartNode = startNode;
            EndNode = endNode;
        }

        public static Route Create(Node startNode, Node endNode)
            => new Route(startNode, endNode);
    }
}
