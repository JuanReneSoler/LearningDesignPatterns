using System.Collections.Generic;

namespace Core.patrones
{
	public class SelectList : BaseComponent
	{
		private int _cursorPosition;
		private List<object> _items;

		public int CursorPosition
		{
			get => _cursorPosition;
			set
			{
				var val = value;
				if (_items.Count > 0)
				{
					if (val < 1) val = 1;
					if (val > _items.Count) val = _items.Count;
				}
				_cursorPosition = val;
			}
		}

		public SelectList()
		{
			_cursorPosition = 0;
			_items = new List<object>();
		}

		public void Add(object item) => _items.Add(item);
		public void AddRange(IEnumerable<object> items) => _items.AddRange(items);
		public void Remove(object item) => _items.Remove(item);
		public override string ToString()
		{
			var str = $"{Title}\n";
			var i = 1;
			_items.ForEach((item) =>
			 {
				 str += $"{RenderCursor(i)} {item}\n";
				 i++;
			 });
			return str;
		}

		private string RenderCursor(int position) => position == CursorPosition ? "=>" : "  ";
		public void Previous() => CursorPosition--;
		public void Next() => CursorPosition++;
		public int GetSelectedIndex() => _cursorPosition;
		public string GetSelectedValue() => _items[_cursorPosition - 1].ToString();
	}
}
