[Serializable]
public abstract class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 3111
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD93E0 Offset: 0xD94E1 VA: 0xD93E0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBC730 Offset: 0x2CBC831 VA: 0x2CBC730
	|-UnityEvent<BodyPartsCollision, Collider>..ctor
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>..ctor
	|-UnityEvent<object, object>..ctor
	|-UnityEvent<Collider, Collider>..ctor
	|
	|-RVA: 0x2CBC130 Offset: 0x2CBC231 VA: 0x2CBC130
	|-UnityEvent<CharacterBase, int>..ctor
	|-UnityEvent<CharacterStatusBase, int>..ctor
	|-UnityEvent<MonsterProjectileActionScriptsController, int>..ctor
	|-UnityEvent<object, int>..ctor
	|
	|-RVA: 0x2CBBAE0 Offset: 0x2CBBBE1 VA: 0x2CBBAE0
	|-UnityEvent<bool, bool>..ctor
	|
	|-RVA: 0x2CBCCF0 Offset: 0x2CBCDF1 VA: 0x2CBCCF0
	|-UnityEvent<object, Vector3>..ctor
	|-UnityEvent<Collider, Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBC770 Offset: 0x2CBC871 VA: 0x2CBC770
	|-UnityEvent<BodyPartsCollision, Collider>.AddListener
	|-UnityEvent<object, object>.AddListener
	|-UnityEvent<Collider, Collider>.AddListener
	|
	|-RVA: 0x2CBC170 Offset: 0x2CBC271 VA: 0x2CBC170
	|-UnityEvent<CharacterBase, int>.AddListener
	|-UnityEvent<CharacterStatusBase, int>.AddListener
	|-UnityEvent<MonsterProjectileActionScriptsController, int>.AddListener
	|-UnityEvent<object, int>.AddListener
	|
	|-RVA: 0x2CBBB20 Offset: 0x2CBBC21 VA: 0x2CBBB20
	|-UnityEvent<bool, bool>.AddListener
	|
	|-RVA: 0x2CBCD30 Offset: 0x2CBCE31 VA: 0x2CBCD30
	|-UnityEvent<object, Vector3>.AddListener
	|-UnityEvent<Collider, Vector3>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBC7C0 Offset: 0x2CBC8C1 VA: 0x2CBC7C0
	|-UnityEvent<BodyPartsCollision, Collider>.RemoveListener
	|-UnityEvent<object, object>.RemoveListener
	|
	|-RVA: 0x2CBC1C0 Offset: 0x2CBC2C1 VA: 0x2CBC1C0
	|-UnityEvent<MonsterProjectileActionScriptsController, int>.RemoveListener
	|-UnityEvent<object, int>.RemoveListener
	|
	|-RVA: 0x2CBBB70 Offset: 0x2CBBC71 VA: 0x2CBBB70
	|-UnityEvent<bool, bool>.RemoveListener
	|
	|-RVA: 0x2CBCD80 Offset: 0x2CBCE81 VA: 0x2CBCD80
	|-UnityEvent<object, Vector3>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBC810 Offset: 0x2CBC911 VA: 0x2CBC810
	|-UnityEvent<BodyPartsCollision, Collider>.FindMethod_Impl
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>.FindMethod_Impl
	|-UnityEvent<object, object>.FindMethod_Impl
	|-UnityEvent<Collider, Collider>.FindMethod_Impl
	|
	|-RVA: 0x2CBC210 Offset: 0x2CBC311 VA: 0x2CBC210
	|-UnityEvent<CharacterBase, int>.FindMethod_Impl
	|-UnityEvent<CharacterStatusBase, int>.FindMethod_Impl
	|-UnityEvent<MonsterProjectileActionScriptsController, int>.FindMethod_Impl
	|-UnityEvent<object, int>.FindMethod_Impl
	|
	|-RVA: 0x2CBBBC0 Offset: 0x2CBBCC1 VA: 0x2CBBBC0
	|-UnityEvent<bool, bool>.FindMethod_Impl
	|
	|-RVA: 0x2CBCDD0 Offset: 0x2CBCED1 VA: 0x2CBCDD0
	|-UnityEvent<object, Vector3>.FindMethod_Impl
	|-UnityEvent<Collider, Vector3>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBC970 Offset: 0x2CBCA71 VA: 0x2CBC970
	|-UnityEvent<BodyPartsCollision, Collider>.GetDelegate
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>.GetDelegate
	|-UnityEvent<object, object>.GetDelegate
	|-UnityEvent<Collider, Collider>.GetDelegate
	|
	|-RVA: 0x2CBC370 Offset: 0x2CBC471 VA: 0x2CBC370
	|-UnityEvent<CharacterBase, int>.GetDelegate
	|-UnityEvent<CharacterStatusBase, int>.GetDelegate
	|-UnityEvent<MonsterProjectileActionScriptsController, int>.GetDelegate
	|-UnityEvent<object, int>.GetDelegate
	|
	|-RVA: 0x2CBBD20 Offset: 0x2CBBE21 VA: 0x2CBBD20
	|-UnityEvent<bool, bool>.GetDelegate
	|
	|-RVA: 0x2CBCF30 Offset: 0x2CBD031 VA: 0x2CBCF30
	|-UnityEvent<object, Vector3>.GetDelegate
	|-UnityEvent<Collider, Vector3>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBBDA0 Offset: 0x2CBBEA1 VA: 0x2CBBDA0
	|-UnityEvent<bool, bool>.GetDelegate
	|
	|-RVA: 0x2CBC3F0 Offset: 0x2CBC4F1 VA: 0x2CBC3F0
	|-UnityEvent<object, int>.GetDelegate
	|
	|-RVA: 0x2CBC9F0 Offset: 0x2CBCAF1 VA: 0x2CBC9F0
	|-UnityEvent<object, object>.GetDelegate
	|
	|-RVA: 0x2CBCFB0 Offset: 0x2CBD0B1 VA: 0x2CBCFB0
	|-UnityEvent<object, Vector3>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBCAB0 Offset: 0x2CBCBB1 VA: 0x2CBCAB0
	|-UnityEvent<BodyPartsCollision, Collider>.Invoke
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>.Invoke
	|-UnityEvent<object, object>.Invoke
	|-UnityEvent<Collider, Collider>.Invoke
	|
	|-RVA: 0x2CBC4B0 Offset: 0x2CBC5B1 VA: 0x2CBC4B0
	|-UnityEvent<CharacterBase, int>.Invoke
	|-UnityEvent<CharacterStatusBase, int>.Invoke
	|-UnityEvent<MonsterProjectileActionScriptsController, int>.Invoke
	|-UnityEvent<object, int>.Invoke
	|
	|-RVA: 0x2CBBE60 Offset: 0x2CBBF61 VA: 0x2CBBE60
	|-UnityEvent<bool, bool>.Invoke
	|
	|-RVA: 0x2CBD070 Offset: 0x2CBD171 VA: 0x2CBD070
	|-UnityEvent<object, Vector3>.Invoke
	|-UnityEvent<Collider, Vector3>.Invoke
	*/
}

[Serializable]
public abstract class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 3113
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD93F0 Offset: 0xD94F1 VA: 0xD93F0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBE160 Offset: 0x2CBE261 VA: 0x2CBE160
	|-UnityEvent<CharacterBase, MonsterProjectileActionScriptsController, int>..ctor
	|-UnityEvent<object, object, int>..ctor
	|
	|-RVA: 0x2CBEE50 Offset: 0x2CBEF51 VA: 0x2CBEE50
	|-UnityEvent<CharacterBase, Collider, Vector3>..ctor
	|-UnityEvent<object, object, Vector3>..ctor
	|
	|-RVA: 0x2CBF500 Offset: 0x2CBF601 VA: 0x2CBF500
	|-UnityEvent<CharacterBase, Vector3, Vector3>..ctor
	|-UnityEvent<object, Vector3, Vector3>..ctor
	|
	|-RVA: 0x2CBD310 Offset: 0x2CBD411 VA: 0x2CBD310
	|-UnityEvent<CharacterStatusBase, int, DamageInfo>..ctor
	|-UnityEvent<object, int, DamageInfo>..ctor
	|
	|-RVA: 0x2CBDAA0 Offset: 0x2CBDBA1 VA: 0x2CBDAA0
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<string, int, int>..ctor
	|
	|-RVA: 0x2CBE7F0 Offset: 0x2CBE8F1 VA: 0x2CBE7F0
	|-UnityEvent<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1, T2> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBE1A0 Offset: 0x2CBE2A1 VA: 0x2CBE1A0
	|-UnityEvent<CharacterBase, MonsterProjectileActionScriptsController, int>.AddListener
	|-UnityEvent<object, object, int>.AddListener
	|
	|-RVA: 0x2CBEE90 Offset: 0x2CBEF91 VA: 0x2CBEE90
	|-UnityEvent<CharacterBase, Collider, Vector3>.AddListener
	|-UnityEvent<object, object, Vector3>.AddListener
	|
	|-RVA: 0x2CBD350 Offset: 0x2CBD451 VA: 0x2CBD350
	|-UnityEvent<object, int, DamageInfo>.AddListener
	|
	|-RVA: 0x2CBDAE0 Offset: 0x2CBDBE1 VA: 0x2CBDAE0
	|-UnityEvent<object, int, int>.AddListener
	|
	|-RVA: 0x2CBE830 Offset: 0x2CBE931 VA: 0x2CBE830
	|-UnityEvent<object, object, object>.AddListener
	|
	|-RVA: 0x2CBF540 Offset: 0x2CBF641 VA: 0x2CBF540
	|-UnityEvent<object, Vector3, Vector3>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1, T2> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBE1F0 Offset: 0x2CBE2F1 VA: 0x2CBE1F0
	|-UnityEvent<CharacterBase, MonsterProjectileActionScriptsController, int>.RemoveListener
	|-UnityEvent<object, object, int>.RemoveListener
	|
	|-RVA: 0x2CBEEE0 Offset: 0x2CBEFE1 VA: 0x2CBEEE0
	|-UnityEvent<CharacterBase, Collider, Vector3>.RemoveListener
	|-UnityEvent<object, object, Vector3>.RemoveListener
	|
	|-RVA: 0x2CBD3A0 Offset: 0x2CBD4A1 VA: 0x2CBD3A0
	|-UnityEvent<object, int, DamageInfo>.RemoveListener
	|
	|-RVA: 0x2CBDB30 Offset: 0x2CBDC31 VA: 0x2CBDB30
	|-UnityEvent<object, int, int>.RemoveListener
	|
	|-RVA: 0x2CBE880 Offset: 0x2CBE981 VA: 0x2CBE880
	|-UnityEvent<object, object, object>.RemoveListener
	|
	|-RVA: 0x2CBF590 Offset: 0x2CBF691 VA: 0x2CBF590
	|-UnityEvent<object, Vector3, Vector3>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBE240 Offset: 0x2CBE341 VA: 0x2CBE240
	|-UnityEvent<CharacterBase, MonsterProjectileActionScriptsController, int>.FindMethod_Impl
	|-UnityEvent<object, object, int>.FindMethod_Impl
	|
	|-RVA: 0x2CBEF30 Offset: 0x2CBF031 VA: 0x2CBEF30
	|-UnityEvent<CharacterBase, Collider, Vector3>.FindMethod_Impl
	|-UnityEvent<object, object, Vector3>.FindMethod_Impl
	|
	|-RVA: 0x2CBF5E0 Offset: 0x2CBF6E1 VA: 0x2CBF5E0
	|-UnityEvent<CharacterBase, Vector3, Vector3>.FindMethod_Impl
	|-UnityEvent<object, Vector3, Vector3>.FindMethod_Impl
	|
	|-RVA: 0x2CBD3F0 Offset: 0x2CBD4F1 VA: 0x2CBD3F0
	|-UnityEvent<CharacterStatusBase, int, DamageInfo>.FindMethod_Impl
	|-UnityEvent<object, int, DamageInfo>.FindMethod_Impl
	|
	|-RVA: 0x2CBDB80 Offset: 0x2CBDC81 VA: 0x2CBDB80
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|-UnityEvent<string, int, int>.FindMethod_Impl
	|
	|-RVA: 0x2CBE8D0 Offset: 0x2CBE9D1 VA: 0x2CBE8D0
	|-UnityEvent<object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBE3F0 Offset: 0x2CBE4F1 VA: 0x2CBE3F0
	|-UnityEvent<CharacterBase, MonsterProjectileActionScriptsController, int>.GetDelegate
	|-UnityEvent<object, object, int>.GetDelegate
	|
	|-RVA: 0x2CBF0E0 Offset: 0x2CBF1E1 VA: 0x2CBF0E0
	|-UnityEvent<CharacterBase, Collider, Vector3>.GetDelegate
	|-UnityEvent<object, object, Vector3>.GetDelegate
	|
	|-RVA: 0x2CBF790 Offset: 0x2CBF891 VA: 0x2CBF790
	|-UnityEvent<CharacterBase, Vector3, Vector3>.GetDelegate
	|-UnityEvent<object, Vector3, Vector3>.GetDelegate
	|
	|-RVA: 0x2CBD5A0 Offset: 0x2CBD6A1 VA: 0x2CBD5A0
	|-UnityEvent<CharacterStatusBase, int, DamageInfo>.GetDelegate
	|-UnityEvent<object, int, DamageInfo>.GetDelegate
	|
	|-RVA: 0x2CBDD30 Offset: 0x2CBDE31 VA: 0x2CBDD30
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<string, int, int>.GetDelegate
	|
	|-RVA: 0x2CBEA80 Offset: 0x2CBEB81 VA: 0x2CBEA80
	|-UnityEvent<object, object, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD620 Offset: 0x2CBD721 VA: 0x2CBD620
	|-UnityEvent<object, int, DamageInfo>.GetDelegate
	|
	|-RVA: 0x2CBDDB0 Offset: 0x2CBDEB1 VA: 0x2CBDDB0
	|-UnityEvent<object, int, int>.GetDelegate
	|
	|-RVA: 0x2CBE470 Offset: 0x2CBE571 VA: 0x2CBE470
	|-UnityEvent<object, object, int>.GetDelegate
	|
	|-RVA: 0x2CBEB00 Offset: 0x2CBEC01 VA: 0x2CBEB00
	|-UnityEvent<object, object, object>.GetDelegate
	|
	|-RVA: 0x2CBF160 Offset: 0x2CBF261 VA: 0x2CBF160
	|-UnityEvent<object, object, Vector3>.GetDelegate
	|
	|-RVA: 0x2CBF810 Offset: 0x2CBF911 VA: 0x2CBF810
	|-UnityEvent<object, Vector3, Vector3>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBE530 Offset: 0x2CBE631 VA: 0x2CBE530
	|-UnityEvent<CharacterBase, MonsterProjectileActionScriptsController, int>.Invoke
	|-UnityEvent<object, object, int>.Invoke
	|
	|-RVA: 0x2CBF220 Offset: 0x2CBF321 VA: 0x2CBF220
	|-UnityEvent<CharacterBase, Collider, Vector3>.Invoke
	|-UnityEvent<object, object, Vector3>.Invoke
	|
	|-RVA: 0x2CBF8D0 Offset: 0x2CBF9D1 VA: 0x2CBF8D0
	|-UnityEvent<CharacterBase, Vector3, Vector3>.Invoke
	|-UnityEvent<object, Vector3, Vector3>.Invoke
	|
	|-RVA: 0x2CBD6E0 Offset: 0x2CBD7E1 VA: 0x2CBD6E0
	|-UnityEvent<object, int, DamageInfo>.Invoke
	|
	|-RVA: 0x2CBDE70 Offset: 0x2CBDF71 VA: 0x2CBDE70
	|-UnityEvent<object, int, int>.Invoke
	|-UnityEvent<string, int, int>.Invoke
	|
	|-RVA: 0x2CBEBC0 Offset: 0x2CBECC1 VA: 0x2CBEBC0
	|-UnityEvent<object, object, object>.Invoke
	*/
}

[Serializable]
public abstract class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 3115
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD9400 Offset: 0xD9501 VA: 0xD9400
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBFC00 Offset: 0x2CBFD01 VA: 0x2CBFC00
	|-UnityEvent<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBFC40 Offset: 0x2CBFD41 VA: 0x2CBFC40
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBFE30 Offset: 0x2CBFF31 VA: 0x2CBFE30
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/
}

