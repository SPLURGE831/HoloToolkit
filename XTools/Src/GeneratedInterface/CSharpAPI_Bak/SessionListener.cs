/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace XTools {

public class SessionListener : Listener {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SessionListener(global::System.IntPtr cPtr, bool cMemoryOwn) : base(XToolsClientPINVOKE.SessionListener_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SessionListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SessionListener() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XToolsClientPINVOKE.delete_SessionListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void OnJoiningSession() {
    if (SwigDerivedClassHasMethod("OnJoiningSession", swigMethodTypes0)) XToolsClientPINVOKE.SessionListener_OnJoiningSessionSwigExplicitSessionListener(swigCPtr); else XToolsClientPINVOKE.SessionListener_OnJoiningSession(swigCPtr);
  }

  public virtual void OnJoinSucceeded() {
    if (SwigDerivedClassHasMethod("OnJoinSucceeded", swigMethodTypes1)) XToolsClientPINVOKE.SessionListener_OnJoinSucceededSwigExplicitSessionListener(swigCPtr); else XToolsClientPINVOKE.SessionListener_OnJoinSucceeded(swigCPtr);
  }

  public virtual void OnJoinFailed() {
    if (SwigDerivedClassHasMethod("OnJoinFailed", swigMethodTypes2)) XToolsClientPINVOKE.SessionListener_OnJoinFailedSwigExplicitSessionListener(swigCPtr); else XToolsClientPINVOKE.SessionListener_OnJoinFailed(swigCPtr);
  }

  public virtual void OnSessionDisconnected() {
    if (SwigDerivedClassHasMethod("OnSessionDisconnected", swigMethodTypes3)) XToolsClientPINVOKE.SessionListener_OnSessionDisconnectedSwigExplicitSessionListener(swigCPtr); else XToolsClientPINVOKE.SessionListener_OnSessionDisconnected(swigCPtr);
  }

  public SessionListener() : this(XToolsClientPINVOKE.new_SessionListener(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnJoiningSession", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateSessionListener_0(SwigDirectorOnJoiningSession);
    if (SwigDerivedClassHasMethod("OnJoinSucceeded", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateSessionListener_1(SwigDirectorOnJoinSucceeded);
    if (SwigDerivedClassHasMethod("OnJoinFailed", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateSessionListener_2(SwigDirectorOnJoinFailed);
    if (SwigDerivedClassHasMethod("OnSessionDisconnected", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateSessionListener_3(SwigDirectorOnSessionDisconnected);
    XToolsClientPINVOKE.SessionListener_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(SessionListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnJoiningSession() {
    OnJoiningSession();
  }

  private void SwigDirectorOnJoinSucceeded() {
    OnJoinSucceeded();
  }

  private void SwigDirectorOnJoinFailed() {
    OnJoinFailed();
  }

  private void SwigDirectorOnSessionDisconnected() {
    OnSessionDisconnected();
  }

  public delegate void SwigDelegateSessionListener_0();
  public delegate void SwigDelegateSessionListener_1();
  public delegate void SwigDelegateSessionListener_2();
  public delegate void SwigDelegateSessionListener_3();

  private SwigDelegateSessionListener_0 swigDelegate0;
  private SwigDelegateSessionListener_1 swigDelegate1;
  private SwigDelegateSessionListener_2 swigDelegate2;
  private SwigDelegateSessionListener_3 swigDelegate3;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] {  };
}

}