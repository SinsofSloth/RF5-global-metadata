[DefaultMemberAttribute] // RVA: 0x145EB0 Offset: 0x145FB1 VA: 0x145EB0
public class Register<T> // TypeDefIndex: 6725
{
	// Fields
	private List<T> m_registed; // 0x0

	// Properties
	public T Item { get; }
	public List<T> Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool Regist(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2920 Offset: 0x2CA2A21 VA: 0x2CA2920
	|-Register<EmotionController>.Regist
	|-Register<MobController>.Regist
	|-Register<object>.Regist
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA29B0 Offset: 0x2CA2AB1 VA: 0x2CA29B0
	|-Register<EmotionController>.Remove
	|-Register<MobController>.Remove
	|-Register<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool Get(int index, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2A40 Offset: 0x2CA2B41 VA: 0x2CA2A40
	|-Register<object>.Get
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2AF0 Offset: 0x2CA2BF1 VA: 0x2CA2AF0
	|-Register<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public List<T> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2B30 Offset: 0x2CA2C31 VA: 0x2CA2B30
	|-Register<EmotionController>.get_Values
	|-Register<object>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2B40 Offset: 0x2CA2C41 VA: 0x2CA2B40
	|-Register<EmotionController>..ctor
	|-Register<MobController>..ctor
	|-Register<object>..ctor
	*/
}

