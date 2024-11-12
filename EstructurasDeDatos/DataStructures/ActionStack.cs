using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.DataStructures
{
    public class ActionStack
    {
        private Stack<EmpleadoAction> _stack = new Stack<EmpleadoAction>();

        public void Push(EmpleadoAction action)
        {
            _stack.Push(action);
        }

        public EmpleadoAction Pop()
        {
            return _stack.Count > 0 ? _stack.Pop() : null;
        }

        public EmpleadoAction Peek()
        {
            return _stack.Count > 0 ? _stack.Peek() : null;
        }

        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }

        public IEnumerable<EmpleadoAction> GetAllActions()
        {
            return _stack;
        }
    }
}
