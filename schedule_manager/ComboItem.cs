using System;

namespace schedule_manager
{
	/// <summary>
	/// Summary description for ComboItem.
	/// </summary>
	public class ComboItem
	{
		public ComboItem(string text, object value)
		{
			this.text = text;
			this._value = value;
		}
		private object _value;
		public object Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
			}
		}
		private string text;
		public string Text
		{
			get
			{
				return text;
			}
			set
			{
				text = value;
			}
		}
	}
}
