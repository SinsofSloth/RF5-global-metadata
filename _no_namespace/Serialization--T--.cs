[Serializable]
public class Serialization<T> // TypeDefIndex: 6864
{
	// Fields
	[SerializeField] // RVA: 0x15FD70 Offset: 0x15FE71 VA: 0x15FD70
	private List<T> target; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public List<T> ToList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADD70 Offset: 0x2CADE71 VA: 0x2CADD70
	|-Serialization<object>.ToList
	*/

	// RVA: -1 Offset: -1
	public void .ctor(List<T> target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADD80 Offset: 0x2CADE81 VA: 0x2CADD80
	|-Serialization<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADDC0 Offset: 0x2CADEC1 VA: 0x2CADDC0
	|-Serialization<object>..ctor
	*/
}

