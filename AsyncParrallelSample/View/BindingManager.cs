using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncParrallelSample.View
{
    public class BindingManager : BindingManagerBase
    {
        public override object Current => throw new NotImplementedException();

        public override int Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int Count => throw new NotImplementedException();

        public override void AddNew()
        {
            throw new NotImplementedException();
        }

        public override void CancelCurrentEdit()
        {
            throw new NotImplementedException();
        }

        public override void EndCurrentEdit()
        {
            throw new NotImplementedException();
        }

        public override void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public override void ResumeBinding()
        {
            throw new NotImplementedException();
        }

        public override void SuspendBinding()
        {
            throw new NotImplementedException();
        }

        protected override string GetListName(ArrayList listAccessors)
        {
            throw new NotImplementedException();
        }

        protected override void OnCurrentChanged(EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnCurrentItemChanged(EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void UpdateIsBinding()
        {
            throw new NotImplementedException();
        }
    }
}
