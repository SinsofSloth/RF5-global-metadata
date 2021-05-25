[TypeForwardedFromAttribute] // RVA: 0xAB720 Offset: 0xAB821 VA: 0xAB720
public sealed class Action<T1, T2> : MulticastDelegate // TypeDefIndex: 154
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F430 Offset: 0x289F531 VA: 0x289F430
	|-Action<AudmuraCrystal, Vector3>..ctor
	|-Action<object, Vector3>..ctor
	|
	|-RVA: 0x289EFB0 Offset: 0x289F0B1 VA: 0x289EFB0
	|-Action<BulletBase, BulletDataTable>..ctor
	|-Action<SRTabController, SRTab>..ctor
	|-Action<LightCompiler, Expression>..ctor
	|-Action<object, object>..ctor
	|-Action<Task, object>..ctor
	|-Action<GameObject, MonsterControllerBase>..ctor
	|-Action<GameObject, SpcMonsterController>..ctor
	|
	|-RVA: 0x289D1B0 Offset: 0x289D2B1 VA: 0x289D1B0
	|-Action<DamageActionType, DamageResult>..ctor
	|-Action<Int32Enum, DamageResult>..ctor
	|
	|-RVA: 0x289D730 Offset: 0x289D831 VA: 0x289D730
	|-Action<MonsterDataID, GameObject>..ctor
	|-Action<MonsterModelDataID, GameObject>..ctor
	|-Action<Int32Enum, object>..ctor
	|
	|-RVA: 0x289DAD0 Offset: 0x289DBD1 VA: 0x289DAD0
	|-Action<OptionDefinition, bool>..ctor
	|-Action<IDebugPanelService, bool>..ctor
	|-Action<object, bool>..ctor
	|
	|-RVA: 0x289E530 Offset: 0x289E631 VA: 0x289E530
	|-Action<SubEventMasterDataBase, int>..ctor
	|-Action<object, int>..ctor
	|
	|-RVA: 0x289C720 Offset: 0x289C821 VA: 0x289C720
	|-Action<bool, PartyMonster>..ctor
	|-Action<bool, object>..ctor
	|-Action<bool, string>..ctor
	|
	|-RVA: 0x289CAB0 Offset: 0x289CBB1 VA: 0x289CAB0
	|-Action<int, int>..ctor
	|
	|-RVA: 0x289CE30 Offset: 0x289CF31 VA: 0x289CE30
	|-Action<int, object>..ctor
	|
	|-RVA: 0x289E020 Offset: 0x289E121 VA: 0x289E020
	|-Action<object, double>..ctor
	|
	|-RVA: 0x289EA70 Offset: 0x289EB71 VA: 0x289EA70
	|-Action<object, Int32Enum>..ctor
	|
	|-RVA: 0x289F9C0 Offset: 0x289FAC1 VA: 0x289F9C0
	|-Action<uint, ActorID>..ctor
	|-Action<uint, Int32Enum>..ctor
	|
	|-RVA: 0x289FD50 Offset: 0x289FE51 VA: 0x289FD50
	|-Action<ScriptableRenderContext, object>..ctor
	|-Action<ScriptableRenderContext, Camera[]>..ctor
	|
	|-RVA: 0x28A00D0 Offset: 0x28A01D1 VA: 0x28A00D0
	|-Action<AsyncOperationHandle, Exception>..ctor
	|-Action<AsyncOperationHandle, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F450 Offset: 0x289F551 VA: 0x289F450
	|-Action<AudmuraCrystal, Vector3>.Invoke
	|-Action<object, Vector3>.Invoke
	|
	|-RVA: 0x289EFD0 Offset: 0x289F0D1 VA: 0x289EFD0
	|-Action<BulletBase, BulletDataTable>.Invoke
	|-Action<SRTabController, SRTab>.Invoke
	|-Action<object, object>.Invoke
	|-Action<string, Action<SpriteAtlas>>.Invoke
	|-Action<Task, object>.Invoke
	|-Action<GameObject, MonsterControllerBase>.Invoke
	|-Action<GameObject, SpcMonsterController>.Invoke
	|
	|-RVA: 0x289D1D0 Offset: 0x289D2D1 VA: 0x289D1D0
	|-Action<DamageActionType, DamageResult>.Invoke
	|-Action<Int32Enum, DamageResult>.Invoke
	|
	|-RVA: 0x289D750 Offset: 0x289D851 VA: 0x289D750
	|-Action<MonsterDataID, GameObject>.Invoke
	|-Action<MonsterModelDataID, GameObject>.Invoke
	|-Action<Int32Enum, object>.Invoke
	|
	|-RVA: 0x289DAF0 Offset: 0x289DBF1 VA: 0x289DAF0
	|-Action<OptionDefinition, bool>.Invoke
	|-Action<IDebugPanelService, bool>.Invoke
	|-Action<object, bool>.Invoke
	|-Action<string, bool>.Invoke
	|
	|-RVA: 0x289E040 Offset: 0x289E141 VA: 0x289E040
	|-Action<ProfilerCameraListener, double>.Invoke
	|-Action<object, double>.Invoke
	|
	|-RVA: 0x289E550 Offset: 0x289E651 VA: 0x289E550
	|-Action<SubEventMasterDataBase, int>.Invoke
	|-Action<object, int>.Invoke
	|
	|-RVA: 0x289C740 Offset: 0x289C841 VA: 0x289C740
	|-Action<bool, PartyMonster>.Invoke
	|-Action<bool, object>.Invoke
	|-Action<bool, string>.Invoke
	|
	|-RVA: 0x289CAD0 Offset: 0x289CBD1 VA: 0x289CAD0
	|-Action<int, int>.Invoke
	|
	|-RVA: 0x289CE50 Offset: 0x289CF51 VA: 0x289CE50
	|-Action<int, object>.Invoke
	|-Action<int, string>.Invoke
	|
	|-RVA: 0x289EA90 Offset: 0x289EB91 VA: 0x289EA90
	|-Action<object, Int32Enum>.Invoke
	|-Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent>.Invoke
	|
	|-RVA: 0x289F9E0 Offset: 0x289FAE1 VA: 0x289F9E0
	|-Action<uint, ActorID>.Invoke
	|-Action<uint, Int32Enum>.Invoke
	|
	|-RVA: 0x289FD70 Offset: 0x289FE71 VA: 0x289FD70
	|-Action<ScriptableRenderContext, object>.Invoke
	|
	|-RVA: 0x28A00F0 Offset: 0x28A01F1 VA: 0x28A00F0
	|-Action<AsyncOperationHandle, Exception>.Invoke
	|-Action<AsyncOperationHandle, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289CA00 Offset: 0x289CB01 VA: 0x289CA00
	|-Action<bool, object>.BeginInvoke
	|
	|-RVA: 0x289CD80 Offset: 0x289CE81 VA: 0x289CD80
	|-Action<int, int>.BeginInvoke
	|
	|-RVA: 0x289D100 Offset: 0x289D201 VA: 0x289D100
	|-Action<int, object>.BeginInvoke
	|
	|-RVA: 0x289D670 Offset: 0x289D771 VA: 0x289D670
	|-Action<Int32Enum, DamageResult>.BeginInvoke
	|
	|-RVA: 0x289DA20 Offset: 0x289DB21 VA: 0x289DA20
	|-Action<Int32Enum, object>.BeginInvoke
	|
	|-RVA: 0x289DF70 Offset: 0x289E071 VA: 0x289DF70
	|-Action<object, bool>.BeginInvoke
	|
	|-RVA: 0x289E480 Offset: 0x289E581 VA: 0x289E480
	|-Action<object, double>.BeginInvoke
	|
	|-RVA: 0x289E9C0 Offset: 0x289EAC1 VA: 0x289E9C0
	|-Action<object, int>.BeginInvoke
	|
	|-RVA: 0x289EF00 Offset: 0x289F001 VA: 0x289EF00
	|-Action<object, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x289F3F0 Offset: 0x289F4F1 VA: 0x289F3F0
	|-Action<object, object>.BeginInvoke
	|
	|-RVA: 0x289F910 Offset: 0x289FA11 VA: 0x289F910
	|-Action<object, Vector3>.BeginInvoke
	|
	|-RVA: 0x289FC90 Offset: 0x289FD91 VA: 0x289FC90
	|-Action<uint, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x28A0020 Offset: 0x28A0121 VA: 0x28A0020
	|-Action<ScriptableRenderContext, object>.BeginInvoke
	|
	|-RVA: 0x28A0480 Offset: 0x28A0581 VA: 0x28A0480
	|-Action<AsyncOperationHandle, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289CAA0 Offset: 0x289CBA1 VA: 0x289CAA0
	|-Action<bool, object>.EndInvoke
	|
	|-RVA: 0x289CE20 Offset: 0x289CF21 VA: 0x289CE20
	|-Action<int, int>.EndInvoke
	|
	|-RVA: 0x289D1A0 Offset: 0x289D2A1 VA: 0x289D1A0
	|-Action<int, object>.EndInvoke
	|
	|-RVA: 0x289D720 Offset: 0x289D821 VA: 0x289D720
	|-Action<Int32Enum, DamageResult>.EndInvoke
	|
	|-RVA: 0x289DAC0 Offset: 0x289DBC1 VA: 0x289DAC0
	|-Action<Int32Enum, object>.EndInvoke
	|
	|-RVA: 0x289E010 Offset: 0x289E111 VA: 0x289E010
	|-Action<object, bool>.EndInvoke
	|
	|-RVA: 0x289E520 Offset: 0x289E621 VA: 0x289E520
	|-Action<object, double>.EndInvoke
	|
	|-RVA: 0x289EA60 Offset: 0x289EB61 VA: 0x289EA60
	|-Action<object, int>.EndInvoke
	|
	|-RVA: 0x289EFA0 Offset: 0x289F0A1 VA: 0x289EFA0
	|-Action<object, Int32Enum>.EndInvoke
	|
	|-RVA: 0x289F420 Offset: 0x289F521 VA: 0x289F420
	|-Action<object, object>.EndInvoke
	|
	|-RVA: 0x289F9B0 Offset: 0x289FAB1 VA: 0x289F9B0
	|-Action<object, Vector3>.EndInvoke
	|
	|-RVA: 0x289FD40 Offset: 0x289FE41 VA: 0x289FD40
	|-Action<uint, Int32Enum>.EndInvoke
	|
	|-RVA: 0x28A00C0 Offset: 0x28A01C1 VA: 0x28A00C0
	|-Action<ScriptableRenderContext, object>.EndInvoke
	|
	|-RVA: 0x28A0520 Offset: 0x28A0621 VA: 0x28A0520
	|-Action<AsyncOperationHandle, object>.EndInvoke
	*/
}

[TypeForwardedFromAttribute] // RVA: 0xAB760 Offset: 0xAB861 VA: 0xAB760
public sealed class Action<T1, T2, T3> : MulticastDelegate // TypeDefIndex: 155
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A0530 Offset: 0x28A0631 VA: 0x28A0530
	|-Action<object, bool, DebugScreenCapture>..ctor
	|
	|-RVA: 0x28A0CA0 Offset: 0x28A0DA1 VA: 0x28A0CA0
	|-Action<object, object, object>..ctor
	|
	|-RVA: 0x28A1150 Offset: 0x28A1251 VA: 0x28A1150
	|-Action<object, object, Playable>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A0550 Offset: 0x28A0651 VA: 0x28A0550
	|-Action<object, bool, DebugScreenCapture>.Invoke
	|-Action<string, bool, DebugScreenCapture>.Invoke
	|
	|-RVA: 0x28A0CC0 Offset: 0x28A0DC1 VA: 0x28A0CC0
	|-Action<object, object, object>.Invoke
	|
	|-RVA: 0x28A1170 Offset: 0x28A1271 VA: 0x28A1170
	|-Action<object, object, Playable>.Invoke
	|-Action<TimelineClip, GameObject, Playable>.Invoke
	|-Action<TrackAsset, GameObject, Playable>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A0BD0 Offset: 0x28A0CD1 VA: 0x28A0BD0
	|-Action<object, bool, DebugScreenCapture>.BeginInvoke
	|
	|-RVA: 0x28A1110 Offset: 0x28A1211 VA: 0x28A1110
	|-Action<object, object, object>.BeginInvoke
	|
	|-RVA: 0x28A15E0 Offset: 0x28A16E1 VA: 0x28A15E0
	|-Action<object, object, Playable>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A0C90 Offset: 0x28A0D91 VA: 0x28A0C90
	|-Action<object, bool, DebugScreenCapture>.EndInvoke
	|
	|-RVA: 0x28A1140 Offset: 0x28A1241 VA: 0x28A1140
	|-Action<object, object, object>.EndInvoke
	|
	|-RVA: 0x28A1680 Offset: 0x28A1781 VA: 0x28A1680
	|-Action<object, object, Playable>.EndInvoke
	*/
}

[TypeForwardedFromAttribute] // RVA: 0xAB7A0 Offset: 0xAB8A1 VA: 0xAB7A0
public sealed class Action<T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 156
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A1690 Offset: 0x28A1791 VA: 0x28A1690
	|-Action<PathOptions, Tween, Quaternion, Transform>..ctor
	|-Action<PathOptions, object, Quaternion, object>..ctor
	|
	|-RVA: 0x28A1DD0 Offset: 0x28A1ED1 VA: 0x28A1DD0
	|-Action<int, object, bool, object>..ctor
	|
	|-RVA: 0x28A21B0 Offset: 0x28A22B1 VA: 0x28A21B0
	|-Action<object, object, object, object>..ctor
	|
	|-RVA: 0x28A2690 Offset: 0x28A2791 VA: 0x28A2690
	|-Action<object, object, object, CancellationToken>..ctor
	|
	|-RVA: 0x28A2BE0 Offset: 0x28A2CE1 VA: 0x28A2BE0
	|-Action<AsyncOperationHandle, Int32Enum, int, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A16B0 Offset: 0x28A17B1 VA: 0x28A16B0
	|-Action<PathOptions, Tween, Quaternion, Transform>.Invoke
	|-Action<PathOptions, object, Quaternion, object>.Invoke
	|
	|-RVA: 0x28A26B0 Offset: 0x28A27B1 VA: 0x28A26B0
	|-Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>.Invoke
	|-Action<Stream, object, MessagePackSerializerOptions, CancellationToken>.Invoke
	|-Action<object, object, object, CancellationToken>.Invoke
	|
	|-RVA: 0x28A1DF0 Offset: 0x28A1EF1 VA: 0x28A1DF0
	|-Action<int, object, bool, object>.Invoke
	|
	|-RVA: 0x28A21D0 Offset: 0x28A22D1 VA: 0x28A21D0
	|-Action<object, object, object, object>.Invoke
	|
	|-RVA: 0x28A2C00 Offset: 0x28A2D01 VA: 0x28A2C00
	|-Action<AsyncOperationHandle, Int32Enum, int, object>.Invoke
	|-Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A1CF0 Offset: 0x28A1DF1 VA: 0x28A1CF0
	|-Action<PathOptions, object, Quaternion, object>.BeginInvoke
	|
	|-RVA: 0x28A20E0 Offset: 0x28A21E1 VA: 0x28A20E0
	|-Action<int, object, bool, object>.BeginInvoke
	|
	|-RVA: 0x28A2640 Offset: 0x28A2741 VA: 0x28A2640
	|-Action<object, object, object, object>.BeginInvoke
	|
	|-RVA: 0x28A2B20 Offset: 0x28A2C21 VA: 0x28A2B20
	|-Action<object, object, object, CancellationToken>.BeginInvoke
	|
	|-RVA: 0x28A2FD0 Offset: 0x28A30D1 VA: 0x28A2FD0
	|-Action<AsyncOperationHandle, Int32Enum, int, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A1DC0 Offset: 0x28A1EC1 VA: 0x28A1DC0
	|-Action<PathOptions, object, Quaternion, object>.EndInvoke
	|
	|-RVA: 0x28A21A0 Offset: 0x28A22A1 VA: 0x28A21A0
	|-Action<int, object, bool, object>.EndInvoke
	|
	|-RVA: 0x28A2680 Offset: 0x28A2781 VA: 0x28A2680
	|-Action<object, object, object, object>.EndInvoke
	|
	|-RVA: 0x28A2BD0 Offset: 0x28A2CD1 VA: 0x28A2BD0
	|-Action<object, object, object, CancellationToken>.EndInvoke
	|
	|-RVA: 0x28A30A0 Offset: 0x28A31A1 VA: 0x28A30A0
	|-Action<AsyncOperationHandle, Int32Enum, int, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5> : MulticastDelegate // TypeDefIndex: 162
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A30B0 Offset: 0x28A31B1 VA: 0x28A30B0
	|-Action<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A30D0 Offset: 0x28A31D1 VA: 0x28A30D0
	|-Action<object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A3580 Offset: 0x28A3681 VA: 0x28A3580
	|-Action<object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A35C0 Offset: 0x28A36C1 VA: 0x28A35C0
	|-Action<object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6> : MulticastDelegate // TypeDefIndex: 163
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A35D0 Offset: 0x28A36D1 VA: 0x28A35D0
	|-Action<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A35F0 Offset: 0x28A36F1 VA: 0x28A35F0
	|-Action<object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A3AE0 Offset: 0x28A3BE1 VA: 0x28A3AE0
	|-Action<object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A3B20 Offset: 0x28A3C21 VA: 0x28A3B20
	|-Action<object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7> : MulticastDelegate // TypeDefIndex: 164
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A3B30 Offset: 0x28A3C31 VA: 0x28A3B30
	|-Action<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A3B50 Offset: 0x28A3C51 VA: 0x28A3B50
	|-Action<object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4050 Offset: 0x28A4151 VA: 0x28A4050
	|-Action<object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4090 Offset: 0x28A4191 VA: 0x28A4090
	|-Action<object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8> : MulticastDelegate // TypeDefIndex: 165
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A40A0 Offset: 0x28A41A1 VA: 0x28A40A0
	|-Action<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A40C0 Offset: 0x28A41C1 VA: 0x28A40C0
	|-Action<object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A45C0 Offset: 0x28A46C1 VA: 0x28A45C0
	|-Action<object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4600 Offset: 0x28A4701 VA: 0x28A4600
	|-Action<object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> : MulticastDelegate // TypeDefIndex: 2143
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4610 Offset: 0x28A4711 VA: 0x28A4610
	|-Action<object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4630 Offset: 0x28A4731 VA: 0x28A4630
	|-Action<object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4B40 Offset: 0x28A4C41 VA: 0x28A4B40
	|-Action<object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4B80 Offset: 0x28A4C81 VA: 0x28A4B80
	|-Action<object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : MulticastDelegate // TypeDefIndex: 2144
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892EE0 Offset: 0x2892FE1 VA: 0x2892EE0
	|-Action<object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892F00 Offset: 0x2893001 VA: 0x2892F00
	|-Action<object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893400 Offset: 0x2893501 VA: 0x2893400
	|-Action<object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893450 Offset: 0x2893551 VA: 0x2893450
	|-Action<object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : MulticastDelegate // TypeDefIndex: 2145
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893460 Offset: 0x2893561 VA: 0x2893460
	|-Action<object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893480 Offset: 0x2893581 VA: 0x2893480
	|-Action<object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893990 Offset: 0x2893A91 VA: 0x2893990
	|-Action<object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28939E0 Offset: 0x2893AE1 VA: 0x28939E0
	|-Action<object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : MulticastDelegate // TypeDefIndex: 2146
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28939F0 Offset: 0x2893AF1 VA: 0x28939F0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893A10 Offset: 0x2893B11 VA: 0x2893A10
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893F10 Offset: 0x2894011 VA: 0x2893F10
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893F60 Offset: 0x2894061 VA: 0x2893F60
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : MulticastDelegate // TypeDefIndex: 2147
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893F70 Offset: 0x2894071 VA: 0x2893F70
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2893F90 Offset: 0x2894091 VA: 0x2893F90
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28944D0 Offset: 0x28945D1 VA: 0x28944D0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2894530 Offset: 0x2894631 VA: 0x2894530
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : MulticastDelegate // TypeDefIndex: 2148
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2894540 Offset: 0x2894641 VA: 0x2894540
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2894560 Offset: 0x2894661 VA: 0x2894560
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2894AE0 Offset: 0x2894BE1 VA: 0x2894AE0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2894B40 Offset: 0x2894C41 VA: 0x2894B40
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : MulticastDelegate // TypeDefIndex: 2149
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2894B50 Offset: 0x2894C51 VA: 0x2894B50
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2894B70 Offset: 0x2894C71 VA: 0x2894B70
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2895140 Offset: 0x2895241 VA: 0x2895140
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28951A0 Offset: 0x28952A1 VA: 0x28951A0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : MulticastDelegate // TypeDefIndex: 2150
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28951B0 Offset: 0x28952B1 VA: 0x28951B0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28951D0 Offset: 0x28952D1 VA: 0x28951D0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28957E0 Offset: 0x28958E1 VA: 0x28957E0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2895840 Offset: 0x2895941 VA: 0x2895840
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

