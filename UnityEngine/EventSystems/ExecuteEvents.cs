public static class ExecuteEvents // TypeDefIndex: 4075
{
	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x80
	private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265D30 Offset: 0x2265E31 VA: 0x2265D30
	|-ExecuteEvents.ValidateEventData<object>
	|-ExecuteEvents.ValidateEventData<AxisEventData>
	|-ExecuteEvents.ValidateEventData<PointerEventData>
	*/

	// RVA: 0x163AC90 Offset: 0x163AD91 VA: 0x163AC90
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x163AD90 Offset: 0x163AE91 VA: 0x163AD90
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x163AE90 Offset: 0x163AF91 VA: 0x163AE90
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x163AF90 Offset: 0x163B091 VA: 0x163AF90
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B090 Offset: 0x163B191 VA: 0x163B090
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B190 Offset: 0x163B291 VA: 0x163B190
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B290 Offset: 0x163B391 VA: 0x163B290
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B390 Offset: 0x163B491 VA: 0x163B390
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B490 Offset: 0x163B591 VA: 0x163B490
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B590 Offset: 0x163B691 VA: 0x163B590
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B690 Offset: 0x163B791 VA: 0x163B690
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B790 Offset: 0x163B891 VA: 0x163B790
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B850 Offset: 0x163B951 VA: 0x163B850
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B910 Offset: 0x163BA11 VA: 0x163B910
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x163B9D0 Offset: 0x163BAD1 VA: 0x163B9D0
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x163BAD0 Offset: 0x163BBD1 VA: 0x163BAD0
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x163BB90 Offset: 0x163BC91 VA: 0x163BB90
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x163BC50 Offset: 0x163BD51 VA: 0x163BC50
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x163BCC0 Offset: 0x163BDC1 VA: 0x163BCC0
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x163BD30 Offset: 0x163BE31 VA: 0x163BD30
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x163BDA0 Offset: 0x163BEA1 VA: 0x163BDA0
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x163BE10 Offset: 0x163BF11 VA: 0x163BE10
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x163BE80 Offset: 0x163BF81 VA: 0x163BE80
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x163BEF0 Offset: 0x163BFF1 VA: 0x163BEF0
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x163BF60 Offset: 0x163C061 VA: 0x163BF60
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x163BFD0 Offset: 0x163C0D1 VA: 0x163BFD0
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x163C040 Offset: 0x163C141 VA: 0x163C040
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x163C0B0 Offset: 0x163C1B1 VA: 0x163C0B0
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x163C120 Offset: 0x163C221 VA: 0x163C120
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x163C190 Offset: 0x163C291 VA: 0x163C190
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x163C200 Offset: 0x163C301 VA: 0x163C200
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x163C270 Offset: 0x163C371 VA: 0x163C270
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x163C2E0 Offset: 0x163C3E1 VA: 0x163C2E0
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x163C350 Offset: 0x163C451 VA: 0x163C350
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x163C3C0 Offset: 0x163C4C1 VA: 0x163C3C0
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D0A00 Offset: 0x22D0B01 VA: 0x22D0A00
	|-ExecuteEvents.Execute<object>
	|-ExecuteEvents.Execute<IBeginDragHandler>
	|-ExecuteEvents.Execute<ICancelHandler>
	|-ExecuteEvents.Execute<IDeselectHandler>
	|-ExecuteEvents.Execute<IDragHandler>
	|-ExecuteEvents.Execute<IEndDragHandler>
	|-ExecuteEvents.Execute<IInitializePotentialDragHandler>
	|-ExecuteEvents.Execute<IMoveHandler>
	|-ExecuteEvents.Execute<IPointerClickHandler>
	|-ExecuteEvents.Execute<IPointerEnterHandler>
	|-ExecuteEvents.Execute<IPointerExitHandler>
	|-ExecuteEvents.Execute<IPointerUpHandler>
	|-ExecuteEvents.Execute<ISelectHandler>
	|-ExecuteEvents.Execute<ISubmitHandler>
	|-ExecuteEvents.Execute<IUpdateSelectedHandler>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8870 Offset: 0x34F8971 VA: 0x34F8870
	|-ExecuteEvents.ExecuteHierarchy<object>
	|-ExecuteEvents.ExecuteHierarchy<IDropHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>
	|-ExecuteEvents.ExecuteHierarchy<IScrollHandler>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D0E00 Offset: 0x22D0F01 VA: 0x22D0E00
	|-ExecuteEvents.ShouldSendToComponent<object>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E3B50 Offset: 0x23E3C51 VA: 0x23E3B50
	|-ExecuteEvents.GetEventList<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D0920 Offset: 0x22D0A21 VA: 0x22D0920
	|-ExecuteEvents.CanHandleEvent<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F89E0 Offset: 0x34F8AE1 VA: 0x34F89E0
	|-ExecuteEvents.GetEventHandler<object>
	|-ExecuteEvents.GetEventHandler<IBeginDragHandler>
	|-ExecuteEvents.GetEventHandler<IDragHandler>
	|-ExecuteEvents.GetEventHandler<IPointerClickHandler>
	|-ExecuteEvents.GetEventHandler<IScrollHandler>
	|-ExecuteEvents.GetEventHandler<ISelectHandler>
	*/

	// RVA: 0x163C580 Offset: 0x163C681 VA: 0x163C580
	private static void .cctor() { }
}

