[Serializable]
public class AssetReferenceT<TObject> : AssetReference // TypeDefIndex: 5700
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C0CB0 Offset: 0x28C0DB1 VA: 0x28C0CB0
	|-AssetReferenceT<object>..ctor
	|-AssetReferenceT<GameObject>..ctor
	|-AssetReferenceT<Sprite>..ctor
	|-AssetReferenceT<Texture2D>..ctor
	|-AssetReferenceT<Texture3D>..ctor
	|-AssetReferenceT<Texture>..ctor
	*/

	[ObsoleteAttribute] // RVA: 0x13E970 Offset: 0x13EA71 VA: 0x13E970
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C0CD0 Offset: 0x28C0DD1 VA: 0x28C0CD0
	|-AssetReferenceT<object>.LoadAsset
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C0D20 Offset: 0x28C0E21 VA: 0x28C0D20
	|-AssetReferenceT<object>.LoadAssetAsync
	|-AssetReferenceT<GameObject>.LoadAssetAsync
	|-AssetReferenceT<Sprite>.LoadAssetAsync
	|-AssetReferenceT<Texture2D>.LoadAssetAsync
	|-AssetReferenceT<Texture3D>.LoadAssetAsync
	|-AssetReferenceT<Texture>.LoadAssetAsync
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override bool ValidateAsset(Object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C0DA0 Offset: 0x28C0EA1 VA: 0x28C0DA0
	|-AssetReferenceT<object>.ValidateAsset
	|-AssetReferenceT<GameObject>.ValidateAsset
	|-AssetReferenceT<Sprite>.ValidateAsset
	|-AssetReferenceT<Texture2D>.ValidateAsset
	|-AssetReferenceT<Texture3D>.ValidateAsset
	|-AssetReferenceT<Texture>.ValidateAsset
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override bool ValidateAsset(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C0E50 Offset: 0x28C0F51 VA: 0x28C0E50
	|-AssetReferenceT<object>.ValidateAsset
	|-AssetReferenceT<GameObject>.ValidateAsset
	|-AssetReferenceT<Texture2D>.ValidateAsset
	|-AssetReferenceT<Texture3D>.ValidateAsset
	|-AssetReferenceT<Texture>.ValidateAsset
	*/
}

