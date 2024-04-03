using System.Data;

namespace BankReplication.utils
{
    public class BindingSourceExtends : System.Windows.Forms.BindingSource
    {
        public BindingSourceExtends(System.ComponentModel.IContainer container) : base(container)
        {
        }

        public bool EqualsRowView(DataRowView a, DataRowView b)
        {

            try
            {
            for (int i = 0; i < a.Row.ItemArray.Length; i++)
            {
                var a_value = a.Row[i];
                var b_value = b.Row[i];

                if (!a_value.Equals(b_value)) return false;
            }
            return true;
            }
            catch
            {
                return false;
            }
        }
        public void Focus(DataRowView a)
        {
            if (this.Count == 0) return;

            // Keep row display because action clone rows will cause row is clone not display 
            this.Position--;
            this.Position++;

            int index = this.IndexOf(a);
            if (index >= 0) this.Position = index;

        }
        public int IndexOf(DataRowView a)
        {
            if (this.Count == 0) return -1;
            for (int i = 0; i < this.Count; i++)
            {
                var elementRow = (DataRowView)this[i];
                if (EqualsRowView((DataRowView)elementRow, a)) return i;
            }
            return -1;
        }
        public bool EqualsRowList(object[] a, object[] b)
        {
            try
            {

            for (int i = 0; i < a.Length; i++)
            {

                if (!a[i].Equals(b[i])) return false;
            }
            return true;
            }
            catch
            {
                return false;
            }
        }
        public int IndexOf(object[] rows)
        {
            if (this.Count == 0) return -1;
            for (int i = 0; i < this.Count; i++)
            {
                var elementRow = (DataRowView)this[i];
                if (EqualsRowList(elementRow.Row.ItemArray, rows)) return i;
            }
            return -1;
        }

    }
}
