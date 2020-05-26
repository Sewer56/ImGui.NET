using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImRect
    {
        public Vector2 Min;
        public Vector2 Max;
    }
    public unsafe partial struct ImRectPtr
    {
        public ImRect* NativePtr { get; }
        public ImRectPtr(ImRect* nativePtr) => NativePtr = nativePtr;
        public ImRectPtr(IntPtr nativePtr) => NativePtr = (ImRect*)nativePtr;
        public static implicit operator ImRectPtr(ImRect* nativePtr) => new ImRectPtr(nativePtr);
        public static implicit operator ImRect* (ImRectPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImRectPtr(IntPtr nativePtr) => new ImRectPtr(nativePtr);
        public ref Vector2 Min => ref Unsafe.AsRef<Vector2>(&NativePtr->Min);
        public ref Vector2 Max => ref Unsafe.AsRef<Vector2>(&NativePtr->Max);
        public void Add(Vector2 p)
        {
            ImGuiNative.ImRect_AddVec2(NativePtr, p);
        }
        public void Add(ImRect r)
        {
            ImGuiNative.ImRect_AddRect(NativePtr, r);
        }
        public void ClipWith(ImRect r)
        {
            ImGuiNative.ImRect_ClipWith(NativePtr, r);
        }
        public void ClipWithFull(ImRect r)
        {
            ImGuiNative.ImRect_ClipWithFull(NativePtr, r);
        }
        public bool Contains(Vector2 p)
        {
            byte ret = ImGuiNative.ImRect_ContainsVec2(NativePtr, p);
            return ret != 0;
        }
        public bool Contains(ImRect r)
        {
            byte ret = ImGuiNative.ImRect_ContainsRect(NativePtr, r);
            return ret != 0;
        }
        public void Destroy()
        {
            ImGuiNative.ImRect_destroy(NativePtr);
        }
        public void Expand(float amount)
        {
            ImGuiNative.ImRect_ExpandFloat(NativePtr, amount);
        }
        public void Expand(Vector2 amount)
        {
            ImGuiNative.ImRect_ExpandVec2(NativePtr, amount);
        }
        public void Floor()
        {
            ImGuiNative.ImRect_Floor(NativePtr);
        }
        public void GetBL(ImRectPtr self)
        {
            ImRect* native_self = self.NativePtr;
            ImGuiNative.ImRect_GetBL(NativePtr, native_self);
        }
        public void GetBR(ImRectPtr self)
        {
            ImRect* native_self = self.NativePtr;
            ImGuiNative.ImRect_GetBR(NativePtr, native_self);
        }
        public void GetCenter(ImRectPtr self)
        {
            ImRect* native_self = self.NativePtr;
            ImGuiNative.ImRect_GetCenter(NativePtr, native_self);
        }
        public float GetHeight()
        {
            float ret = ImGuiNative.ImRect_GetHeight(NativePtr);
            return ret;
        }
        public void GetSize(ImRectPtr self)
        {
            ImRect* native_self = self.NativePtr;
            ImGuiNative.ImRect_GetSize(NativePtr, native_self);
        }
        public void GetTL(ImRectPtr self)
        {
            ImRect* native_self = self.NativePtr;
            ImGuiNative.ImRect_GetTL(NativePtr, native_self);
        }
        public void GetTR(ImRectPtr self)
        {
            ImRect* native_self = self.NativePtr;
            ImGuiNative.ImRect_GetTR(NativePtr, native_self);
        }
        public float GetWidth()
        {
            float ret = ImGuiNative.ImRect_GetWidth(NativePtr);
            return ret;
        }
        public bool IsInverted()
        {
            byte ret = ImGuiNative.ImRect_IsInverted(NativePtr);
            return ret != 0;
        }
        public bool Overlaps(ImRect r)
        {
            byte ret = ImGuiNative.ImRect_Overlaps(NativePtr, r);
            return ret != 0;
        }
        public void Translate(Vector2 d)
        {
            ImGuiNative.ImRect_Translate(NativePtr, d);
        }
        public void TranslateX(float dx)
        {
            ImGuiNative.ImRect_TranslateX(NativePtr, dx);
        }
        public void TranslateY(float dy)
        {
            ImGuiNative.ImRect_TranslateY(NativePtr, dy);
        }
    }
}
