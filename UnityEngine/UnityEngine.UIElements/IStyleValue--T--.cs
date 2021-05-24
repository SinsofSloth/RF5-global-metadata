internal interface IStyleValue<T> // TypeDefIndex: 4239
{
	// Properties
	public abstract T value { get; }
	public abstract StyleKeyword keyword { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StyleKeyword get_keyword() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_keyword
	*/
}

