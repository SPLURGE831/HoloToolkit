/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace XTools {

public class StringElement : Element {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal StringElement(global::System.IntPtr cPtr, bool cMemoryOwn) : base(XToolsClientPINVOKE.StringElement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StringElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringElement() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XToolsClientPINVOKE.delete_StringElement(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static StringElement Cast(Element element) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.StringElement_Cast(Element.getCPtr(element));
    StringElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringElement(cPtr, true);
    return ret; 
  }

  public virtual XString GetValue() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.StringElement_GetValue(swigCPtr);
    XString ret = (cPtr == global::System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

  public virtual void SetValue(XString newString) {
    XToolsClientPINVOKE.StringElement_SetValue(swigCPtr, XString.getCPtr(newString));
  }

}

}