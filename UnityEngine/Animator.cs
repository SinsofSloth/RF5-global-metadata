[NativeHeaderAttribute] // RVA: 0xE8A50 Offset: 0xE8B51 VA: 0xE8A50
[NativeHeaderAttribute] // RVA: 0xE8A50 Offset: 0xE8B51 VA: 0xE8A50
[NativeHeaderAttribute] // RVA: 0xE8A50 Offset: 0xE8B51 VA: 0xE8A50
[UsedByNativeCodeAttribute] // RVA: 0xE8A50 Offset: 0xE8B51 VA: 0xE8A50
public class Animator : Behaviour // TypeDefIndex: 3486
{
	// Properties
	public bool isOptimizable { get; }
	public bool isHuman { get; }
	public bool hasRootMotion { get; }
	internal bool isRootPositionOrRotationControlledByCurves { get; }
	public float humanScale { get; }
	public bool isInitialized { get; }
	public Vector3 deltaPosition { get; }
	public Quaternion deltaRotation { get; }
	public Vector3 velocity { get; }
	public Vector3 angularVelocity { get; }
	public Vector3 rootPosition { get; set; }
	public Quaternion rootRotation { get; set; }
	public bool applyRootMotion { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE530 Offset: 0xEE631 VA: 0xEE530
	public bool linearVelocityBlending { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE570 Offset: 0xEE671 VA: 0xEE570
	public bool animatePhysics { get; set; }
	public AnimatorUpdateMode updateMode { get; set; }
	public bool hasTransformHierarchy { get; }
	internal bool allowConstantClipSamplingOptimization { get; set; }
	public float gravityWeight { get; }
	public Vector3 bodyPosition { get; set; }
	internal Vector3 bodyPositionInternal { get; set; }
	public Quaternion bodyRotation { get; set; }
	internal Quaternion bodyRotationInternal { get; set; }
	public bool stabilizeFeet { get; set; }
	public int layerCount { get; }
	public AnimatorControllerParameter[] parameters { get; }
	public int parameterCount { get; }
	public float feetPivotActive { get; set; }
	public float pivotWeight { get; }
	public Vector3 pivotPosition { get; }
	public bool isMatchingTarget { get; }
	public float speed { get; set; }
	public Vector3 targetPosition { get; }
	public Quaternion targetRotation { get; }
	internal Transform avatarRoot { get; }
	public AnimatorCullingMode cullingMode { get; set; }
	public float playbackTime { get; set; }
	public float recorderStartTime { get; set; }
	public float recorderStopTime { get; set; }
	public AnimatorRecorderMode recorderMode { get; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { get; set; }
	public PlayableGraph playableGraph { get; }
	public bool layersAffectMassCenter { get; set; }
	public float leftFeetBottomHeight { get; }
	public float rightFeetBottomHeight { get; }
	[NativeConditionalAttribute] // RVA: 0xEE5B0 Offset: 0xEE6B1 VA: 0xEE5B0
	internal bool supportsOnAnimatorMove { get; }
	public bool logWarnings { get; set; }
	public bool fireEvents { get; set; }
	public bool keepAnimatorControllerStateOnDisable { get; set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xEAC70 Offset: 0xEAD71 VA: 0xEAC70
	// RVA: 0x1AF6BB0 Offset: 0x1AF6CB1 VA: 0x1AF6BB0
	public bool get_isOptimizable() { }

	[NativeMethodAttribute] // RVA: 0xEACB0 Offset: 0xEADB1 VA: 0xEACB0
	// RVA: 0x1AF6C00 Offset: 0x1AF6D01 VA: 0x1AF6C00
	public bool get_isHuman() { }

	[NativeMethodAttribute] // RVA: 0xEACF0 Offset: 0xEADF1 VA: 0xEACF0
	// RVA: 0x1AF6C50 Offset: 0x1AF6D51 VA: 0x1AF6C50
	public bool get_hasRootMotion() { }

	[NativeMethodAttribute] // RVA: 0xEAD30 Offset: 0xEAE31 VA: 0xEAD30
	// RVA: 0x1AF6CA0 Offset: 0x1AF6DA1 VA: 0x1AF6CA0
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x1AF6CF0 Offset: 0x1AF6DF1 VA: 0x1AF6CF0
	public float get_humanScale() { }

	[NativeMethodAttribute] // RVA: 0xEAD70 Offset: 0xEAE71 VA: 0xEAD70
	// RVA: 0x1AF6D40 Offset: 0x1AF6E41 VA: 0x1AF6D40
	public bool get_isInitialized() { }

	// RVA: 0x1AF6D90 Offset: 0x1AF6E91 VA: 0x1AF6D90
	public float GetFloat(string name) { }

	// RVA: 0x1AF6E30 Offset: 0x1AF6F31 VA: 0x1AF6E30
	public float GetFloat(int id) { }

	// RVA: 0x1AF6ED0 Offset: 0x1AF6FD1 VA: 0x1AF6ED0
	public void SetFloat(string name, float value) { }

	// RVA: 0x1AF6F90 Offset: 0x1AF7091 VA: 0x1AF6F90
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x1AF7090 Offset: 0x1AF7191 VA: 0x1AF7090
	public void SetFloat(int id, float value) { }

	// RVA: 0x1AF7150 Offset: 0x1AF7251 VA: 0x1AF7150
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x1AF7250 Offset: 0x1AF7351 VA: 0x1AF7250
	public bool GetBool(string name) { }

	// RVA: 0x1AF72F0 Offset: 0x1AF73F1 VA: 0x1AF72F0
	public bool GetBool(int id) { }

	// RVA: 0x1AF7390 Offset: 0x1AF7491 VA: 0x1AF7390
	public void SetBool(string name, bool value) { }

	// RVA: 0x1AF7450 Offset: 0x1AF7551 VA: 0x1AF7450
	public void SetBool(int id, bool value) { }

	// RVA: 0x1AF7510 Offset: 0x1AF7611 VA: 0x1AF7510
	public int GetInteger(string name) { }

	// RVA: 0x1AF75B0 Offset: 0x1AF76B1 VA: 0x1AF75B0
	public int GetInteger(int id) { }

	// RVA: 0x1AF7650 Offset: 0x1AF7751 VA: 0x1AF7650
	public void SetInteger(string name, int value) { }

	// RVA: 0x1AF7710 Offset: 0x1AF7811 VA: 0x1AF7710
	public void SetInteger(int id, int value) { }

	// RVA: 0x1AF77D0 Offset: 0x1AF78D1 VA: 0x1AF77D0
	public void SetTrigger(string name) { }

	// RVA: 0x1AF7870 Offset: 0x1AF7971 VA: 0x1AF7870
	public void SetTrigger(int id) { }

	// RVA: 0x1AF7910 Offset: 0x1AF7A11 VA: 0x1AF7910
	public void ResetTrigger(string name) { }

	// RVA: 0x1AF79B0 Offset: 0x1AF7AB1 VA: 0x1AF79B0
	public void ResetTrigger(int id) { }

	// RVA: 0x1AF7A50 Offset: 0x1AF7B51 VA: 0x1AF7A50
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x1AF7AF0 Offset: 0x1AF7BF1 VA: 0x1AF7AF0
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x1AF7B90 Offset: 0x1AF7C91 VA: 0x1AF7B90
	public Vector3 get_deltaPosition() { }

	// RVA: 0x1AF7C40 Offset: 0x1AF7D41 VA: 0x1AF7C40
	public Quaternion get_deltaRotation() { }

	// RVA: 0x1AF7CF0 Offset: 0x1AF7DF1 VA: 0x1AF7CF0
	public Vector3 get_velocity() { }

	// RVA: 0x1AF7DA0 Offset: 0x1AF7EA1 VA: 0x1AF7DA0
	public Vector3 get_angularVelocity() { }

	[NativeMethodAttribute] // RVA: 0xEADB0 Offset: 0xEAEB1 VA: 0xEADB0
	// RVA: 0x1AF7E50 Offset: 0x1AF7F51 VA: 0x1AF7E50
	public Vector3 get_rootPosition() { }

	[NativeMethodAttribute] // RVA: 0xEADF0 Offset: 0xEAEF1 VA: 0xEADF0
	// RVA: 0x1AF7F00 Offset: 0x1AF8001 VA: 0x1AF7F00
	public void set_rootPosition(Vector3 value) { }

	[NativeMethodAttribute] // RVA: 0xEAE30 Offset: 0xEAF31 VA: 0xEAE30
	// RVA: 0x1AF7FB0 Offset: 0x1AF80B1 VA: 0x1AF7FB0
	public Quaternion get_rootRotation() { }

	[NativeMethodAttribute] // RVA: 0xEAE70 Offset: 0xEAF71 VA: 0xEAE70
	// RVA: 0x1AF8060 Offset: 0x1AF8161 VA: 0x1AF8060
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x1AF8110 Offset: 0x1AF8211 VA: 0x1AF8110
	public bool get_applyRootMotion() { }

	// RVA: 0x1AF8160 Offset: 0x1AF8261 VA: 0x1AF8160
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x1AF81B0 Offset: 0x1AF82B1 VA: 0x1AF81B0
	public bool get_linearVelocityBlending() { }

	// RVA: 0x1AF8200 Offset: 0x1AF8301 VA: 0x1AF8200
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x1AF8250 Offset: 0x1AF8351 VA: 0x1AF8250
	public bool get_animatePhysics() { }

	// RVA: 0x1AF82F0 Offset: 0x1AF83F1 VA: 0x1AF82F0
	public void set_animatePhysics(bool value) { }

	// RVA: 0x1AF82A0 Offset: 0x1AF83A1 VA: 0x1AF82A0
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x1AF8350 Offset: 0x1AF8451 VA: 0x1AF8350
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x1AF83A0 Offset: 0x1AF84A1 VA: 0x1AF83A0
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x1AF83F0 Offset: 0x1AF84F1 VA: 0x1AF83F0
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x1AF8440 Offset: 0x1AF8541 VA: 0x1AF8440
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x1AF8490 Offset: 0x1AF8591 VA: 0x1AF8490
	public float get_gravityWeight() { }

	// RVA: 0x1AF84E0 Offset: 0x1AF85E1 VA: 0x1AF84E0
	public Vector3 get_bodyPosition() { }

	// RVA: 0x1AF86B0 Offset: 0x1AF87B1 VA: 0x1AF86B0
	public void set_bodyPosition(Vector3 value) { }

	[NativeMethodAttribute] // RVA: 0xEAEB0 Offset: 0xEAFB1 VA: 0xEAEB0
	// RVA: 0x1AF8650 Offset: 0x1AF8751 VA: 0x1AF8650
	internal Vector3 get_bodyPositionInternal() { }

	[NativeMethodAttribute] // RVA: 0xEAEF0 Offset: 0xEAFF1 VA: 0xEAEF0
	// RVA: 0x1AF8730 Offset: 0x1AF8831 VA: 0x1AF8730
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x1AF8830 Offset: 0x1AF8931 VA: 0x1AF8830
	public Quaternion get_bodyRotation() { }

	// RVA: 0x1AF88F0 Offset: 0x1AF89F1 VA: 0x1AF88F0
	public void set_bodyRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0xEAF30 Offset: 0xEB031 VA: 0xEAF30
	// RVA: 0x1AF8890 Offset: 0x1AF8991 VA: 0x1AF8890
	internal Quaternion get_bodyRotationInternal() { }

	[NativeMethodAttribute] // RVA: 0xEAF70 Offset: 0xEB071 VA: 0xEAF70
	// RVA: 0x1AF8970 Offset: 0x1AF8A71 VA: 0x1AF8970
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x1AF8A70 Offset: 0x1AF8B71 VA: 0x1AF8A70
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x1AF8AF0 Offset: 0x1AF8BF1 VA: 0x1AF8AF0
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x1AF8BC0 Offset: 0x1AF8CC1 VA: 0x1AF8BC0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1AF8C50 Offset: 0x1AF8D51 VA: 0x1AF8C50
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1AF8D20 Offset: 0x1AF8E21 VA: 0x1AF8D20
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x1AF8D90 Offset: 0x1AF8E91 VA: 0x1AF8D90
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x1AF8E60 Offset: 0x1AF8F61 VA: 0x1AF8E60
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x1AF8EF0 Offset: 0x1AF8FF1 VA: 0x1AF8EF0
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x1AF8FC0 Offset: 0x1AF90C1 VA: 0x1AF8FC0
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x1AF9020 Offset: 0x1AF9121 VA: 0x1AF9020
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x1AF9070 Offset: 0x1AF9171 VA: 0x1AF9070
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x1AF90E0 Offset: 0x1AF91E1 VA: 0x1AF90E0
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x1AF9140 Offset: 0x1AF9241 VA: 0x1AF9140
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x1AF91A0 Offset: 0x1AF92A1 VA: 0x1AF91A0
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x1AF91F0 Offset: 0x1AF92F1 VA: 0x1AF91F0
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x1AF9260 Offset: 0x1AF9361 VA: 0x1AF9260
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x1AF92C0 Offset: 0x1AF93C1 VA: 0x1AF92C0
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x1AF9340 Offset: 0x1AF9441 VA: 0x1AF9340
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x1AF9410 Offset: 0x1AF9511 VA: 0x1AF9410
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x1AF94A0 Offset: 0x1AF95A1 VA: 0x1AF94A0
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x1AF9570 Offset: 0x1AF9671 VA: 0x1AF9570
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x1AF95D0 Offset: 0x1AF96D1 VA: 0x1AF95D0
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x1AF9620 Offset: 0x1AF9721 VA: 0x1AF9620
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x1AF9690 Offset: 0x1AF9791 VA: 0x1AF9690
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x1AF96F0 Offset: 0x1AF97F1 VA: 0x1AF96F0
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xEAFB0 Offset: 0xEB0B1 VA: 0xEAFB0
	// RVA: 0x1AF9770 Offset: 0x1AF9871 VA: 0x1AF9770
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x1AF9820 Offset: 0x1AF9921 VA: 0x1AF9820
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x1AF9910 Offset: 0x1AF9A11 VA: 0x1AF9910
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x1AF9980 Offset: 0x1AF9A81 VA: 0x1AF9980
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x1AF9A00 Offset: 0x1AF9B01 VA: 0x1AF9A00
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x1AF9A80 Offset: 0x1AF9B81 VA: 0x1AF9A80
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xEAFF0 Offset: 0xEB0F1 VA: 0xEAFF0
	// RVA: 0x1AF9890 Offset: 0x1AF9991 VA: 0x1AF9890
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x1AF9B10 Offset: 0x1AF9C11 VA: 0x1AF9B10
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[NativeMethodAttribute] // RVA: 0xEB030 Offset: 0xEB131 VA: 0xEB030
	// RVA: 0x1AF9C20 Offset: 0x1AF9D21 VA: 0x1AF9C20
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x1AF9CF0 Offset: 0x1AF9DF1 VA: 0x1AF9CF0
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: -1 Offset: -1
	public T GetBehaviour<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265790 Offset: 0x2265891 VA: 0x2265790
	|-Animator.GetBehaviour<CharacterAnimationMonitor>
	|-Animator.GetBehaviour<GrappleFlungObserve>
	|-Animator.GetBehaviour<GrappleLiftObserve>
	|-Animator.GetBehaviour<GrapplePoundObserve>
	|-Animator.GetBehaviour<GrappleSlamObserve>
	|-Animator.GetBehaviour<GrappleSwingObserve>
	|-Animator.GetBehaviour<StepMotionObserve>
	|-Animator.GetBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F62D0 Offset: 0x34F63D1 VA: 0x34F62D0
	|-Animator.ConvertStateMachineBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetBehaviours<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F6400 Offset: 0x34F6501 VA: 0x34F6400
	|-Animator.GetBehaviours<BitMotion>
	|-Animator.GetBehaviours<CharaMotionBehaviour>
	|-Animator.GetBehaviours<CharacterMotionPersonal>
	|-Animator.GetBehaviours<CollapseLandingObserve>
	|-Animator.GetBehaviours<EquipHideObserve>
	|-Animator.GetBehaviours<EquipShowObserve>
	|-Animator.GetBehaviours<GrappleDirection>
	|-Animator.GetBehaviours<HandCuffsThrowObserve>
	|-Animator.GetBehaviours<MagicIdleObserve>
	|-Animator.GetBehaviours<MonsterAnimatorStateEvent>
	|-Animator.GetBehaviours<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xEB070 Offset: 0xEB171 VA: 0xEB070
	// RVA: 0x1AF9D40 Offset: 0x1AF9E41 VA: 0x1AF9D40
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x1AF9D90 Offset: 0x1AF9E91 VA: 0x1AF9D90
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEB0C0 Offset: 0xEB1C1 VA: 0xEB0C0
	// RVA: 0x1AF9E70 Offset: 0x1AF9F71 VA: 0x1AF9E70
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x1AF9EE0 Offset: 0x1AF9FE1 VA: 0x1AF9EE0
	public bool get_stabilizeFeet() { }

	// RVA: 0x1AF9F30 Offset: 0x1AFA031 VA: 0x1AF9F30
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x1AF9F80 Offset: 0x1AFA081 VA: 0x1AF9F80
	public int get_layerCount() { }

	// RVA: 0x1AF9FD0 Offset: 0x1AFA0D1 VA: 0x1AF9FD0
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x1AFA020 Offset: 0x1AFA121 VA: 0x1AFA020
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x1AFA070 Offset: 0x1AFA171 VA: 0x1AFA070
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x1AFA0C0 Offset: 0x1AFA1C1 VA: 0x1AFA0C0
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x1AFA120 Offset: 0x1AFA221 VA: 0x1AFA120
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x1AFA190 Offset: 0x1AFA291 VA: 0x1AFA190
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x1AFA220 Offset: 0x1AFA321 VA: 0x1AFA220
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x1AFA2B0 Offset: 0x1AFA3B1 VA: 0x1AFA2B0
	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	// RVA: 0x1AFA310 Offset: 0x1AFA411 VA: 0x1AFA310
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x1AFA390 Offset: 0x1AFA491 VA: 0x1AFA390
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x1AFA3F0 Offset: 0x1AFA4F1 VA: 0x1AFA3F0
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x1AFA450 Offset: 0x1AFA551 VA: 0x1AFA450
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEB110 Offset: 0xEB211 VA: 0xEB110
	// RVA: 0x1AFA4B0 Offset: 0x1AFA5B1 VA: 0x1AFA4B0
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEB160 Offset: 0xEB261 VA: 0xEB160
	// RVA: 0x1AFA500 Offset: 0x1AFA601 VA: 0x1AFA500
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x1AFA550 Offset: 0x1AFA651 VA: 0x1AFA550
	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunctionAttribute] // RVA: 0xEB1B0 Offset: 0xEB2B1 VA: 0xEB1B0
	// RVA: 0x1AFA610 Offset: 0x1AFA711 VA: 0x1AFA610
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x1AFA680 Offset: 0x1AFA781 VA: 0x1AFA680
	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	// RVA: 0x1AFA740 Offset: 0x1AFA841 VA: 0x1AFA740
	public bool IsInTransition(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEB200 Offset: 0xEB301 VA: 0xEB200
	// RVA: 0x1AFA790 Offset: 0x1AFA891 VA: 0x1AFA790
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x1AFA7E0 Offset: 0x1AFA8E1 VA: 0x1AFA7E0
	public int get_parameterCount() { }

	// RVA: 0x1AFA830 Offset: 0x1AFA931 VA: 0x1AFA830
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x1AFA9B0 Offset: 0x1AFAAB1 VA: 0x1AFA9B0
	public float get_feetPivotActive() { }

	// RVA: 0x1AFAA00 Offset: 0x1AFAB01 VA: 0x1AFAA00
	public void set_feetPivotActive(float value) { }

	// RVA: 0x1AFAA50 Offset: 0x1AFAB51 VA: 0x1AFAA50
	public float get_pivotWeight() { }

	// RVA: 0x1AFAAA0 Offset: 0x1AFABA1 VA: 0x1AFAAA0
	public Vector3 get_pivotPosition() { }

	// RVA: 0x1AFAB50 Offset: 0x1AFAC51 VA: 0x1AFAB50
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1AFACA0 Offset: 0x1AFADA1 VA: 0x1AFACA0
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x1AFAD40 Offset: 0x1AFAE41 VA: 0x1AFAD40
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x1AFADF0 Offset: 0x1AFAEF1 VA: 0x1AFADF0
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1AFAEA0 Offset: 0x1AFAFA1 VA: 0x1AFAEA0
	public void InterruptMatchTarget() { }

	// RVA: 0x1AFAEF0 Offset: 0x1AFAFF1 VA: 0x1AFAEF0
	public void InterruptMatchTarget(bool completeMatch) { }

	[NativeMethodAttribute] // RVA: 0xEB250 Offset: 0xEB351 VA: 0xEB250
	// RVA: 0x1AFAF40 Offset: 0x1AFB041 VA: 0x1AFAF40
	public bool get_isMatchingTarget() { }

	// RVA: 0x1AFAF90 Offset: 0x1AFB091 VA: 0x1AFAF90
	public float get_speed() { }

	// RVA: 0x1AFAFE0 Offset: 0x1AFB0E1 VA: 0x1AFAFE0
	public void set_speed(float value) { }

	[ObsoleteAttribute] // RVA: 0xEB290 Offset: 0xEB391 VA: 0xEB290
	// RVA: 0x1AFB030 Offset: 0x1AFB131 VA: 0x1AFB030
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x1AFB100 Offset: 0x1AFB201 VA: 0x1AFB100
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x1AFB270 Offset: 0x1AFB371 VA: 0x1AFB270
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x1AFB310 Offset: 0x1AFB411 VA: 0x1AFB310
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x1AFB3B0 Offset: 0x1AFB4B1 VA: 0x1AFB3B0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1AFB460 Offset: 0x1AFB561 VA: 0x1AFB460
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x1AFB4E0 Offset: 0x1AFB5E1 VA: 0x1AFB4E0
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x1AFB550 Offset: 0x1AFB651 VA: 0x1AFB550
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	[FreeFunctionAttribute] // RVA: 0xEB2D0 Offset: 0xEB3D1 VA: 0xEB2D0
	// RVA: 0x1AFB1F0 Offset: 0x1AFB2F1 VA: 0x1AFB1F0
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xEB320 Offset: 0xEB421 VA: 0xEB320
	// RVA: 0x1AFB5C0 Offset: 0x1AFB6C1 VA: 0x1AFB5C0
	public void WriteDefaultValues() { }

	// RVA: 0x1AFB610 Offset: 0x1AFB711 VA: 0x1AFB610
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x1AFB760 Offset: 0x1AFB861 VA: 0x1AFB760
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x1AFB800 Offset: 0x1AFB901 VA: 0x1AFB800
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x1AFB6B0 Offset: 0x1AFB7B1 VA: 0x1AFB6B0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xEB370 Offset: 0xEB471 VA: 0xEB370
	// RVA: 0x1AFB8A0 Offset: 0x1AFB9A1 VA: 0x1AFB8A0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1AFB920 Offset: 0x1AFBA21 VA: 0x1AFB920
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x1AFB9A0 Offset: 0x1AFBAA1 VA: 0x1AFB9A0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x1AFBA20 Offset: 0x1AFBB21 VA: 0x1AFBA20
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x1AFBA90 Offset: 0x1AFBB91 VA: 0x1AFBA90
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x1AFBBC0 Offset: 0x1AFBCC1 VA: 0x1AFBBC0
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x1AFBB20 Offset: 0x1AFBC21 VA: 0x1AFBB20
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	[FreeFunctionAttribute] // RVA: 0xEB3C0 Offset: 0xEB4C1 VA: 0xEB3C0
	// RVA: 0x1AFBC50 Offset: 0x1AFBD51 VA: 0x1AFBC50
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x1AFBCC0 Offset: 0x1AFBDC1 VA: 0x1AFBCC0
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x1AFBD20 Offset: 0x1AFBE21 VA: 0x1AFBD20
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x1AFBD80 Offset: 0x1AFBE81 VA: 0x1AFBD80
	public void Play(string stateName, int layer) { }

	// RVA: 0x1AFBEB0 Offset: 0x1AFBFB1 VA: 0x1AFBEB0
	public void Play(string stateName) { }

	// RVA: 0x1AFBE10 Offset: 0x1AFBF11 VA: 0x1AFBE10
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xEB410 Offset: 0xEB511 VA: 0xEB410
	// RVA: 0x1AFB090 Offset: 0x1AFB191 VA: 0x1AFB090
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x1AFBF40 Offset: 0x1AFC041 VA: 0x1AFBF40
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x1AFBFA0 Offset: 0x1AFC0A1 VA: 0x1AFBFA0
	public void Play(int stateNameHash) { }

	// RVA: 0x1AFC000 Offset: 0x1AFC101 VA: 0x1AFC000
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x1AFC060 Offset: 0x1AFC161 VA: 0x1AFC060
	public Vector3 get_targetPosition() { }

	// RVA: 0x1AFC110 Offset: 0x1AFC211 VA: 0x1AFC110
	public Quaternion get_targetRotation() { }

	[EditorBrowsableAttribute] // RVA: 0xEB460 Offset: 0xEB561 VA: 0xEB460
	[ObsoleteAttribute] // RVA: 0xEB460 Offset: 0xEB561 VA: 0xEB460
	// RVA: 0x1AFC1C0 Offset: 0x1AFC2C1 VA: 0x1AFC1C0
	public bool IsControlled(Transform transform) { }

	// RVA: 0x1AFC1D0 Offset: 0x1AFC2D1 VA: 0x1AFC1D0
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x1AFC220 Offset: 0x1AFC321 VA: 0x1AFC220
	internal Transform get_avatarRoot() { }

	// RVA: 0x1AFC270 Offset: 0x1AFC371 VA: 0x1AFC270
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethodAttribute] // RVA: 0xEB4C0 Offset: 0xEB5C1 VA: 0xEB4C0
	// RVA: 0x1AFC390 Offset: 0x1AFC491 VA: 0x1AFC390
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x1AFC3E0 Offset: 0x1AFC4E1 VA: 0x1AFC3E0
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x1AFC430 Offset: 0x1AFC531 VA: 0x1AFC430
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x1AFC480 Offset: 0x1AFC581 VA: 0x1AFC480
	public void StartPlayback() { }

	// RVA: 0x1AFC4D0 Offset: 0x1AFC5D1 VA: 0x1AFC4D0
	public void StopPlayback() { }

	// RVA: 0x1AFC520 Offset: 0x1AFC621 VA: 0x1AFC520
	public float get_playbackTime() { }

	// RVA: 0x1AFC570 Offset: 0x1AFC671 VA: 0x1AFC570
	public void set_playbackTime(float value) { }

	// RVA: 0x1AFC5C0 Offset: 0x1AFC6C1 VA: 0x1AFC5C0
	public void StartRecording(int frameCount) { }

	// RVA: 0x1AFC610 Offset: 0x1AFC711 VA: 0x1AFC610
	public void StopRecording() { }

	// RVA: 0x1AFC660 Offset: 0x1AFC761 VA: 0x1AFC660
	public float get_recorderStartTime() { }

	// RVA: 0x1AFC700 Offset: 0x1AFC801 VA: 0x1AFC700
	public void set_recorderStartTime(float value) { }

	// RVA: 0x1AFC6B0 Offset: 0x1AFC7B1 VA: 0x1AFC6B0
	private float GetRecorderStartTime() { }

	// RVA: 0x1AFC710 Offset: 0x1AFC811 VA: 0x1AFC710
	public float get_recorderStopTime() { }

	// RVA: 0x1AFC7B0 Offset: 0x1AFC8B1 VA: 0x1AFC7B0
	public void set_recorderStopTime(float value) { }

	// RVA: 0x1AFC760 Offset: 0x1AFC861 VA: 0x1AFC760
	private float GetRecorderStopTime() { }

	// RVA: 0x1AFC7C0 Offset: 0x1AFC8C1 VA: 0x1AFC7C0
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x1AFC810 Offset: 0x1AFC911 VA: 0x1AFC810
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x1AFC860 Offset: 0x1AFC961 VA: 0x1AFC860
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xEB500 Offset: 0xEB601 VA: 0xEB500
	// RVA: 0x1AFC8B0 Offset: 0x1AFC9B1 VA: 0x1AFC8B0
	public bool get_hasBoundPlayables() { }

	// RVA: 0x1AFC900 Offset: 0x1AFCA01 VA: 0x1AFC900
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x1AFC950 Offset: 0x1AFCA51 VA: 0x1AFC950
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xEB540 Offset: 0xEB641 VA: 0xEB540
	// RVA: 0x1AFB1A0 Offset: 0x1AFB2A1 VA: 0x1AFB1A0
	public static int StringToHash(string name) { }

	// RVA: 0x1AFC9B0 Offset: 0x1AFCAB1 VA: 0x1AFC9B0
	public Avatar get_avatar() { }

	// RVA: 0x1AFCA00 Offset: 0x1AFCB01 VA: 0x1AFCA00
	public void set_avatar(Avatar value) { }

	// RVA: 0x1AFCA50 Offset: 0x1AFCB51 VA: 0x1AFCA50
	internal string GetStats() { }

	// RVA: 0x1AFCAA0 Offset: 0x1AFCBA1 VA: 0x1AFCAA0
	public PlayableGraph get_playableGraph() { }

	[FreeFunctionAttribute] // RVA: 0xEB590 Offset: 0xEB691 VA: 0xEB590
	// RVA: 0x1AFCB00 Offset: 0x1AFCC01 VA: 0x1AFCB00
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	// RVA: 0x1AF8550 Offset: 0x1AF8651 VA: 0x1AF8550
	private void CheckIfInIKPass() { }

	// RVA: 0x1AFCBA0 Offset: 0x1AFCCA1 VA: 0x1AFCBA0
	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xEB5E0 Offset: 0xEB6E1 VA: 0xEB5E0
	// RVA: 0x1AF6F30 Offset: 0x1AF7031 VA: 0x1AF6F30
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xEB630 Offset: 0xEB731 VA: 0xEB630
	// RVA: 0x1AF70F0 Offset: 0x1AF71F1 VA: 0x1AF70F0
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xEB680 Offset: 0xEB781 VA: 0xEB680
	// RVA: 0x1AF6DE0 Offset: 0x1AF6EE1 VA: 0x1AF6DE0
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xEB6D0 Offset: 0xEB7D1 VA: 0xEB6D0
	// RVA: 0x1AF6E80 Offset: 0x1AF6F81 VA: 0x1AF6E80
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xEB720 Offset: 0xEB821 VA: 0xEB720
	// RVA: 0x1AF73F0 Offset: 0x1AF74F1 VA: 0x1AF73F0
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xEB770 Offset: 0xEB871 VA: 0xEB770
	// RVA: 0x1AF74B0 Offset: 0x1AF75B1 VA: 0x1AF74B0
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xEB7C0 Offset: 0xEB8C1 VA: 0xEB7C0
	// RVA: 0x1AF72A0 Offset: 0x1AF73A1 VA: 0x1AF72A0
	private bool GetBoolString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xEB810 Offset: 0xEB911 VA: 0xEB810
	// RVA: 0x1AF7340 Offset: 0x1AF7441 VA: 0x1AF7340
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xEB860 Offset: 0xEB961 VA: 0xEB860
	// RVA: 0x1AF76B0 Offset: 0x1AF77B1 VA: 0x1AF76B0
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xEB8B0 Offset: 0xEB9B1 VA: 0xEB8B0
	// RVA: 0x1AF7770 Offset: 0x1AF7871 VA: 0x1AF7770
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xEB900 Offset: 0xEBA01 VA: 0xEB900
	// RVA: 0x1AF7560 Offset: 0x1AF7661 VA: 0x1AF7560
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xEB950 Offset: 0xEBA51 VA: 0xEB950
	// RVA: 0x1AF7600 Offset: 0x1AF7701 VA: 0x1AF7600
	private int GetIntegerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xEB9A0 Offset: 0xEBAA1 VA: 0xEB9A0
	// RVA: 0x1AF7820 Offset: 0x1AF7921 VA: 0x1AF7820
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xEB9F0 Offset: 0xEBAF1 VA: 0xEB9F0
	// RVA: 0x1AF78C0 Offset: 0x1AF79C1 VA: 0x1AF78C0
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xEBA40 Offset: 0xEBB41 VA: 0xEBA40
	// RVA: 0x1AF7960 Offset: 0x1AF7A61 VA: 0x1AF7960
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xEBA90 Offset: 0xEBB91 VA: 0xEBA90
	// RVA: 0x1AF7A00 Offset: 0x1AF7B01 VA: 0x1AF7A00
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xEBAE0 Offset: 0xEBBE1 VA: 0xEBAE0
	// RVA: 0x1AF7AA0 Offset: 0x1AF7BA1 VA: 0x1AF7AA0
	private bool IsParameterControlledByCurveString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xEBB30 Offset: 0xEBC31 VA: 0xEBB30
	// RVA: 0x1AF7B40 Offset: 0x1AF7C41 VA: 0x1AF7B40
	private bool IsParameterControlledByCurveID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xEBB80 Offset: 0xEBC81 VA: 0xEBB80
	// RVA: 0x1AF7010 Offset: 0x1AF7111 VA: 0x1AF7010
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xEBBD0 Offset: 0xEBCD1 VA: 0xEBBD0
	// RVA: 0x1AF71D0 Offset: 0x1AF72D1 VA: 0x1AF71D0
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x1AFCBF0 Offset: 0x1AFCCF1 VA: 0x1AFCBF0
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x1AFCC40 Offset: 0x1AFCD41 VA: 0x1AFCC40
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x1AFCC90 Offset: 0x1AFCD91 VA: 0x1AFCC90
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x1AFCCE0 Offset: 0x1AFCDE1 VA: 0x1AFCCE0
	public float get_rightFeetBottomHeight() { }

	[NativeMethodAttribute] // RVA: 0xEBC20 Offset: 0xEBD21 VA: 0xEBC20
	// RVA: 0x1AFCD30 Offset: 0x1AFCE31 VA: 0x1AFCD30
	internal bool get_supportsOnAnimatorMove() { }

	[NativeConditionalAttribute] // RVA: 0xEBC60 Offset: 0xEBD61 VA: 0xEBC60
	// RVA: 0x1AFCD80 Offset: 0x1AFCE81 VA: 0x1AFCD80
	internal void OnUpdateModeChanged() { }

	[NativeConditionalAttribute] // RVA: 0xEBCA0 Offset: 0xEBDA1 VA: 0xEBCA0
	// RVA: 0x1AFCDD0 Offset: 0x1AFCED1 VA: 0x1AFCDD0
	internal void OnCullingModeChanged() { }

	[NativeConditionalAttribute] // RVA: 0xEBCE0 Offset: 0xEBDE1 VA: 0xEBCE0
	// RVA: 0x1AFCE20 Offset: 0x1AFCF21 VA: 0x1AFCE20
	internal void WriteDefaultPose() { }

	[NativeMethodAttribute] // RVA: 0xEBD20 Offset: 0xEBE21 VA: 0xEBD20
	// RVA: 0x1AFCE70 Offset: 0x1AFCF71 VA: 0x1AFCE70
	public void Update(float deltaTime) { }

	// RVA: 0x1AFCEC0 Offset: 0x1AFCFC1 VA: 0x1AFCEC0
	public void Rebind() { }

	// RVA: 0x1AFCF10 Offset: 0x1AFD011 VA: 0x1AFCF10
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x1AFCF60 Offset: 0x1AFD061 VA: 0x1AFCF60
	public void ApplyBuiltinRootMotion() { }

	[NativeConditionalAttribute] // RVA: 0xEBD60 Offset: 0xEBE61 VA: 0xEBD60
	// RVA: 0x1AFCFB0 Offset: 0x1AFD0B1 VA: 0x1AFCFB0
	internal void EvaluateController() { }

	// RVA: 0x1AFD000 Offset: 0x1AFD101 VA: 0x1AFD000
	private void EvaluateController(float deltaTime) { }

	[NativeConditionalAttribute] // RVA: 0xEBDA0 Offset: 0xEBEA1 VA: 0xEBDA0
	// RVA: 0x1AFD050 Offset: 0x1AFD151 VA: 0x1AFD050
	internal string GetCurrentStateName(int layerIndex) { }

	[NativeConditionalAttribute] // RVA: 0xEBDE0 Offset: 0xEBEE1 VA: 0xEBDE0
	// RVA: 0x1AFD110 Offset: 0x1AFD211 VA: 0x1AFD110
	internal string GetNextStateName(int layerIndex) { }

	[NativeConditionalAttribute] // RVA: 0xEBE20 Offset: 0xEBF21 VA: 0xEBE20
	// RVA: 0x1AFD0B0 Offset: 0x1AFD1B1 VA: 0x1AFD0B0
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x1AFD170 Offset: 0x1AFD271 VA: 0x1AFD170
	internal string ResolveHash(int hash) { }

	// RVA: 0x1AFCB50 Offset: 0x1AFCC51 VA: 0x1AFCB50
	public bool get_logWarnings() { }

	// RVA: 0x1AFD1C0 Offset: 0x1AFD2C1 VA: 0x1AFD1C0
	public void set_logWarnings(bool value) { }

	// RVA: 0x1AFD210 Offset: 0x1AFD311 VA: 0x1AFD210
	public bool get_fireEvents() { }

	// RVA: 0x1AFD260 Offset: 0x1AFD361 VA: 0x1AFD260
	public void set_fireEvents(bool value) { }

	// RVA: 0x1AFD2B0 Offset: 0x1AFD3B1 VA: 0x1AFD2B0
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x1AFD300 Offset: 0x1AFD401 VA: 0x1AFD300
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	[ObsoleteAttribute] // RVA: 0xEBE60 Offset: 0xEBF61 VA: 0xEBE60
	// RVA: 0x1AFD350 Offset: 0x1AFD451 VA: 0x1AFD350
	public Vector3 GetVector(string name) { }

	[ObsoleteAttribute] // RVA: 0xEBEA0 Offset: 0xEBFA1 VA: 0xEBEA0
	// RVA: 0x1AFD3C0 Offset: 0x1AFD4C1 VA: 0x1AFD3C0
	public Vector3 GetVector(int id) { }

	[ObsoleteAttribute] // RVA: 0xEBEE0 Offset: 0xEBFE1 VA: 0xEBEE0
	// RVA: 0x1AFD430 Offset: 0x1AFD531 VA: 0x1AFD430
	public void SetVector(string name, Vector3 value) { }

	[ObsoleteAttribute] // RVA: 0xEBF20 Offset: 0xEC021 VA: 0xEBF20
	// RVA: 0x1AFD440 Offset: 0x1AFD541 VA: 0x1AFD440
	public void SetVector(int id, Vector3 value) { }

	[ObsoleteAttribute] // RVA: 0xEBF60 Offset: 0xEC061 VA: 0xEBF60
	// RVA: 0x1AFD450 Offset: 0x1AFD551 VA: 0x1AFD450
	public Quaternion GetQuaternion(string name) { }

	[ObsoleteAttribute] // RVA: 0xEBFA0 Offset: 0xEC0A1 VA: 0xEBFA0
	// RVA: 0x1AFD4C0 Offset: 0x1AFD5C1 VA: 0x1AFD4C0
	public Quaternion GetQuaternion(int id) { }

	[ObsoleteAttribute] // RVA: 0xEBFE0 Offset: 0xEC0E1 VA: 0xEBFE0
	// RVA: 0x1AFD530 Offset: 0x1AFD631 VA: 0x1AFD530
	public void SetQuaternion(string name, Quaternion value) { }

	[ObsoleteAttribute] // RVA: 0xEC020 Offset: 0xEC121 VA: 0xEC020
	// RVA: 0x1AFD540 Offset: 0x1AFD641 VA: 0x1AFD540
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x1AFD550 Offset: 0x1AFD651 VA: 0x1AFD550
	public void .ctor() { }

	// RVA: 0x1AF7BF0 Offset: 0x1AF7CF1 VA: 0x1AF7BF0
	private void get_deltaPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1AF7CA0 Offset: 0x1AF7DA1 VA: 0x1AF7CA0
	private void get_deltaRotation_Injected(out Quaternion ret) { }

	// RVA: 0x1AF7D50 Offset: 0x1AF7E51 VA: 0x1AF7D50
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x1AF7E00 Offset: 0x1AF7F01 VA: 0x1AF7E00
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x1AF7EB0 Offset: 0x1AF7FB1 VA: 0x1AF7EB0
	private void get_rootPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1AF7F60 Offset: 0x1AF8061 VA: 0x1AF7F60
	private void set_rootPosition_Injected(ref Vector3 value) { }

	// RVA: 0x1AF8010 Offset: 0x1AF8111 VA: 0x1AF8010
	private void get_rootRotation_Injected(out Quaternion ret) { }

	// RVA: 0x1AF80C0 Offset: 0x1AF81C1 VA: 0x1AF80C0
	private void set_rootRotation_Injected(ref Quaternion value) { }

	// RVA: 0x1AF8790 Offset: 0x1AF8891 VA: 0x1AF8790
	private void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	// RVA: 0x1AF87E0 Offset: 0x1AF88E1 VA: 0x1AF87E0
	private void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	// RVA: 0x1AF89D0 Offset: 0x1AF8AD1 VA: 0x1AF89D0
	private void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	// RVA: 0x1AF8A20 Offset: 0x1AF8B21 VA: 0x1AF8A20
	private void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	// RVA: 0x1AF8B60 Offset: 0x1AF8C61 VA: 0x1AF8B60
	private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	// RVA: 0x1AF8CC0 Offset: 0x1AF8DC1 VA: 0x1AF8CC0
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x1AF8E00 Offset: 0x1AF8F01 VA: 0x1AF8E00
	private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	// RVA: 0x1AF8F60 Offset: 0x1AF9061 VA: 0x1AF8F60
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x1AF93B0 Offset: 0x1AF94B1 VA: 0x1AF93B0
	private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	// RVA: 0x1AF9510 Offset: 0x1AF9611 VA: 0x1AF9510
	private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	// RVA: 0x1AF97D0 Offset: 0x1AF98D1 VA: 0x1AF97D0
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	// RVA: 0x1AF9C90 Offset: 0x1AF9D91 VA: 0x1AF9C90
	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) { }

	// RVA: 0x1AFAB00 Offset: 0x1AFAC01 VA: 0x1AFAB00
	private void get_pivotPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1AFAC00 Offset: 0x1AFAD01 VA: 0x1AFAC00
	private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1AFC0C0 Offset: 0x1AFC1C1 VA: 0x1AFC0C0
	private void get_targetPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1AFC170 Offset: 0x1AFC271 VA: 0x1AFC170
	private void get_targetRotation_Injected(out Quaternion ret) { }
}

