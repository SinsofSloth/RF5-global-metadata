public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 3110
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB56A0 Offset: 0x2CB57A1 VA: 0x2CB56A0
	|-UnityAction<BodyPartsCollision, Collider>..ctor
	|-UnityAction<object, object>..ctor
	|-UnityAction<Collider, Collider>..ctor
	|
	|-RVA: 0x2CB5160 Offset: 0x2CB5261 VA: 0x2CB5160
	|-UnityAction<CharacterBase, int>..ctor
	|-UnityAction<CharacterStatusBase, int>..ctor
	|-UnityAction<MonsterProjectileActionScriptsController, int>..ctor
	|-UnityAction<object, int>..ctor
	|
	|-RVA: 0x2CB42F0 Offset: 0x2CB43F1 VA: 0x2CB42F0
	|-UnityAction<bool, bool>..ctor
	|
	|-RVA: 0x2CB46A0 Offset: 0x2CB47A1 VA: 0x2CB46A0
	|-UnityAction<bool, SceneInstance>..ctor
	|
	|-RVA: 0x2CB4A60 Offset: 0x2CB4B61 VA: 0x2CB4A60
	|-UnityAction<int, int>..ctor
	|
	|-RVA: 0x2CB4DE0 Offset: 0x2CB4EE1 VA: 0x2CB4DE0
	|-UnityAction<int, object>..ctor
	|-UnityAction<int, AudioClip>..ctor
	|-UnityAction<int, GameObject>..ctor
	|
	|-RVA: 0x2CB5B20 Offset: 0x2CB5C21 VA: 0x2CB5B20
	|-UnityAction<object, Vector3>..ctor
	|-UnityAction<Collider, Vector3>..ctor
	|
	|-RVA: 0x2CB60B0 Offset: 0x2CB61B1 VA: 0x2CB60B0
	|-UnityAction<Scene, Int32Enum>..ctor
	|-UnityAction<Scene, LoadSceneMode>..ctor
	|
	|-RVA: 0x2CB6440 Offset: 0x2CB6541 VA: 0x2CB6440
	|-UnityAction<Scene, Scene>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB4310 Offset: 0x2CB4411 VA: 0x2CB4310
	|-UnityAction<bool, bool>.Invoke
	|
	|-RVA: 0x2CB46C0 Offset: 0x2CB47C1 VA: 0x2CB46C0
	|-UnityAction<bool, SceneInstance>.Invoke
	|
	|-RVA: 0x2CB4A80 Offset: 0x2CB4B81 VA: 0x2CB4A80
	|-UnityAction<int, int>.Invoke
	|
	|-RVA: 0x2CB4E00 Offset: 0x2CB4F01 VA: 0x2CB4E00
	|-UnityAction<int, object>.Invoke
	|
	|-RVA: 0x2CB5180 Offset: 0x2CB5281 VA: 0x2CB5180
	|-UnityAction<object, int>.Invoke
	|
	|-RVA: 0x2CB56C0 Offset: 0x2CB57C1 VA: 0x2CB56C0
	|-UnityAction<object, object>.Invoke
	|
	|-RVA: 0x2CB5B40 Offset: 0x2CB5C41 VA: 0x2CB5B40
	|-UnityAction<object, Vector3>.Invoke
	|
	|-RVA: 0x2CB60D0 Offset: 0x2CB61D1 VA: 0x2CB60D0
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, LoadSceneMode>.Invoke
	|
	|-RVA: 0x2CB6460 Offset: 0x2CB6561 VA: 0x2CB6460
	|-UnityAction<Scene, Scene>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB45E0 Offset: 0x2CB46E1 VA: 0x2CB45E0
	|-UnityAction<bool, bool>.BeginInvoke
	|
	|-RVA: 0x2CB49A0 Offset: 0x2CB4AA1 VA: 0x2CB49A0
	|-UnityAction<bool, SceneInstance>.BeginInvoke
	|
	|-RVA: 0x2CB4D30 Offset: 0x2CB4E31 VA: 0x2CB4D30
	|-UnityAction<int, int>.BeginInvoke
	|
	|-RVA: 0x2CB50B0 Offset: 0x2CB51B1 VA: 0x2CB50B0
	|-UnityAction<int, object>.BeginInvoke
	|
	|-RVA: 0x2CB55F0 Offset: 0x2CB56F1 VA: 0x2CB55F0
	|-UnityAction<object, int>.BeginInvoke
	|
	|-RVA: 0x2CB5AE0 Offset: 0x2CB5BE1 VA: 0x2CB5AE0
	|-UnityAction<object, object>.BeginInvoke
	|
	|-RVA: 0x2CB6000 Offset: 0x2CB6101 VA: 0x2CB6000
	|-UnityAction<object, Vector3>.BeginInvoke
	|
	|-RVA: 0x2CB6380 Offset: 0x2CB6481 VA: 0x2CB6380
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2CB6710 Offset: 0x2CB6811 VA: 0x2CB6710
	|-UnityAction<Scene, Scene>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB4690 Offset: 0x2CB4791 VA: 0x2CB4690
	|-UnityAction<bool, bool>.EndInvoke
	|
	|-RVA: 0x2CB4A50 Offset: 0x2CB4B51 VA: 0x2CB4A50
	|-UnityAction<bool, SceneInstance>.EndInvoke
	|
	|-RVA: 0x2CB4DD0 Offset: 0x2CB4ED1 VA: 0x2CB4DD0
	|-UnityAction<int, int>.EndInvoke
	|
	|-RVA: 0x2CB5150 Offset: 0x2CB5251 VA: 0x2CB5150
	|-UnityAction<int, object>.EndInvoke
	|
	|-RVA: 0x2CB5690 Offset: 0x2CB5791 VA: 0x2CB5690
	|-UnityAction<object, int>.EndInvoke
	|
	|-RVA: 0x2CB5B10 Offset: 0x2CB5C11 VA: 0x2CB5B10
	|-UnityAction<object, object>.EndInvoke
	|
	|-RVA: 0x2CB60A0 Offset: 0x2CB61A1 VA: 0x2CB60A0
	|-UnityAction<object, Vector3>.EndInvoke
	|
	|-RVA: 0x2CB6430 Offset: 0x2CB6531 VA: 0x2CB6430
	|-UnityAction<Scene, Int32Enum>.EndInvoke
	|
	|-RVA: 0x2CB67B0 Offset: 0x2CB68B1 VA: 0x2CB67B0
	|-UnityAction<Scene, Scene>.EndInvoke
	*/
}

public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 3112
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB7AE0 Offset: 0x2CB7BE1 VA: 0x2CB7AE0
	|-UnityAction<CharacterBase, MonsterProjectileActionScriptsController, int>..ctor
	|-UnityAction<object, object, int>..ctor
	|
	|-RVA: 0x2CB84B0 Offset: 0x2CB85B1 VA: 0x2CB84B0
	|-UnityAction<CharacterBase, Collider, Vector3>..ctor
	|-UnityAction<object, object, Vector3>..ctor
	|
	|-RVA: 0x2CB67C0 Offset: 0x2CB68C1 VA: 0x2CB67C0
	|-UnityAction<object, int, DamageInfo>..ctor
	|
	|-RVA: 0x2CB7590 Offset: 0x2CB7691 VA: 0x2CB7590
	|-UnityAction<object, int, int>..ctor
	|
	|-RVA: 0x2CB8000 Offset: 0x2CB8101 VA: 0x2CB8000
	|-UnityAction<object, object, object>..ctor
	|
	|-RVA: 0x2CB8A30 Offset: 0x2CB8B31 VA: 0x2CB8A30
	|-UnityAction<object, Vector3, Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB67E0 Offset: 0x2CB68E1 VA: 0x2CB67E0
	|-UnityAction<object, int, DamageInfo>.Invoke
	|
	|-RVA: 0x2CB75B0 Offset: 0x2CB76B1 VA: 0x2CB75B0
	|-UnityAction<object, int, int>.Invoke
	|
	|-RVA: 0x2CB7B00 Offset: 0x2CB7C01 VA: 0x2CB7B00
	|-UnityAction<object, object, int>.Invoke
	|
	|-RVA: 0x2CB8020 Offset: 0x2CB8121 VA: 0x2CB8020
	|-UnityAction<object, object, object>.Invoke
	|
	|-RVA: 0x2CB84D0 Offset: 0x2CB85D1 VA: 0x2CB84D0
	|-UnityAction<object, object, Vector3>.Invoke
	|
	|-RVA: 0x2CB8A50 Offset: 0x2CB8B51 VA: 0x2CB8A50
	|-UnityAction<object, Vector3, Vector3>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB74C0 Offset: 0x2CB75C1 VA: 0x2CB74C0
	|-UnityAction<object, int, DamageInfo>.BeginInvoke
	|
	|-RVA: 0x2CB7A20 Offset: 0x2CB7B21 VA: 0x2CB7A20
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-RVA: 0x2CB7F50 Offset: 0x2CB8051 VA: 0x2CB7F50
	|-UnityAction<object, object, int>.BeginInvoke
	|
	|-RVA: 0x2CB8470 Offset: 0x2CB8571 VA: 0x2CB8470
	|-UnityAction<object, object, object>.BeginInvoke
	|
	|-RVA: 0x2CB8970 Offset: 0x2CB8A71 VA: 0x2CB8970
	|-UnityAction<object, object, Vector3>.BeginInvoke
	|
	|-RVA: 0x2CB8F60 Offset: 0x2CB9061 VA: 0x2CB8F60
	|-UnityAction<object, Vector3, Vector3>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB7580 Offset: 0x2CB7681 VA: 0x2CB7580
	|-UnityAction<object, int, DamageInfo>.EndInvoke
	|
	|-RVA: 0x2CB7AD0 Offset: 0x2CB7BD1 VA: 0x2CB7AD0
	|-UnityAction<object, int, int>.EndInvoke
	|
	|-RVA: 0x2CB7FF0 Offset: 0x2CB80F1 VA: 0x2CB7FF0
	|-UnityAction<object, object, int>.EndInvoke
	|
	|-RVA: 0x2CB84A0 Offset: 0x2CB85A1 VA: 0x2CB84A0
	|-UnityAction<object, object, object>.EndInvoke
	|
	|-RVA: 0x2CB8A20 Offset: 0x2CB8B21 VA: 0x2CB8A20
	|-UnityAction<object, object, Vector3>.EndInvoke
	|
	|-RVA: 0x2CB9020 Offset: 0x2CB9121 VA: 0x2CB9020
	|-UnityAction<object, Vector3, Vector3>.EndInvoke
	*/
}

public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3114
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB9030 Offset: 0x2CB9131 VA: 0x2CB9030
	|-UnityAction<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB9050 Offset: 0x2CB9151 VA: 0x2CB9050
	|-UnityAction<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB94C0 Offset: 0x2CB95C1 VA: 0x2CB94C0
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB9500 Offset: 0x2CB9601 VA: 0x2CB9500
	|-UnityAction<object, object, object, object>.EndInvoke
	*/
}

