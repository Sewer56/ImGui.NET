using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igActivateItem(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAlignTextToFramePadding();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildStr(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildEx(byte* name, uint id, Vector2 size_arg, byte border, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginColumns(byte* str_id, int count, ImGuiColumnsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTarget();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTargetCustom(ImRect bb, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginGroup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMainMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenu(byte* label, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextItem(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextVoid(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextWindow(byte* str_id, ImGuiMouseButton mouse_button, byte also_over_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginTooltipEx(ImGuiWindowFlags extra_flags, ImGuiTooltipFlags tooltip_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBack(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayFront(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToFocusFront(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBullet();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBulletText(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButton(byte* label, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcItemWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcWindowExpectedSize(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCaptureKeyboardFromApp(byte want_capture_keyboard_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCaptureMouseFromApp(byte want_capture_mouse_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckbox(byte* label, byte* v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags(byte* label, uint* flags, uint flags_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearActiveID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearDragDrop();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCloseButton(uint id, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCloseCurrentPopup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapseButton(uint id, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeaderTreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeaderBoolPtr(byte* label, byte* p_open, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColumns(int count, byte* id, byte border);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igComboStr_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igComboStr(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igCreateNewWindowSettings(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeApplyOpFromText(byte* buf, byte* initial_value_buf, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugDrawItemRect(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugStartItemPicker();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, float power, ImGuiDragFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDummy(Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEnd();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChild();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChildFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndColumns();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndCombo();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropSource();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropTarget();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndGroup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMainMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenu();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndPopup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopupEx(Vector2* pOut, Vector2 ref_pos, Vector2 size, ImGuiDir* last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindOrCreateWindowSettings(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igFindRenderedTextEnd(byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByName(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindWindowSettings(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igFocusableItemRegister(ImGuiWindow* window, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusableItemUnregister(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusWindow(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetActiveID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawList();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetClipboardText();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32Col(ImGuiCol idx, float alpha_mul);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32Vec4(Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32U32(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnIndex();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnNormFromOffset(ImGuiColumns* columns, float offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffset(int column_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffsetFromNorm(ImGuiColumns* columns, float offset_norm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnsCount();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColumnsID(byte* str_id, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnWidth(int column_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionAvail(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMax(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMaxAbs(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetCurrentContext();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindow();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindowRead();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosX();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosY();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorScreenPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorStartPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetDefaultFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igGetDragDropPayload();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* igGetDrawData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetDrawListSharedData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusScopeID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFontSize();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetFontTexUvWhitePixel(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawListNil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawListWindowPtr(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetFrameCount();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeightWithSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetHoveredID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDStr(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDStrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDPtr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* igGetIO();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetItemID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMax(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMin(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectSize(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemStatusFlags igGetItemStatusFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyIndex(ImGuiKey imgui_key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyPressedAmount(int key_index, float repeat_delay, float rate);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMouseCursor igGetMouseCursor();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetNavInputAmount(ImGuiNavInput n, ImGuiInputReadMode mode);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetNavInputAmount2d(Vector2* pOut, ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor, float fast_factor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxX();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxY();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollX();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollY();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStorage* igGetStateStorage();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* igGetStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetStyleColorName(ImGuiCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeightWithSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igGetTime();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostPopupModal();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTreeNodeToLabelSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetVersion();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMax(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMin(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowContentRegionWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetWindowDrawList();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeID(ImGuiWindow* window, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowSize(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankA(byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankW(uint c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImDot(Vector2 a, Vector2 b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFileClose(ImFileHandle file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt64 igImFileGetSize(ImFileHandle file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFileHandle igImFileOpen(byte* filename, byte* mode);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt64 igImFileRead(void* data, UInt64 size, UInt64 count, ImFileHandle file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt64 igImFileWrite(void* data, UInt64 size, UInt64 count, ImFileHandle file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImFloorFloat(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFloorVec2(Vector2* pOut, Vector2 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildFinish(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRegisterDefaultCustomRects(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFontAtlasBuildWithStbTruetype(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFormatString(byte* buf, uint buf_size, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDir igImGetDirQuadrantFromDelta(float dx, float dy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashData(void* data, uint data_size, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashStr(byte* data, uint data_size, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImInvLength(Vector2 lhs, float fail_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwo(int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqrVec2(Vector2 lhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqrVec4(Vector4 lhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerpVec2Float(Vector2* pOut, Vector2 a, Vector2 b, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerpVec2Vec2(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerpVec4(Vector4* pOut, Vector4 a, Vector4 b, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLinearSweep(float current, float target, float speed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImModPositive(int a, int b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindEnd(byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindStart(byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImParseFormatPrecision(byte* format, int default_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImPowFloat(float x, float y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImPowdouble(double x, double y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSaturate(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* igImStrbolW(ushort* buf_mid_line, ushort* buf_begin);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdup(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdupcpy(byte* dst, uint* p_dst_size, byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStreolRange(byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStricmp(byte* str1, byte* str2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrlenW(ushort* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrncpy(byte* dst, byte* src, uint count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrnicmp(byte* str1, byte* str2, uint count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrSkipBlank(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrTrimBlanks(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrFromUtf8(ushort* buf, int buf_size, byte* in_text, byte* in_text_end, byte** in_remaining);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrToUtf8(byte* buf, int buf_size, ushort* in_text, ushort* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImUpperPowerOfTwo(int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igIndent(float indent_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInitialize(IntPtr context);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInvisibleButton(byte* str_id, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavDir(ImGuiDir dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavInput(ImGuiNavInput input);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemActive();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemFocused();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemHovered();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyMouseDown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsClippedEx(ImRect bb, uint id, byte clip_even_when_logged);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsDragDropPayloadBeingAccepted();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActivated();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActive();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemClicked(ImGuiMouseButton mouse_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivated();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivatedAfterEdit();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemEdited();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemFocused();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledOpen();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledSelection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemVisible();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyDown(int user_key_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressed(int user_key_index, byte repeat);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressedMap(ImGuiKey key, byte repeat);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyReleased(int user_key_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseClicked(ImGuiMouseButton button, byte repeat);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDoubleClicked(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDown(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMousePosValid(Vector2* mouse_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleased(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNavInputDown(ImGuiNavInput n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNavInputTest(ImGuiNavInput n, ImGuiInputReadMode rm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpenStr(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpenID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisibleNil(Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisibleVec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAppearing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowCollapsed();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowNavFocusable(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemAdd(ImRect bb, uint id, ImRect* nav_bb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemHoverable(ImRect bb, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSizeVec2(Vector2 size, float text_baseline_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSizeRect(ImRect bb, float text_baseline_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igKeepAliveID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLabelText(byte* label, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igListBoxStr_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igListBoxFooter();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igListBoxHeaderVec2(byte* label, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igListBoxHeaderInt(byte* label, int items_count, int height_in_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogBegin(ImGuiLogType type, int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogButtons();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogFinish();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogText(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToBuffer(int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToClipboard(int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToFile(int auto_open_depth, byte* filename);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToTTY(int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirtyNil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirtyWindowPtr(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkItemEdited(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igMemAlloc(uint size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMemFree(void* ptr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemBool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemBoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitWindow(ImGuiWindow* window, byte force_reinit);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igNavMoveRequestButNoResultYet();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestCancel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImRect bb_rel, ImGuiNavMoveFlags move_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewLine();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNextColumn();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopup(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupEx(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igOpenPopupOnItemClick(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotHistogramFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotLinesFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopAllowKeyboardFocus();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopButtonRepeat();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopClipRect();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopColumnsBackground();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFocusScope();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemFlag();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleColor(int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleVar(int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopTextWrapPos();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushAllowKeyboardFocus(byte allow_keyboard_focus);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushButtonRepeat(byte repeat);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnClipRect(int column_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnsBackground();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFocusScope(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFont(ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDStr(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDStrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDPtr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDInt(int int_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemFlag(ImGuiItemFlags option, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemWidth(float item_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushMultiItemsWidths(int components, float width_full);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushOverrideID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColorU32(ImGuiCol idx, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColorVec4(ImGuiCol idx, Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarFloat(ImGuiStyleVar idx, float val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarVec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButtonBool(byte* label, byte active);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButtonIntPtr(byte* label, int* v, int v_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRender();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderCheckMark(Vector2 pos, uint col, float sz);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderColorRectWithAlphaCheckerboard(Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, int rounding_corners_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte border, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderMouseCursor(ImDrawList* draw_list, Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderNavHighlight(ImRect bb, uint id, ImGuiNavHighlightFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igResetMouseDragDelta(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSaveIniSettingsToDisk(byte* ini_filename);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollbar(ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, float* p_scroll_v, float avail_v, float contents_v, ImDrawCornerFlags rounding_corners);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToBringRectIntoView(Vector2* pOut, ImGuiWindow* window, ImRect item_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectableBool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectableBoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparator();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorEx(ImGuiSeparatorFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveID(uint id, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetClipboardText(byte* text);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnWidth(int column_index, float width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentFont(ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosX(float local_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosY(float local_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorScreenPos(Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetFocusID(uint id, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetHoveredID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemAllowOverlap();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemDefaultFocus();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyboardFocusHere(int offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetMouseCursor(ImGuiMouseCursor cursor_type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavID(uint id, int nav_layer, uint focus_scope_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavIDWithRectRel(uint id, int nav_layer, uint focus_scope_id, ImRect rect_rel);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemOpen(byte is_open, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemWidth(float item_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowBgAlpha(float alpha);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowFocus();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosXFloat(float local_x, float center_x_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosXWindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosYFloat(float local_y, float center_y_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosYWindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereX(float center_x_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereY(float center_y_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollXFloat(float scroll_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollXWindowPtr(ImGuiWindow* window, float new_scroll_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollYFloat(float scroll_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollYWindowPtr(ImGuiWindow* window, float new_scroll_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetStateStorage(ImGuiStorage* storage);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTabItemClosed(byte* tab_or_docked_window_label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTooltip(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedBool(byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedStr(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedWindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocusNil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocusStr(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFontScale(float scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosVec2(Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosStr(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosWindowPtr(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeVec2(Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeStr(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeWindowPtr(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowAboutWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDemoWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontSelector(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowMetricsWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShowStyleSelector(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowUserGuide();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShutdown(IntPtr context);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, float power, ImGuiSliderFlags flags, ImRect* out_grab_bb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSmallButton(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindow(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsDark(ImGuiStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueChangeTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemCalcSize(Vector2* pOut, byte* label, byte has_close_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputTextIsActive(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputTextScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igText(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextColored(Vector4 col, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextDisabled(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextUnformatted(byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextWrapped(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeStr(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeStrStr(byte* str_id, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodePtr(void* ptr_id, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehaviorIsOpen(uint id, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExStr(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExStrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExPtr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePop();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushStr(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushPtr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushOverrideID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUnindent(float indent_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateHoveredWindowAndCaptureFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowEndFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowNewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueBool(byte* prefix, byte b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueInt(byte* prefix, int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueUint(byte* prefix, uint v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueFloat(byte* prefix, float v, byte* float_format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, float power);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBoolVector_Clear(ImBoolVector* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBoolVector_destroy(ImBoolVector* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImBoolVector_GetBit(ImBoolVector* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImBoolVector* ImBoolVector_ImBoolVector();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBoolVector_Resize(ImBoolVector* self, int sz);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBoolVector_SetBit(ImBoolVector* self, int n, byte v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImChunkStream_alloc_chunk(ImChunkStream* self, uint sz);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImChunkStream_begin(ImChunkStream* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImChunkStream_chunk_size(ImChunkStream* self, T* p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImChunkStream_clear(ImChunkStream* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImChunkStream_empty(ImChunkStream* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImChunkStream_end(ImChunkStream* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImChunkStream_next_chunk(ImChunkStream* self, T* p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImChunkStream_offset_from_ptr(ImChunkStream* self, T* p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImChunkStream_ptr_from_offset(ImChunkStream* self, int off);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImChunkStream_size(ImChunkStream* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_destroy(ImColor* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_HSV(ImColor* pOut, ImColor* self, float h, float s, float v, float a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorNil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorInt(int r, int g, int b, int a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorU32(uint rgba);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorFloat(float r, float g, float b, float a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorVec4(Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_Clear(ImDrawDataBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_ClearFreeMemory(ImDrawDataBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_FlattenIntoSingleLayer(ImDrawDataBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierCurve(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* callback_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, byte closed, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTextVec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTextFontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_Clear(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ClearFreeMemory(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, byte closed, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_UpdateClipRect(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_UpdateTextureID(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_destroy(IntPtr self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImDrawListSharedData_ImDrawListSharedData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_SetCircleSegmentMaxError(IntPtr self, float max_error);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddGlyph(ImFont* self, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_destroy(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFont_ImFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetFallbackChar(ImFont* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, uint id, int width, int height);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImplDX11_CreateDeviceObjects();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImplDX11_Init(void* device, void* device_context);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_InvalidateDeviceObjects();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_NewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_RenderDrawData(ImDrawData* draw_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_Shutdown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImplDX9_CreateDeviceObjects();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImplDX9_Init(void* device);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX9_InvalidateDeviceObjects();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX9_NewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX9_RenderDrawData(ImDrawData* draw_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX9_Shutdown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImplWin32_Init(void* hwnd);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplWin32_NewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplWin32_Shutdown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiColumnData_destroy(ImGuiColumnData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiColumnData* ImGuiColumnData_ImGuiColumnData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiColumns_Clear(ImGuiColumns* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiColumns_destroy(ImGuiColumns* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiColumns* ImGuiColumns_ImGuiColumns();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiContext_destroy(IntPtr self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_destroy(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetRedoAvailCount(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetUndoAvailCount(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* ImGuiInputTextState_ImGuiInputTextState();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiItemHoveredDataBackup_Backup(ImGuiItemHoveredDataBackup* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiItemHoveredDataBackup_destroy(ImGuiItemHoveredDataBackup* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemHoveredDataBackup* ImGuiItemHoveredDataBackup_ImGuiItemHoveredDataBackup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiItemHoveredDataBackup_Restore(ImGuiItemHoveredDataBackup* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper(int items_count, float items_height);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiMenuColumns_CalcExtraSpace(ImGuiMenuColumns* self, float avail_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w0, float w1, float w2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMenuColumns* ImGuiMenuColumns_ImGuiMenuColumns();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, int count, float spacing, byte clear);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavMoveResult_Clear(ImGuiNavMoveResult* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavMoveResult_destroy(ImGuiNavMoveResult* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNavMoveResult* ImGuiNavMoveResult_ImGuiNavMoveResult();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_destroy(ImGuiNextItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextItemData* ImGuiNextItemData_ImGuiNextItemData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextWindowData* ImGuiNextWindowData_ImGuiNextWindowData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPopupData_destroy(ImGuiPopupData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPopupData* ImGuiPopupData_ImGuiPopupData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndexPtr(void* ptr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndexInt(int index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* ImGuiSettingsHandler_ImGuiSettingsHandler();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairInt(uint _key, int _val_i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairFloat(uint _key, float _val_f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairPtr(uint _key, void* _val_p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyleMod_destroy(ImGuiStyleMod* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleModInt(ImGuiStyleVar idx, int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleModFloat(ImGuiStyleVar idx, float v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleModVec2(ImGuiStyleVar idx, Vector2 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabBar_destroy(ImGuiTabBar* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTabBar_GetTabName(ImGuiTabBar* self, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTabBar_GetTabOrder(ImGuiTabBar* self, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabBar* ImGuiTabBar_ImGuiTabBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabItem_destroy(ImGuiTabItem* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* ImGuiTabItem_ImGuiTabItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeNil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeStr(byte* _b, byte* _e);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_CalcFontSize(ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_destroy(ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDStr(ImGuiWindow* self, byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDPtr(ImGuiWindow* self, void* ptr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDInt(ImGuiWindow* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDNoKeepAliveStr(ImGuiWindow* self, byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDNoKeepAlivePtr(ImGuiWindow* self, void* ptr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDNoKeepAliveInt(ImGuiWindow* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* ImGuiWindow_ImGuiWindow(IntPtr context, byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_MenuBarHeight(ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_TitleBarHeight(ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* ImGuiWindowSettings_ImGuiWindowSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowTempData_destroy(ImGuiWindowTempData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowTempData* ImGuiWindowTempData_ImGuiWindowTempData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImPool_Add(ImPool* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPool_Clear(ImPool* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPool_Contains(ImPool* self, T* p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPool_destroy(ImPool* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImPool_GetByIndex(ImPool* self, ImPoolIdx n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImPool_GetByKey(ImPool* self, uint key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPoolIdx ImPool_GetIndex(ImPool* self, T* p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern T* ImPool_GetOrAddByKey(ImPool* self, uint key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPool_GetSize(ImPool* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPool* ImPool_ImPool();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPool_RemoveTPtr(ImPool* self, uint key, T* p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPool_RemovePoolIdx(ImPool* self, uint key, ImPoolIdx idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPool_Reserve(ImPool* self, int capacity);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_AddVec2(ImRect* self, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_AddRect(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWith(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWithFull(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_ContainsVec2(ImRect* self, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_ContainsRect(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_destroy(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ExpandFloat(ImRect* self, float amount);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ExpandVec2(ImRect* self, Vector2 amount);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Floor(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBL(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBR(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetCenter(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetHeight(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetSize(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTL(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTR(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetWidth(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectNil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectVec2(Vector2 min, Vector2 max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectVec4(Vector4 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectFloat(float x1, float y1, float x2, float y2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_IsInverted(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Overlaps(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Translate(ImRect* self, Vector2 d);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateX(ImRect* self, float dx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateY(ImRect* self, float dy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec1_destroy(ImVec1* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1Float(float _x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2_destroy(Vector2* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2Float(float _x, float _y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2ih_destroy(ImVec2ih* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ihNil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ihshort(short _x, short _y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ihVec2(Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec4_destroy(Vector4* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4Float(float _x, float _y, float _z, float _w);
    }
}
