[ComVisibleAttribute] // RVA: 0xAE740 Offset: 0xAE841 VA: 0xAE740
[Serializable]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 611
{
	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x17F2820 Offset: 0x17F2921 VA: 0x17F2820
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F29D0 Offset: 0x17F2AD1 VA: 0x17F29D0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F2AF0 Offset: 0x17F2BF1 VA: 0x17F2AF0 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}

