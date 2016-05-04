//This file is automatically generated. DO NOT EDIT!
using System;
using RobotRaconteur;
using System.Collections.Generic;

namespace experimental.create
{
public class SensorPacket
{
    public byte ID;
    public byte[] Data;
}

[RobotRaconteurServiceObjectInterface()]
public interface Create
{
    int DistanceTraveled { get; set; }
    int AngleTraveled { get; set; }
    byte Bumpers { get; set; }
    void Drive(short velocity, short radius);
    void StartStreaming();
    void StopStreaming();
    event Action Bump;
    Callback<Func<int,int,byte[]>> play_callback {get; set;}
    Wire<SensorPacket> packets{ get; set; }
}

public class experimental__createConstants 
{
    public class Create
    {
    public const short DRIVE_STRAIGHT=32767;
    public const short SPIN_CLOCKWISE=-1;
    public const short SPIN_COUNTERCLOCKWISE=1;
    }
}
}