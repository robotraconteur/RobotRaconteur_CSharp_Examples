//This file is automatically generated. DO NOT EDIT!
using System;
using RobotRaconteur;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace experimental.create
{
public class experimental__createFactory : ServiceFactory
{
    public override string DefString()
{
    const string d=@"
#Service to provide sample interface to the iRobot Create
service experimental.create

option version 0.5

struct SensorPacket
	field uint8 ID
	field uint8[] Data
end struct

object Create
	option constant int16 DRIVE_STRAIGHT 32767
	option constant int16 SPIN_CLOCKWISE -1
	option constant int16 SPIN_COUNTERCLOCKWISE 1 


	function void Drive(int16 velocity, int16 radius)
	
	function void StartStreaming()
	function void StopStreaming()

	property int32 DistanceTraveled
	property int32 AngleTraveled
	property uint8 Bumpers

	event Bump()

	wire SensorPacket packets
	
	callback uint8[] play_callback(int32 DistanceTraveled, int32 AngleTraveled)
		
end object";
    return d;
    }
    public override string GetServiceName() {return "experimental.create";}
    public SensorPacket_stub SensorPacket_stubentry;
    public experimental__createFactory()
{
    SensorPacket_stubentry=new SensorPacket_stub(this);
    }
    public override IStructureStub FindStructureStub(string objecttype)
    {
    string objshort=RemovePath(objecttype);
    if (objshort=="SensorPacket")    return SensorPacket_stubentry;
    throw new DataTypeException("Cannot find appropriate structure stub");
    }
    public override MessageElementStructure PackStructure(Object s) {
    if (s==null) return null;
    string objtype=s.GetType().ToString();
    if (RobotRaconteurNode.SplitQualifiedName(objtype)[0].TrimEnd(new char[] {'_'}) == "experimental.create") {
    string objshort=RemovePath(objtype);
    switch (objshort) {
    case "SensorPacket":
    return  SensorPacket_stubentry.PackStructure(s);
    default:
    break;
    }
    } else {
    return RobotRaconteurNode.s.PackStructure(s);
    }
    throw new Exception();
    }
    public override T UnpackStructure<T>(MessageElementStructure l) {
    if (l==null) return default(T);
    if (RobotRaconteurNode.SplitQualifiedName(l.Type)[0].TrimEnd(new char[] {'_'}) == "experimental.create") {
    string objshort=RemovePath(l.Type);
    switch (objshort) {
    case "SensorPacket":
    return  SensorPacket_stubentry.UnpackStructure<T>(l);
    default:
    break;
    }
    } else {
    return RobotRaconteurNode.s.UnpackStructure<T>(l);
    }
    throw new DataTypeException("Could not unpack structure");
    }
    public override ServiceStub CreateStub(WrappedServiceStub innerstub) {
    string objecttype=innerstub.RR_objecttype.GetServiceDefinition().Name + "." + innerstub.RR_objecttype.Name;    if (RobotRaconteurNode.SplitQualifiedName(objecttype)[0].TrimEnd(new char[] {'_'}) == "experimental.create") {
    string objshort=RemovePath(objecttype);
    switch (objshort) {
    case "Create":
    return new Create_stub(innerstub);
    default:
    break;
    }
    } else {
    string ext_service_type=RobotRaconteurNode.SplitQualifiedName(objecttype)[0].TrimEnd(new char[] {'_'});
    return RobotRaconteurNode.s.GetServiceType(ext_service_type).CreateStub(innerstub);
    }
    throw new ServiceException("Could not create stub");
    }
    public override ServiceSkel CreateSkel(object obj) {
    string objtype=ServiceSkelUtil.UnfixName(ServiceSkelUtil.FindParentInterface(obj.GetType()).ToString());
    if (RobotRaconteurNode.SplitQualifiedName(objtype.ToString())[0].TrimEnd(new char[] {'_'}) == "experimental.create") {
    string sobjtype=RemovePath(objtype);
    switch(sobjtype) {
    case "Create":
    return new Create_skel((Create)obj);
    default:
    break;
    }
    } else {
    string ext_service_type=RobotRaconteurNode.SplitQualifiedName(objtype.ToString())[0].TrimEnd(new char[] {'_'});
    return RobotRaconteurNode.s.GetServiceFactory(ext_service_type).CreateSkel(obj);
    }
    throw new ServiceException("Could not create skel");
    }
    public override RobotRaconteurException DownCastException(RobotRaconteurException rr_exp){
    if (rr_exp==null) return rr_exp;
    string rr_type=rr_exp.Error;
    if (!rr_type.Contains(".")) return rr_exp;
    string[] rr_stype = RobotRaconteurNode.SplitQualifiedName(rr_type);
    if (rr_stype[0] != "experimental.create") return RobotRaconteurNode.s.DownCastException(rr_exp);
    return rr_exp;
    }
}

public class SensorPacket_stub : IStructureStub {
    public SensorPacket_stub(experimental__createFactory d) {def=d;}
    private experimental__createFactory def;
    public MessageElementStructure PackStructure(object s1) {
    using(vectorptr_messageelement m=new vectorptr_messageelement())
    {
    if (s1 ==null) return null;
    SensorPacket s = (SensorPacket)s1;
    MessageElementUtil.AddMessageElementDispose(m,MessageElementUtil.NewMessageElementDispose("ID",new byte[] {s.ID}));
    MessageElementUtil.AddMessageElementDispose(m,MessageElementUtil.NewMessageElementDispose("Data",s.Data));
    return new MessageElementStructure("experimental.create.SensorPacket",m);
    }
    }
    public T UnpackStructure<T>(MessageElementStructure m) {
    if (m == null ) return default(T);
    SensorPacket s=new SensorPacket();
    using(vectorptr_messageelement mm=m.Elements)
    {
    s.ID =(MessageElementUtil.CastDataAndDispose<byte[]>(MessageElement.FindElement(mm,"ID")))[0];
    s.Data =MessageElementUtil.CastDataAndDispose<byte[]>(MessageElement.FindElement(mm,"Data"));
    T st; try {st=(T)((object)s);} catch (InvalidCastException e) {throw new DataTypeMismatchException("Wrong structuretype");}
    return st;
    }
    }
}

public interface async_Create
{
    void async_get_DistanceTraveled(Action<int,Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_set_DistanceTraveled(int value, Action<Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_get_AngleTraveled(Action<int,Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_set_AngleTraveled(int value, Action<Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_get_Bumpers(Action<byte,Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_set_Bumpers(byte value, Action<Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_Drive(short velocity, short radius,Action<Exception> rr_handler,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_StartStreaming(Action<Exception> rr_handler,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
    void async_StopStreaming(Action<Exception> rr_handler,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE);
}
public class Create_stub : ServiceStub , Create, async_Create{
    private CallbackClient<Func<int,int,byte[]>> rr_play_callback;
    private Wire<SensorPacket> rr_packets;
    public Create_stub(WrappedServiceStub innerstub) : base(innerstub) {
    rr_play_callback=new CallbackClient<Func<int,int,byte[]>>("play_callback");
    rr_packets=new Wire<SensorPacket>(innerstub.GetWire("packets"));
    }
    public int DistanceTraveled {
    get {
    return (MessageElementUtil.CastDataAndDispose<int[]>(rr_innerstub.PropertyGet("DistanceTraveled")))[0];
    }
    set {
    using(MessageElement m=MessageElementUtil.NewMessageElementDispose("value",new int[] {value}))
    {
    rr_innerstub.PropertySet("DistanceTraveled", m);
    }
    }
    }
    public int AngleTraveled {
    get {
    return (MessageElementUtil.CastDataAndDispose<int[]>(rr_innerstub.PropertyGet("AngleTraveled")))[0];
    }
    set {
    using(MessageElement m=MessageElementUtil.NewMessageElementDispose("value",new int[] {value}))
    {
    rr_innerstub.PropertySet("AngleTraveled", m);
    }
    }
    }
    public byte Bumpers {
    get {
    return (MessageElementUtil.CastDataAndDispose<byte[]>(rr_innerstub.PropertyGet("Bumpers")))[0];
    }
    set {
    using(MessageElement m=MessageElementUtil.NewMessageElementDispose("value",new byte[] {value}))
    {
    rr_innerstub.PropertySet("Bumpers", m);
    }
    }
    }
    public void Drive(short velocity, short radius) {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement())
    {
    MessageElementUtil.AddMessageElementDispose(rr_param,MessageElementUtil.NewMessageElementDispose("velocity",new short[] {velocity}));
    MessageElementUtil.AddMessageElementDispose(rr_param,MessageElementUtil.NewMessageElementDispose("radius",new short[] {radius}));
    using(MessageElement rr_me=rr_innerstub.FunctionCall("Drive",rr_param))
    {
    }
    }
    }
    public void StartStreaming() {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement())
    {
    using(MessageElement rr_me=rr_innerstub.FunctionCall("StartStreaming",rr_param))
    {
    }
    }
    }
    public void StopStreaming() {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement())
    {
    using(MessageElement rr_me=rr_innerstub.FunctionCall("StopStreaming",rr_param))
    {
    }
    }
    }
    public event Action Bump;
    public override void DispatchEvent(string rr_membername, vectorptr_messageelement rr_m) {
    switch (rr_membername) {
    case "Bump":
    {
    if (Bump != null) { 
    Bump();
    }
    return;
    }
    default:
    break;
    }
    }
    public Callback<Func<int,int,byte[]>> play_callback {
    get { return rr_play_callback;  }
    set { throw new InvalidOperationException();}
    }
    public Wire<SensorPacket> packets {
    get { return rr_packets;  }
    set { throw new InvalidOperationException();}
    }
    public override MessageElement CallbackCall(string rr_membername, vectorptr_messageelement rr_m) {
    switch (rr_membername) {
    case "play_callback":
    {
    int DistanceTraveled=(MessageElementUtil.CastDataAndDispose<int[]>(vectorptr_messageelement_util.FindElement(rr_m,"DistanceTraveled")))[0];
    int AngleTraveled=(MessageElementUtil.CastDataAndDispose<int[]>(vectorptr_messageelement_util.FindElement(rr_m,"AngleTraveled")))[0];
    byte[] ret=play_callback.Function(DistanceTraveled, AngleTraveled);
    return MessageElementUtil.NewMessageElementDispose("return",ret);
    }
    default:
    break;
    }
    throw new MemberNotFoundException("Member not found");
    }
    public virtual void async_get_DistanceTraveled(Action<int,Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    rr_async_PropertyGet("DistanceTraveled",rrend_async_get_DistanceTraveled,rr_handler,rr_timeout);
    }
    protected virtual void rrend_async_get_DistanceTraveled(MessageElement value ,Exception err,object param)
    {
    Action<int,Exception> rr_handler=(Action<int,Exception>)param;
    if (err!=null)
    {
    rr_handler(0,err);
    return;
    }
    int rr_ret;
    try {
    rr_ret=(MessageElementUtil.CastDataAndDispose<int[]>(value))[0];
    } catch (Exception err2) {
    rr_handler(0,err2);
    return;
    }
    rr_handler(rr_ret,null);
    }
    public virtual void async_set_DistanceTraveled(int value, Action<Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    using(MessageElement mm=MessageElementUtil.NewMessageElementDispose("value",new int[] {value}))
    {
    rr_async_PropertySet("DistanceTraveled",mm,rrend_async_set_DistanceTraveled,rr_handler,rr_timeout);
    }
    }
    protected virtual void rrend_async_set_DistanceTraveled(MessageElement m ,Exception err,object param)
    {
    Action<Exception> rr_handler=(Action<Exception>)param;
    if (err!=null)
    {
    rr_handler(err);
    return;
    }
    rr_handler(null);
    }
    public virtual void async_get_AngleTraveled(Action<int,Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    rr_async_PropertyGet("AngleTraveled",rrend_async_get_AngleTraveled,rr_handler,rr_timeout);
    }
    protected virtual void rrend_async_get_AngleTraveled(MessageElement value ,Exception err,object param)
    {
    Action<int,Exception> rr_handler=(Action<int,Exception>)param;
    if (err!=null)
    {
    rr_handler(0,err);
    return;
    }
    int rr_ret;
    try {
    rr_ret=(MessageElementUtil.CastDataAndDispose<int[]>(value))[0];
    } catch (Exception err2) {
    rr_handler(0,err2);
    return;
    }
    rr_handler(rr_ret,null);
    }
    public virtual void async_set_AngleTraveled(int value, Action<Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    using(MessageElement mm=MessageElementUtil.NewMessageElementDispose("value",new int[] {value}))
    {
    rr_async_PropertySet("AngleTraveled",mm,rrend_async_set_AngleTraveled,rr_handler,rr_timeout);
    }
    }
    protected virtual void rrend_async_set_AngleTraveled(MessageElement m ,Exception err,object param)
    {
    Action<Exception> rr_handler=(Action<Exception>)param;
    if (err!=null)
    {
    rr_handler(err);
    return;
    }
    rr_handler(null);
    }
    public virtual void async_get_Bumpers(Action<byte,Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    rr_async_PropertyGet("Bumpers",rrend_async_get_Bumpers,rr_handler,rr_timeout);
    }
    protected virtual void rrend_async_get_Bumpers(MessageElement value ,Exception err,object param)
    {
    Action<byte,Exception> rr_handler=(Action<byte,Exception>)param;
    if (err!=null)
    {
    rr_handler(0,err);
    return;
    }
    byte rr_ret;
    try {
    rr_ret=(MessageElementUtil.CastDataAndDispose<byte[]>(value))[0];
    } catch (Exception err2) {
    rr_handler(0,err2);
    return;
    }
    rr_handler(rr_ret,null);
    }
    public virtual void async_set_Bumpers(byte value, Action<Exception> rr_handler, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    using(MessageElement mm=MessageElementUtil.NewMessageElementDispose("value",new byte[] {value}))
    {
    rr_async_PropertySet("Bumpers",mm,rrend_async_set_Bumpers,rr_handler,rr_timeout);
    }
    }
    protected virtual void rrend_async_set_Bumpers(MessageElement m ,Exception err,object param)
    {
    Action<Exception> rr_handler=(Action<Exception>)param;
    if (err!=null)
    {
    rr_handler(err);
    return;
    }
    rr_handler(null);
    }
    public virtual void async_Drive(short velocity, short radius,Action<Exception> rr_handler,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement())
    {
    MessageElementUtil.AddMessageElementDispose(rr_param,MessageElementUtil.NewMessageElementDispose("velocity",new short[] {velocity}));
    MessageElementUtil.AddMessageElementDispose(rr_param,MessageElementUtil.NewMessageElementDispose("radius",new short[] {radius}));
    rr_async_FunctionCall("Drive",rr_param,rrend_async_Drive,rr_handler,rr_timeout);
    }
    }
    protected virtual void rrend_async_Drive(MessageElement ret ,Exception err,object param)
    {
    Action<Exception> rr_handler=(Action<Exception>)param;
    if (err!=null)
    {
    rr_handler(err);
    return;
    }
    rr_handler(null);
    }
    public virtual void async_StartStreaming(Action<Exception> rr_handler,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement())
    {
    rr_async_FunctionCall("StartStreaming",rr_param,rrend_async_StartStreaming,rr_handler,rr_timeout);
    }
    }
    protected virtual void rrend_async_StartStreaming(MessageElement ret ,Exception err,object param)
    {
    Action<Exception> rr_handler=(Action<Exception>)param;
    if (err!=null)
    {
    rr_handler(err);
    return;
    }
    rr_handler(null);
    }
    public virtual void async_StopStreaming(Action<Exception> rr_handler,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement())
    {
    rr_async_FunctionCall("StopStreaming",rr_param,rrend_async_StopStreaming,rr_handler,rr_timeout);
    }
    }
    protected virtual void rrend_async_StopStreaming(MessageElement ret ,Exception err,object param)
    {
    Action<Exception> rr_handler=(Action<Exception>)param;
    if (err!=null)
    {
    rr_handler(err);
    return;
    }
    rr_handler(null);
    }
}
public class Create_skel : ServiceSkel {
    protected Create obj;
    public Create_skel(object o) : base(o) { obj=(Create)o; }
    public override void ReleaseCastObject() { 
    obj=null;
    base.ReleaseCastObject();
    }
    public override MessageElement CallGetProperty(string membername) {
    switch (membername) {
    case "DistanceTraveled":
    {
    int ret=obj.DistanceTraveled;
    return MessageElementUtil.NewMessageElementDispose("return",new int[] {ret});
    }
    case "AngleTraveled":
    {
    int ret=obj.AngleTraveled;
    return MessageElementUtil.NewMessageElementDispose("return",new int[] {ret});
    }
    case "Bumpers":
    {
    byte ret=obj.Bumpers;
    return MessageElementUtil.NewMessageElementDispose("return",new byte[] {ret});
    }
    default:
    break;
    }
    throw new MemberNotFoundException("Member not found");
    }
    public override void CallSetProperty(string membername, MessageElement m) {
    switch (membername) {
    case "DistanceTraveled":
    {
    obj.DistanceTraveled=(MessageElementUtil.CastDataAndDispose<int[]>(m))[0];
    return;
    }
    case "AngleTraveled":
    {
    obj.AngleTraveled=(MessageElementUtil.CastDataAndDispose<int[]>(m))[0];
    return;
    }
    case "Bumpers":
    {
    obj.Bumpers=(MessageElementUtil.CastDataAndDispose<byte[]>(m))[0];
    return;
    }
    default:
    break;
    }
    throw new MemberNotFoundException("Member not found");
    }
    public override MessageElement CallFunction(string rr_membername, vectorptr_messageelement rr_m) {
    switch (rr_membername) {
    case "Drive":
    {
    short velocity=(MessageElementUtil.CastDataAndDispose<short[]>(vectorptr_messageelement_util.FindElement(rr_m,"velocity")))[0];
    short radius=(MessageElementUtil.CastDataAndDispose<short[]>(vectorptr_messageelement_util.FindElement(rr_m,"radius")))[0];
    this.obj.Drive(velocity, radius);
    return new MessageElement("return",(int)0);
    }
    case "StartStreaming":
    {
    this.obj.StartStreaming();
    return new MessageElement("return",(int)0);
    }
    case "StopStreaming":
    {
    this.obj.StopStreaming();
    return new MessageElement("return",(int)0);
    }
    default:
    break;
    }
    throw new MemberNotFoundException("Member not found");
    }
    public override object GetSubObj(string name, string ind) {
    switch (name) {
    default:
    break;
    }
    throw new MemberNotFoundException("");
    }
    public override void RegisterEvents(object rrobj1) {
    obj=(Create)rrobj1;
    obj.Bump+=rr_Bump;
    }
    public override void UnregisterEvents(object rrobj1) {
    obj=(Create)rrobj1;
    obj.Bump-=rr_Bump;
    }
    public void rr_Bump() {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement()) {
    this.innerskel.WrappedDispatchEvent("Bump",rr_param);
    }
    }
    public override object GetCallbackFunction(uint rr_endpoint, string rr_membername) {
    switch (rr_membername) {
    case "play_callback": {
    return new Func<int,int,byte[]>( delegate(int DistanceTraveled, int AngleTraveled) {
    using(vectorptr_messageelement rr_param=new vectorptr_messageelement())
    {
    MessageElementUtil.AddMessageElementDispose(rr_param,MessageElementUtil.NewMessageElementDispose("DistanceTraveled",new int[] {DistanceTraveled}));
    MessageElementUtil.AddMessageElementDispose(rr_param,MessageElementUtil.NewMessageElementDispose("AngleTraveled",new int[] {AngleTraveled}));
    using(MessageElement rr_me=this.innerskel.WrappedCallbackCall("play_callback",rr_endpoint,rr_param))
    {
    return MessageElementUtil.CastDataAndDispose<byte[]>(rr_me);
    }
    }
    });
    }
    default:
    break;
    }
    throw new MemberNotFoundException("Member not found");
    }
    public override void InitPipeServers(object rrobj1) {
    obj=(Create)rrobj1;
    }
    public override void InitCallbackServers(object rrobj1) {
    obj=(Create)rrobj1;
    obj.play_callback=new CallbackServer<Func<int,int,byte[]>>("play_callback",this);
    }
    public override void InitWireServers(object rrobj1) {
    obj=(Create)rrobj1;
    obj.packets=new Wire<SensorPacket>(innerskel.GetWire("packets"));
    }
    public override WrappedArrayMemoryDirector GetArrayMemory(string name) {
    switch (name) {
    default:
    break;
    }
    throw new MemberNotFoundException("Member Not Found");
    }
    public override WrappedMultiDimArrayMemoryDirector GetMultiDimArrayMemory(string name) {
    switch (name) {
    default:
    break;
    }
    throw new MemberNotFoundException("Member Not Found");
    }
    public override string RRType { get { return "experimental.create.Create"; } }
}
public static class RRExtensions{
    public static Task<int> async_get_DistanceTraveled(this async_Create rr_obj, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurTaskCompletion<int> t=new RobotRaconteurTaskCompletion<int>();
    rr_obj.async_get_DistanceTraveled(t.handler,rr_timeout);
    return t.Task;
    }
    public static Task async_set_DistanceTraveled(this async_Create rr_obj, int value, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurVoidTaskCompletion t=new RobotRaconteurVoidTaskCompletion();
    rr_obj.async_set_DistanceTraveled(value,t.handler,rr_timeout);
    return t.Task;
    }
    public static Task<int> async_get_AngleTraveled(this async_Create rr_obj, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurTaskCompletion<int> t=new RobotRaconteurTaskCompletion<int>();
    rr_obj.async_get_AngleTraveled(t.handler,rr_timeout);
    return t.Task;
    }
    public static Task async_set_AngleTraveled(this async_Create rr_obj, int value, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurVoidTaskCompletion t=new RobotRaconteurVoidTaskCompletion();
    rr_obj.async_set_AngleTraveled(value,t.handler,rr_timeout);
    return t.Task;
    }
    public static Task<byte> async_get_Bumpers(this async_Create rr_obj, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurTaskCompletion<byte> t=new RobotRaconteurTaskCompletion<byte>();
    rr_obj.async_get_Bumpers(t.handler,rr_timeout);
    return t.Task;
    }
    public static Task async_set_Bumpers(this async_Create rr_obj, byte value, int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurVoidTaskCompletion t=new RobotRaconteurVoidTaskCompletion();
    rr_obj.async_set_Bumpers(value,t.handler,rr_timeout);
    return t.Task;
    }
    public static Task async_Drive(this async_Create rr_obj,short velocity, short radius,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurVoidTaskCompletion rr_t=new RobotRaconteurVoidTaskCompletion();
    rr_obj.async_Drive(velocity, radius,rr_t.handler,rr_timeout);
    return rr_t.Task;
    }
    public static Task async_StartStreaming(this async_Create rr_obj,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurVoidTaskCompletion rr_t=new RobotRaconteurVoidTaskCompletion();
    rr_obj.async_StartStreaming(rr_t.handler,rr_timeout);
    return rr_t.Task;
    }
    public static Task async_StopStreaming(this async_Create rr_obj,int rr_timeout=RobotRaconteurNode.RR_TIMEOUT_INFINITE)
    {
    RobotRaconteurVoidTaskCompletion rr_t=new RobotRaconteurVoidTaskCompletion();
    rr_obj.async_StopStreaming(rr_t.handler,rr_timeout);
    return rr_t.Task;
    }
}
}