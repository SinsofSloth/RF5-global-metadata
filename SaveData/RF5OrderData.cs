public class RF5OrderData : SaveDataValueBase // TypeDefIndex: 9894
{
	// Fields
	public OrderSaveData OrderSaveParameters; // 0x10
	public WantedSaveData WantedSaveData; // 0x38

	// Methods

	// RVA: 0x1D7C480 Offset: 0x1D7C581 VA: 0x1D7C480
	public void .ctor() { }

	// RVA: 0x1D7C4B0 Offset: 0x1D7C5B1 VA: 0x1D7C4B0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D7C4C0 Offset: 0x1D7C5C1 VA: 0x1D7C4C0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D7C520 Offset: 0x1D7C621 VA: 0x1D7C520 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D7C5D0 Offset: 0x1D7C6D1 VA: 0x1D7C5D0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D7C680 Offset: 0x1D7C781 VA: 0x1D7C680
	public void Reader0000(BinaryReader reader) { }

	// RVA: -1 Offset: -1
	private void _writer<T>(BinaryWriter writer, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D8320 Offset: 0x21D8421 VA: 0x21D8320
	|-RF5OrderData._writer<OrderSaveData>
	|
	|-RVA: 0x21D8420 Offset: 0x21D8521 VA: 0x21D8420
	|-RF5OrderData._writer<WantedSaveData>
	|-RF5OrderData._writer<object>
	*/

	// RVA: -1 Offset: -1
	private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D84E0 Offset: 0x21D85E1 VA: 0x21D84E0
	|-RF5OrderData._writer_array<object>
	*/

	// RVA: -1 Offset: -1
	private T _reader<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C7970 Offset: 0x23C7A71 VA: 0x23C7970
	|-RF5OrderData._reader<OrderSaveData>
	|
	|-RVA: 0x23C7A60 Offset: 0x23C7B61 VA: 0x23C7A60
	|-RF5OrderData._reader<WantedSaveData>
	|-RF5OrderData._reader<object>
	*/

	// RVA: -1 Offset: -1
	private T[] _reader_array<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226E160 Offset: 0x226E261 VA: 0x226E160
	|-RF5OrderData._reader_array<object>
	*/
}

