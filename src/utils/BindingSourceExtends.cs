using System.Data;
using System.Security.Permissions;
using System.Windows.Forms;


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
        public void RemoveRow(object[] rows)
        {
            this.Focus(rows);
            this.RemoveCurrent();
        }
        public void RemoveRow(DataRowView rowView)
        {
            this.Focus(rowView);
            this.RemoveCurrent();
        }
        public void Focus(DataRowView a)
        {
            if (this.Count == 0) return;

            // Keep row display because action clone rows will cause row is clone not display 
            this.Position--;
            this.Position++;

            int index = this.IndexOf(a);
            if (index == -1) throw new System.Exception("Row not exist in binding source");
            if (index >= 0) this.Position = index;

        }
        public void Focus(object[] a)
        {
            if (this.Count == 0) return;

            if (this.Count == 1) return;
            // Keep row display because action clone rows will cause row is clone not display 
            this.Position--;
            this.Position++;

            int index = this.IndexOf(a);
            if (index == -1) throw new System.Exception("Row not exist in binding source");
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
        public void Update(int position, object[] rows)
        {
            foreach (DataRowView element in this)
            {
                if (position == 0)
                {
                    element.Row.ItemArray = rows;
                }
                position--;
            }


        }
        public void Update(object[] before, object[] after)
        {

            foreach (DataRowView element in this)
            {

                if (EqualsRowList(element.Row.ItemArray, before))
                {
                    element.Row.ItemArray = after;
                }
            }
        }



        public bool EqualsRowList(object[] a, object[] b)
        {
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].GetType() == typeof(System.String))
                    {
                        if (!(a[i].ToString().Trim() == (b[i]).ToString().Trim())) return false;
                    }
                    else if(a[i].GetType() == typeof(System.DateTime))
                    {
                        string str1 = ((System.DateTime)a[i]).ToString("yyyy/MM/dd");
                        string str2 = ((System.DateTime)b[i]).ToString("yyyy/MM/dd");
                        if (!(str1 == str2)) return false;
                    }
                    else
                    {
                        if (!a[i].Equals(b[i])) return false;
                    }
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
