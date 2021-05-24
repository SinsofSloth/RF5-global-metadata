[UsedByNativeCodeAttribute] // RVA: 0xC4640 Offset: 0xC4741 VA: 0xC4640
[Serializable]
public struct ExposedReference<T> // TypeDefIndex: 2855
{
	// Fields
	[SerializeField] // RVA: 0xC9AA0 Offset: 0xC9BA1 VA: 0xC9AA0
	public PropertyName exposedName; // 0x0
	[SerializeField] // RVA: 0xC9AB0 Offset: 0xC9BB1 VA: 0xC9AB0
	public Object defaultValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public T Resolve(IExposedPropertyTable resolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BB30 Offset: 0x38BC31 VA: 0x38BB30
	|-ExposedReference<CinemachineVirtualCameraBase>.Resolve
	|-ExposedReference<GameObject>.Resolve
	|-ExposedReference<Transform>.Resolve
	|-ExposedReference<VideoPlayer>.Resolve
	|-ExposedReference<object>.Resolve
	*/
}

