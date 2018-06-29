using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zwave
{

    public class Rootobject
    {
        public Controller controller { get; set; }
        public Devices devices { get; set; }
        public int updateTime { get; set; }
    }

    public class Controller
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Nodeid nodeId { get; set; }
        public Homeid homeId { get; set; }
        public Sucnodeid SUCNodeId { get; set; }
        public Isprimary isPrimary { get; set; }
        public Isinothersnetwork isInOthersNetwork { get; set; }
        public Isrealprimary isRealPrimary { get; set; }
        public Issuc isSUC { get; set; }
        public Sispresent SISPresent { get; set; }
        public Libtype libType { get; set; }
        public SDK SDK { get; set; }
        public Zwlibmajor ZWlibMajor { get; set; }
        public Zwlibminor ZWlibMinor { get; set; }
        public Zwlib ZWLib { get; set; }
        public Zwversion ZWVersion { get; set; }
        public Zwavechip ZWaveChip { get; set; }
        public Apiversion APIVersion { get; set; }
        public Manufacturerid manufacturerId { get; set; }
        public Vendor vendor { get; set; }
        public Manufacturerproducttype manufacturerProductType { get; set; }
        public Manufacturerproductid manufacturerProductId { get; set; }
        public Bootloadercrc bootloaderCRC { get; set; }
        public Firmwarecrc firmwareCRC { get; set; }
        public Capabilities capabilities { get; set; }
        public Controllerstate controllerState { get; set; }
        public Nonmanagmentjobs nonManagmentJobs { get; set; }
        public Lastincludeddevice lastIncludedDevice { get; set; }
        public Lastexcludeddevice lastExcludedDevice { get; set; }
        public Secureinclusion secureInclusion { get; set; }
        public Oldserialapiacktimeout10ms oldSerialAPIAckTimeout10ms { get; set; }
        public Oldserialapibytetimeout10ms oldSerialAPIByteTimeout10ms { get; set; }
        public Curserialapiacktimeout10ms curSerialAPIAckTimeout10ms { get; set; }
        public Curserialapibytetimeout10ms curSerialAPIByteTimeout10ms { get; set; }
        public Countjobs countJobs { get; set; }
        public Memorygetaddress memoryGetAddress { get; set; }
        public Memorygetdata memoryGetData { get; set; }
        public Functionclasses functionClasses { get; set; }
        public Functionclassesnames functionClassesNames { get; set; }
        public Softwarerevisionversion softwareRevisionVersion { get; set; }
        public Softwarerevisionid softwareRevisionId { get; set; }
        public Softwarerevisiondate softwareRevisionDate { get; set; }
        public Uuid uuid { get; set; }
        public Caps caps { get; set; }
        public Frequency frequency { get; set; }
        public Devicerelaxdelay deviceRelaxDelay { get; set; }
        public Statistics statistics { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Homeid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Sucnodeid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isprimary
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isinothersnetwork
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isrealprimary
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Issuc
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Sispresent
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Libtype
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class SDK
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwlibmajor
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwlibminor
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwlib
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwversion
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwavechip
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Apiversion
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Vendor
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerproducttype
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerproductid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Bootloadercrc
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Firmwarecrc
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Capabilities
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Controllerstate
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nonmanagmentjobs
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastincludeddevice
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastexcludeddevice
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Secureinclusion
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Oldserialapiacktimeout10ms
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Oldserialapibytetimeout10ms
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Curserialapiacktimeout10ms
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Curserialapibytetimeout10ms
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Countjobs
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Memorygetaddress
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Memorygetdata
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Functionclasses
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Functionclassesnames
    {
        public string[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Softwarerevisionversion
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Softwarerevisionid
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Softwarerevisiondate
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Uuid
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Caps
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Frequency
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Devicerelaxdelay
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Statistics
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Backgroundrssi backgroundRSSI { get; set; }
        public Rftxframes RFTxFrames { get; set; }
        public Rftxlbtbackoffs RFTxLBTBackOffs { get; set; }
        public Rfrxframes RFRxFrames { get; set; }
        public Rfrxlrcerrors RFRxLRCErrors { get; set; }
        public Rfrxcrc16errors RFRxCRC16Errors { get; set; }
        public Rfrxforeignhomeid RFRxForeignHomeID { get; set; }
        public Priorityroute priorityRoute { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Backgroundrssi
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Channel1 channel1 { get; set; }
        public Channel2 channel2 { get; set; }
        public Channel3 channel3 { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Channel1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Channel2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Channel3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Rftxframes
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Rftxlbtbackoffs
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Rfrxframes
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Rfrxlrcerrors
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Rfrxcrc16errors
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Rfrxforeignhomeid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Priorityroute
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dstnodeid dstNodeId { get; set; }
        public Routetype routeType { get; set; }
        public Speed speed { get; set; }
        public Hops hops { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dstnodeid
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Routetype
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Speed
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Hops
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Devices
    {
        [JsonProperty("1")]
        public _1 _1 { get; set; }
        [JsonProperty("2")]
        public _21 _2 { get; set; }
    }

    public class _1
    {
        public Data1 data { get; set; }
        public Instances instances { get; set; }
    }

    public class Data1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Basictype basicType { get; set; }
        public Generictype genericType { get; set; }
        public Specifictype specificType { get; set; }
        public Infoprotocolspecific infoProtocolSpecific { get; set; }
        public Devicetypestring deviceTypeString { get; set; }
        public Isvirtual isVirtual { get; set; }
        public Islistening isListening { get; set; }
        public Isrouting isRouting { get; set; }
        public Isawake isAwake { get; set; }
        public Optional optional { get; set; }
        public Isfailed isFailed { get; set; }
        public Sensor250 sensor250 { get; set; }
        public Sensor1000 sensor1000 { get; set; }
        public Neighbours neighbours { get; set; }
        public Manufacturerid1 manufacturerId { get; set; }
        public Vendorstring vendorString { get; set; }
        public Manufacturerproducttype1 manufacturerProductType { get; set; }
        public Manufacturerproductid1 manufacturerProductId { get; set; }
        public Zwlib1 ZWLib { get; set; }
        public Zwprotocolmajor ZWProtocolMajor { get; set; }
        public Zwprotocolminor ZWProtocolMinor { get; set; }
        public SDK1 SDK { get; set; }
        public Applicationmajor applicationMajor { get; set; }
        public Applicationminor applicationMinor { get; set; }
        public Nodeinfoframe nodeInfoFrame { get; set; }
        public Zddxmlfile ZDDXMLFile { get; set; }
        public Lastsend lastSend { get; set; }
        public Lastnonceget lastNonceGet { get; set; }
        public Lastreceived lastReceived { get; set; }
        public Failurecount failureCount { get; set; }
        public Keepawake keepAwake { get; set; }
        public Queuelength queueLength { get; set; }
        public Givenname givenName { get; set; }
        public Securechannelestablished secureChannelEstablished { get; set; }
        public Securecontrollerid secureControllerId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Basictype
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Infoprotocolspecific
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Devicetypestring
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isvirtual
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Islistening
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isrouting
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isawake
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Optional
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isfailed
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Sensor250
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Sensor1000
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Neighbours
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerid1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Vendorstring
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerproducttype1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerproductid1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwlib1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolmajor
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolminor
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class SDK1
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationmajor
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationminor
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zddxmlfile
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastsend
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastnonceget
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastreceived
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Failurecount
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keepawake
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Queuelength
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Givenname
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Securechannelestablished
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Securecontrollerid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Instances
    {
        [JsonProperty("0")]
        public _0 _0 { get; set; }
        [JsonProperty("1")]
        public _14 _1 { get; set; }
        [JsonProperty("2")]
        public _2 _2 { get; set; }
        [JsonProperty("3")]
        public _3 _3 { get; set; }
        [JsonProperty("4")]
        public _4 _4 { get; set; }
        [JsonProperty("5")]
        public _5 _5 { get; set; }
        [JsonProperty("6")]
        public _6 _6 { get; set; }
        [JsonProperty("7")]
        public _7 _7 { get; set; }
        [JsonProperty("8")]
        public _8 _8 { get; set; }
        [JsonProperty("9")]
        public _9 _9 { get; set; }
        [JsonProperty("10")]
        public _10 _10 { get; set; }
        [JsonProperty("11")]
        public _111 _11 { get; set; }
        [JsonProperty("12")]
        public _121 _12 { get; set; }
        [JsonProperty("13")]
        public _131 _13 { get; set; }
        [JsonProperty("14")]
        public _141 _14 { get; set; }
        [JsonProperty("15")]
        public _15 _15 { get; set; }
        [JsonProperty("16")]
        public _16 _16 { get; set; }
    }

    public class _0
    {
        public Data2 data { get; set; }
        public Commandclasses commandClasses { get; set; }
    }

    public class Data2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic dynamic { get; set; }
        public Generictype1 genericType { get; set; }
        public Specifictype1 specificType { get; set; }
        public Nodeinfoframe1 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses
    {
        [JsonProperty("32")]
        public _32 _32 { get; set; }
        [JsonProperty("34")]
        public _34 _34 { get; set; }
        [JsonProperty("37")]
        public _37 _37 { get; set; }
        [JsonProperty("38")]
        public _38 _38 { get; set; }
        [JsonProperty("43")]
        public _43 _43 { get; set; }
        [JsonProperty("70")]
        public _70 _70 { get; set; }
        [JsonProperty("86")]
        public _86 _86 { get; set; }
        [JsonProperty("89")]
        public _89 _89 { get; set; }
        [JsonProperty("90")]
        public _901 _90 { get; set; }
        [JsonProperty("91")]
        public _91 _91 { get; set; }
        [JsonProperty("94")]
        public _94 _94 { get; set; }
        [JsonProperty("96")]
        public _96 _96 { get; set; }
        [JsonProperty("114")]
        public _114 _114 { get; set; }
        [JsonProperty("115")]
        public _115 _115 { get; set; }
        [JsonProperty("119")]
        public _119 _119 { get; set; }
        [JsonProperty("129")]
        public _129 _129 { get; set; }
        [JsonProperty("133")]
        public _133 _133 { get; set; }
        [JsonProperty("134")]
        public _134 _134 { get; set; }
        [JsonProperty("138")]
        public _138 _138 { get; set; }
        [JsonProperty("142")]
        public _142 _142 { get; set; }
        [JsonProperty("143")]
        public _143 _143 { get; set; }
        [JsonProperty("152")]
        public _152 _152 { get; set; }
    }

    public class _32
    {
        public string name { get; set; }
        public Data3 data { get; set; }
    }

    public class Data3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported supported { get; set; }
        public Version version { get; set; }
        public Security security { get; set; }
        public Interviewdone interviewDone { get; set; }
        public Interviewcounter interviewCounter { get; set; }
        public Level level { get; set; }
        public Srcnodeid srcNodeId { get; set; }
        public Srcinstanceid srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _34
    {
        public string name { get; set; }
        public Data4 data { get; set; }
    }

    public class Data4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported1 supported { get; set; }
        public Version1 version { get; set; }
        public Security1 security { get; set; }
        public Interviewdone1 interviewDone { get; set; }
        public Interviewcounter1 interviewCounter { get; set; }
        public Srcnodeid1 srcNodeId { get; set; }
        public Srcinstanceid1 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _37
    {
        public string name { get; set; }
        public Data5 data { get; set; }
    }

    public class Data5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported2 supported { get; set; }
        public Version2 version { get; set; }
        public Security2 security { get; set; }
        public Interviewdone2 interviewDone { get; set; }
        public Interviewcounter2 interviewCounter { get; set; }
        public Level1 level { get; set; }
        public Srcnodeid2 srcNodeId { get; set; }
        public Srcinstanceid2 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported2
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security2
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone2
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _38
    {
        public string name { get; set; }
        public Data6 data { get; set; }
    }

    public class Data6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported3 supported { get; set; }
        public Version3 version { get; set; }
        public Security3 security { get; set; }
        public Interviewdone3 interviewDone { get; set; }
        public Interviewcounter3 interviewCounter { get; set; }
        public Level2 level { get; set; }
        public Startchange startChange { get; set; }
        public Stopchange stopChange { get; set; }
        public Prevlevel prevLevel { get; set; }
        public Srcnodeid3 srcNodeId { get; set; }
        public Srcinstanceid3 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported3
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security3
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone3
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _43
    {
        public string name { get; set; }
        public Data7 data { get; set; }
    }

    public class Data7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported4 supported { get; set; }
        public Version4 version { get; set; }
        public Security4 security { get; set; }
        public Interviewdone4 interviewDone { get; set; }
        public Interviewcounter4 interviewCounter { get; set; }
        public Currentscene currentScene { get; set; }
        public Dimmingduration dimmingDuration { get; set; }
        public Srcnodeid4 srcNodeId { get; set; }
        public Srcinstanceid4 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported4
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version4
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security4
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone4
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter4
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _70
    {
        public string name { get; set; }
        public Data8 data { get; set; }
    }

    public class Data8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported5 supported { get; set; }
        public Version5 version { get; set; }
        public Security5 security { get; set; }
        public Interviewdone5 interviewDone { get; set; }
        public Interviewcounter5 interviewCounter { get; set; }
        public Overridetype overrideType { get; set; }
        public Overridestate overrideState { get; set; }
        public Srcnodeid5 srcNodeId { get; set; }
        public Srcinstanceid5 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported5
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version5
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security5
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone5
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter5
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Overridetype
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Overridestate
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _86
    {
        public string name { get; set; }
        public Data9 data { get; set; }
    }

    public class Data9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported6 supported { get; set; }
        public Version6 version { get; set; }
        public Security6 security { get; set; }
        public Interviewdone6 interviewDone { get; set; }
        public Interviewcounter6 interviewCounter { get; set; }
        public Srcnodeid6 srcNodeId { get; set; }
        public Srcinstanceid6 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported6
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version6
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security6
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone6
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter6
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _89
    {
        public string name { get; set; }
        public Data10 data { get; set; }
    }

    public class Data10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported7 supported { get; set; }
        public Version7 version { get; set; }
        public Security7 security { get; set; }
        public Interviewdone7 interviewDone { get; set; }
        public Interviewcounter7 interviewCounter { get; set; }
        public Dynamic1 dynamic { get; set; }
        public _11 _1 { get; set; }
        public Srcnodeid7 srcNodeId { get; set; }
        public Srcinstanceid7 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported7
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version7
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security7
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone7
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter7
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Groupname groupName { get; set; }
        public Mode mode { get; set; }
        public Profile profile { get; set; }
        public Eventcode eventCode { get; set; }
        public Commands commands { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Groupname
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Mode
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Profile
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Eventcode
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commands
    {
        public Value value { get; set; }
        public string type { get; set; }
        public _90 _90 { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _90
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _901
    {
        public string name { get; set; }
        public Data11 data { get; set; }
    }

    public class Data11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported8 supported { get; set; }
        public Version8 version { get; set; }
        public Security8 security { get; set; }
        public Interviewdone8 interviewDone { get; set; }
        public Interviewcounter8 interviewCounter { get; set; }
        public Reset reset { get; set; }
        public Srcnodeid8 srcNodeId { get; set; }
        public Srcinstanceid8 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported8
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version8
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security8
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone8
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter8
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Reset
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _91
    {
        public string name { get; set; }
        public Data12 data { get; set; }
    }

    public class Data12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported9 supported { get; set; }
        public Version9 version { get; set; }
        public Security9 security { get; set; }
        public Interviewdone9 interviewDone { get; set; }
        public Interviewcounter9 interviewCounter { get; set; }
        public Maxscenes maxScenes { get; set; }
        public Currentscene1 currentScene { get; set; }
        public Keyattribute keyAttribute { get; set; }
        public Srcnodeid9 srcNodeId { get; set; }
        public Srcinstanceid9 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported9
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version9
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security9
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone9
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter9
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _94
    {
        public string name { get; set; }
        public Data13 data { get; set; }
    }

    public class Data13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported10 supported { get; set; }
        public Version10 version { get; set; }
        public Security10 security { get; set; }
        public Interviewdone10 interviewDone { get; set; }
        public Interviewcounter10 interviewCounter { get; set; }
        public Plusversion plusVersion { get; set; }
        public Roletype roleType { get; set; }
        public Nodetype nodeType { get; set; }
        public Installericon installerIcon { get; set; }
        public Usericon userIcon { get; set; }
        public Roletypestring roleTypeString { get; set; }
        public Srcnodeid10 srcNodeId { get; set; }
        public Srcinstanceid10 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported10
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version10
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security10
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone10
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter10
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Plusversion
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Roletype
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodetype
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Installericon
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Usericon
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Roletypestring
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _96
    {
        public string name { get; set; }
        public Data14 data { get; set; }
    }

    public class Data14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported11 supported { get; set; }
        public Version11 version { get; set; }
        public Security11 security { get; set; }
        public Interviewdone11 interviewDone { get; set; }
        public Interviewcounter11 interviewCounter { get; set; }
        public Endpoints endPoints { get; set; }
        public Aggregated aggregated { get; set; }
        public Dynamic2 dynamic { get; set; }
        public Identical identical { get; set; }
        public Srcnodeid11 srcNodeId { get; set; }
        public Srcinstanceid11 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported11
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version11
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security11
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone11
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter11
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Endpoints
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Aggregated
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Identical
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _114
    {
        public string name { get; set; }
        public Data15 data { get; set; }
    }

    public class Data15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported12 supported { get; set; }
        public Version12 version { get; set; }
        public Security12 security { get; set; }
        public Interviewdone12 interviewDone { get; set; }
        public Interviewcounter12 interviewCounter { get; set; }
        public Vendorid vendorId { get; set; }
        public Vendor1 vendor { get; set; }
        public Productid productId { get; set; }
        public Producttype productType { get; set; }
        public Serialnumber serialNumber { get; set; }
        public Srcnodeid12 srcNodeId { get; set; }
        public Srcinstanceid12 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported12
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version12
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security12
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone12
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter12
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Vendorid
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Vendor1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Productid
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Producttype
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Serialnumber
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _115
    {
        public string name { get; set; }
        public Data16 data { get; set; }
    }

    public class Data16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported13 supported { get; set; }
        public Version13 version { get; set; }
        public Security13 security { get; set; }
        public Interviewdone13 interviewDone { get; set; }
        public Interviewcounter13 interviewCounter { get; set; }
        public Level3 level { get; set; }
        public Timeout timeout { get; set; }
        public Srcnodeid13 srcNodeId { get; set; }
        public Srcinstanceid13 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported13
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version13
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security13
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone13
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter13
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Timeout
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _119
    {
        public string name { get; set; }
        public Data17 data { get; set; }
    }

    public class Data17
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported14 supported { get; set; }
        public Version14 version { get; set; }
        public Security14 security { get; set; }
        public Interviewdone14 interviewDone { get; set; }
        public Interviewcounter14 interviewCounter { get; set; }
        public Nodename nodename { get; set; }
        public Location location { get; set; }
        public Nameencoding nameEncoding { get; set; }
        public Locationencoding locationEncoding { get; set; }
        public Srcnodeid14 srcNodeId { get; set; }
        public Srcinstanceid14 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported14
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version14
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security14
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone14
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter14
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodename
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Location
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nameencoding
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Locationencoding
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _129
    {
        public string name { get; set; }
        public Data18 data { get; set; }
    }

    public class Data18
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported15 supported { get; set; }
        public Version15 version { get; set; }
        public Security15 security { get; set; }
        public Interviewdone15 interviewDone { get; set; }
        public Interviewcounter15 interviewCounter { get; set; }
        public Srcnodeid15 srcNodeId { get; set; }
        public Srcinstanceid15 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported15
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version15
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security15
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone15
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter15
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _133
    {
        public string name { get; set; }
        public Data19 data { get; set; }
    }

    public class Data19
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported16 supported { get; set; }
        public Version16 version { get; set; }
        public Security16 security { get; set; }
        public Interviewdone16 interviewDone { get; set; }
        public Interviewcounter16 interviewCounter { get; set; }
        public Groups groups { get; set; }
        public Specificgroup specificGroup { get; set; }
        public _12 _1 { get; set; }
        public Srcnodeid16 srcNodeId { get; set; }
        public Srcinstanceid16 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported16
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version16
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security16
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone16
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter16
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Groups
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specificgroup
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Max max { get; set; }
        public Nodes nodes { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Max
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodes
    {
        public object[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _134
    {
        public string name { get; set; }
        public Data20 data { get; set; }
    }

    public class Data20
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported17 supported { get; set; }
        public Version17 version { get; set; }
        public Security17 security { get; set; }
        public Interviewdone17 interviewDone { get; set; }
        public Interviewcounter17 interviewCounter { get; set; }
        public Zwlib2 ZWLib { get; set; }
        public Zwprotocolmajor1 ZWProtocolMajor { get; set; }
        public Zwprotocolminor1 ZWProtocolMinor { get; set; }
        public SDK2 SDK { get; set; }
        public Applicationmajor1 applicationMajor { get; set; }
        public Applicationminor1 applicationMinor { get; set; }
        public Hardwareversion hardwareVersion { get; set; }
        public Firmwarecount firmwareCount { get; set; }
        public Srcnodeid17 srcNodeId { get; set; }
        public Srcinstanceid17 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported17
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version17
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security17
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone17
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter17
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwlib2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolmajor1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolminor1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class SDK2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationmajor1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationminor1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Hardwareversion
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Firmwarecount
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid17
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid17
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _138
    {
        public string name { get; set; }
        public Data21 data { get; set; }
    }

    public class Data21
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported18 supported { get; set; }
        public Version18 version { get; set; }
        public Security18 security { get; set; }
        public Interviewdone18 interviewDone { get; set; }
        public Interviewcounter18 interviewCounter { get; set; }
        public Srcnodeid18 srcNodeId { get; set; }
        public Srcinstanceid18 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported18
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version18
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security18
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone18
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter18
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid18
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid18
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _142
    {
        public string name { get; set; }
        public Data22 data { get; set; }
    }

    public class Data22
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported19 supported { get; set; }
        public Version19 version { get; set; }
        public Security19 security { get; set; }
        public Interviewdone19 interviewDone { get; set; }
        public Interviewcounter19 interviewCounter { get; set; }
        public Groups1 groups { get; set; }
        public _13 _1 { get; set; }
        public Srcnodeid19 srcNodeId { get; set; }
        public Srcinstanceid19 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported19
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version19
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security19
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone19
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter19
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Groups1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Max1 max { get; set; }
        public Nodesinstances nodesInstances { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Max1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodesinstances
    {
        public object[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid19
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid19
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _143
    {
        public string name { get; set; }
        public Data23 data { get; set; }
    }

    public class Data23
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported20 supported { get; set; }
        public Version20 version { get; set; }
        public Security20 security { get; set; }
        public Interviewdone20 interviewDone { get; set; }
        public Interviewcounter20 interviewCounter { get; set; }
        public Maxnum maxNum { get; set; }
        public Srcnodeid20 srcNodeId { get; set; }
        public Srcinstanceid20 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported20
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version20
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security20
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone20
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter20
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxnum
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid20
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid20
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _152
    {
        public string name { get; set; }
        public Data24 data { get; set; }
    }

    public class Data24
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported21 supported { get; set; }
        public Version21 version { get; set; }
        public Security21 security { get; set; }
        public Interviewdone21 interviewDone { get; set; }
        public Interviewcounter21 interviewCounter { get; set; }
        public Scheme scheme { get; set; }
        public Securenodeinfoframe secureNodeInfoFrame { get; set; }
        public Securityabandoned securityAbandoned { get; set; }
        public Canstream canStream { get; set; }
        public Tofollow toFollow { get; set; }
        public Srcnodeid21 srcNodeId { get; set; }
        public Srcinstanceid21 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported21
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version21
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security21
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone21
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter21
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Scheme
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Securenodeinfoframe
    {
        public object[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Securityabandoned
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Canstream
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Tofollow
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid21
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid21
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _14
    {
        public Data25 data { get; set; }
        public Commandclasses1 commandClasses { get; set; }
    }

    public class Data25
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic3 dynamic { get; set; }
        public Generictype2 genericType { get; set; }
        public Specifictype2 specificType { get; set; }
        public Nodeinfoframe2 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic3
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe2
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses1
    {
        public _321 _32 { get; set; }
        public _371 _37 { get; set; }
        public _381 _38 { get; set; }
        public _431 _43 { get; set; }
        public _911 _91 { get; set; }
    }

    public class _321
    {
        public string name { get; set; }
        public Data26 data { get; set; }
    }

    public class Data26
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported22 supported { get; set; }
        public Version22 version { get; set; }
        public Security22 security { get; set; }
        public Interviewdone22 interviewDone { get; set; }
        public Interviewcounter22 interviewCounter { get; set; }
        public Level4 level { get; set; }
        public Srcnodeid22 srcNodeId { get; set; }
        public Srcinstanceid22 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported22
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version22
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security22
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone22
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter22
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid22
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid22
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _371
    {
        public string name { get; set; }
        public Data27 data { get; set; }
    }

    public class Data27
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported23 supported { get; set; }
        public Version23 version { get; set; }
        public Security23 security { get; set; }
        public Interviewdone23 interviewDone { get; set; }
        public Interviewcounter23 interviewCounter { get; set; }
        public Level5 level { get; set; }
        public Srcnodeid23 srcNodeId { get; set; }
        public Srcinstanceid23 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported23
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version23
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security23
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone23
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter23
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid23
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid23
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _381
    {
        public string name { get; set; }
        public Data28 data { get; set; }
    }

    public class Data28
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported24 supported { get; set; }
        public Version24 version { get; set; }
        public Security24 security { get; set; }
        public Interviewdone24 interviewDone { get; set; }
        public Interviewcounter24 interviewCounter { get; set; }
        public Level6 level { get; set; }
        public Startchange1 startChange { get; set; }
        public Stopchange1 stopChange { get; set; }
        public Prevlevel1 prevLevel { get; set; }
        public Srcnodeid24 srcNodeId { get; set; }
        public Srcinstanceid24 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported24
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version24
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security24
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone24
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter24
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid24
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid24
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _431
    {
        public string name { get; set; }
        public Data29 data { get; set; }
    }

    public class Data29
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported25 supported { get; set; }
        public Version25 version { get; set; }
        public Security25 security { get; set; }
        public Interviewdone25 interviewDone { get; set; }
        public Interviewcounter25 interviewCounter { get; set; }
        public Currentscene2 currentScene { get; set; }
        public Dimmingduration1 dimmingDuration { get; set; }
        public Srcnodeid25 srcNodeId { get; set; }
        public Srcinstanceid25 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported25
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version25
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security25
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone25
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter25
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid25
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid25
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _911
    {
        public string name { get; set; }
        public Data30 data { get; set; }
    }

    public class Data30
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported26 supported { get; set; }
        public Version26 version { get; set; }
        public Security26 security { get; set; }
        public Interviewdone26 interviewDone { get; set; }
        public Interviewcounter26 interviewCounter { get; set; }
        public Maxscenes1 maxScenes { get; set; }
        public Currentscene3 currentScene { get; set; }
        public Keyattribute1 keyAttribute { get; set; }
        public Srcnodeid26 srcNodeId { get; set; }
        public Srcinstanceid26 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported26
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version26
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security26
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone26
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter26
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid26
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid26
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _2
    {
        public Data31 data { get; set; }
        public Commandclasses2 commandClasses { get; set; }
    }

    public class Data31
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic4 dynamic { get; set; }
        public Generictype3 genericType { get; set; }
        public Specifictype3 specificType { get; set; }
        public Nodeinfoframe3 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic4
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe3
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses2
    {
        public _322 _32 { get; set; }
        public _372 _37 { get; set; }
        public _382 _38 { get; set; }
        public _432 _43 { get; set; }
        public _912 _91 { get; set; }
    }

    public class _322
    {
        public string name { get; set; }
        public Data32 data { get; set; }
    }

    public class Data32
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported27 supported { get; set; }
        public Version27 version { get; set; }
        public Security27 security { get; set; }
        public Interviewdone27 interviewDone { get; set; }
        public Interviewcounter27 interviewCounter { get; set; }
        public Level7 level { get; set; }
        public Srcnodeid27 srcNodeId { get; set; }
        public Srcinstanceid27 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported27
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version27
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security27
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone27
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter27
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid27
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid27
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _372
    {
        public string name { get; set; }
        public Data33 data { get; set; }
    }

    public class Data33
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported28 supported { get; set; }
        public Version28 version { get; set; }
        public Security28 security { get; set; }
        public Interviewdone28 interviewDone { get; set; }
        public Interviewcounter28 interviewCounter { get; set; }
        public Level8 level { get; set; }
        public Srcnodeid28 srcNodeId { get; set; }
        public Srcinstanceid28 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported28
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version28
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security28
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone28
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter28
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid28
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid28
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _382
    {
        public string name { get; set; }
        public Data34 data { get; set; }
    }

    public class Data34
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported29 supported { get; set; }
        public Version29 version { get; set; }
        public Security29 security { get; set; }
        public Interviewdone29 interviewDone { get; set; }
        public Interviewcounter29 interviewCounter { get; set; }
        public Level9 level { get; set; }
        public Startchange2 startChange { get; set; }
        public Stopchange2 stopChange { get; set; }
        public Prevlevel2 prevLevel { get; set; }
        public Srcnodeid29 srcNodeId { get; set; }
        public Srcinstanceid29 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported29
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version29
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security29
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone29
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter29
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid29
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid29
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _432
    {
        public string name { get; set; }
        public Data35 data { get; set; }
    }

    public class Data35
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported30 supported { get; set; }
        public Version30 version { get; set; }
        public Security30 security { get; set; }
        public Interviewdone30 interviewDone { get; set; }
        public Interviewcounter30 interviewCounter { get; set; }
        public Currentscene4 currentScene { get; set; }
        public Dimmingduration2 dimmingDuration { get; set; }
        public Srcnodeid30 srcNodeId { get; set; }
        public Srcinstanceid30 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported30
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version30
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security30
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone30
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter30
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid30
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid30
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _912
    {
        public string name { get; set; }
        public Data36 data { get; set; }
    }

    public class Data36
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported31 supported { get; set; }
        public Version31 version { get; set; }
        public Security31 security { get; set; }
        public Interviewdone31 interviewDone { get; set; }
        public Interviewcounter31 interviewCounter { get; set; }
        public Maxscenes2 maxScenes { get; set; }
        public Currentscene5 currentScene { get; set; }
        public Keyattribute2 keyAttribute { get; set; }
        public Srcnodeid31 srcNodeId { get; set; }
        public Srcinstanceid31 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported31
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version31
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security31
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone31
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter31
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute2
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid31
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid31
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3
    {
        public Data37 data { get; set; }
        public Commandclasses3 commandClasses { get; set; }
    }

    public class Data37
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic5 dynamic { get; set; }
        public Generictype4 genericType { get; set; }
        public Specifictype4 specificType { get; set; }
        public Nodeinfoframe4 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic5
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype4
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype4
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe4
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses3
    {
        public _323 _32 { get; set; }
        public _373 _37 { get; set; }
        public _383 _38 { get; set; }
        public _433 _43 { get; set; }
        public _913 _91 { get; set; }
    }

    public class _323
    {
        public string name { get; set; }
        public Data38 data { get; set; }
    }

    public class Data38
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported32 supported { get; set; }
        public Version32 version { get; set; }
        public Security32 security { get; set; }
        public Interviewdone32 interviewDone { get; set; }
        public Interviewcounter32 interviewCounter { get; set; }
        public Level10 level { get; set; }
        public Srcnodeid32 srcNodeId { get; set; }
        public Srcinstanceid32 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported32
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version32
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security32
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone32
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter32
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid32
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid32
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _373
    {
        public string name { get; set; }
        public Data39 data { get; set; }
    }

    public class Data39
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported33 supported { get; set; }
        public Version33 version { get; set; }
        public Security33 security { get; set; }
        public Interviewdone33 interviewDone { get; set; }
        public Interviewcounter33 interviewCounter { get; set; }
        public Level11 level { get; set; }
        public Srcnodeid33 srcNodeId { get; set; }
        public Srcinstanceid33 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported33
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version33
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security33
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone33
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter33
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid33
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid33
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _383
    {
        public string name { get; set; }
        public Data40 data { get; set; }
    }

    public class Data40
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported34 supported { get; set; }
        public Version34 version { get; set; }
        public Security34 security { get; set; }
        public Interviewdone34 interviewDone { get; set; }
        public Interviewcounter34 interviewCounter { get; set; }
        public Level12 level { get; set; }
        public Startchange3 startChange { get; set; }
        public Stopchange3 stopChange { get; set; }
        public Prevlevel3 prevLevel { get; set; }
        public Srcnodeid34 srcNodeId { get; set; }
        public Srcinstanceid34 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported34
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version34
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security34
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone34
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter34
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid34
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid34
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _433
    {
        public string name { get; set; }
        public Data41 data { get; set; }
    }

    public class Data41
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported35 supported { get; set; }
        public Version35 version { get; set; }
        public Security35 security { get; set; }
        public Interviewdone35 interviewDone { get; set; }
        public Interviewcounter35 interviewCounter { get; set; }
        public Currentscene6 currentScene { get; set; }
        public Dimmingduration3 dimmingDuration { get; set; }
        public Srcnodeid35 srcNodeId { get; set; }
        public Srcinstanceid35 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported35
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version35
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security35
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone35
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter35
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid35
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid35
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _913
    {
        public string name { get; set; }
        public Data42 data { get; set; }
    }

    public class Data42
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported36 supported { get; set; }
        public Version36 version { get; set; }
        public Security36 security { get; set; }
        public Interviewdone36 interviewDone { get; set; }
        public Interviewcounter36 interviewCounter { get; set; }
        public Maxscenes3 maxScenes { get; set; }
        public Currentscene7 currentScene { get; set; }
        public Keyattribute3 keyAttribute { get; set; }
        public Srcnodeid36 srcNodeId { get; set; }
        public Srcinstanceid36 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported36
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version36
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security36
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone36
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter36
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute3
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid36
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid36
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4
    {
        public Data43 data { get; set; }
        public Commandclasses4 commandClasses { get; set; }
    }

    public class Data43
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic6 dynamic { get; set; }
        public Generictype5 genericType { get; set; }
        public Specifictype5 specificType { get; set; }
        public Nodeinfoframe5 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic6
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype5
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype5
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe5
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses4
    {
        public _324 _32 { get; set; }
        public _374 _37 { get; set; }
        public _384 _38 { get; set; }
        public _434 _43 { get; set; }
        public _914 _91 { get; set; }
    }

    public class _324
    {
        public string name { get; set; }
        public Data44 data { get; set; }
    }

    public class Data44
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported37 supported { get; set; }
        public Version37 version { get; set; }
        public Security37 security { get; set; }
        public Interviewdone37 interviewDone { get; set; }
        public Interviewcounter37 interviewCounter { get; set; }
        public Level13 level { get; set; }
        public Srcnodeid37 srcNodeId { get; set; }
        public Srcinstanceid37 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported37
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version37
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security37
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone37
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter37
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid37
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid37
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _374
    {
        public string name { get; set; }
        public Data45 data { get; set; }
    }

    public class Data45
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported38 supported { get; set; }
        public Version38 version { get; set; }
        public Security38 security { get; set; }
        public Interviewdone38 interviewDone { get; set; }
        public Interviewcounter38 interviewCounter { get; set; }
        public Level14 level { get; set; }
        public Srcnodeid38 srcNodeId { get; set; }
        public Srcinstanceid38 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported38
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version38
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security38
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone38
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter38
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid38
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid38
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _384
    {
        public string name { get; set; }
        public Data46 data { get; set; }
    }

    public class Data46
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported39 supported { get; set; }
        public Version39 version { get; set; }
        public Security39 security { get; set; }
        public Interviewdone39 interviewDone { get; set; }
        public Interviewcounter39 interviewCounter { get; set; }
        public Level15 level { get; set; }
        public Startchange4 startChange { get; set; }
        public Stopchange4 stopChange { get; set; }
        public Prevlevel4 prevLevel { get; set; }
        public Srcnodeid39 srcNodeId { get; set; }
        public Srcinstanceid39 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported39
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version39
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security39
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone39
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter39
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid39
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid39
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _434
    {
        public string name { get; set; }
        public Data47 data { get; set; }
    }

    public class Data47
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported40 supported { get; set; }
        public Version40 version { get; set; }
        public Security40 security { get; set; }
        public Interviewdone40 interviewDone { get; set; }
        public Interviewcounter40 interviewCounter { get; set; }
        public Currentscene8 currentScene { get; set; }
        public Dimmingduration4 dimmingDuration { get; set; }
        public Srcnodeid40 srcNodeId { get; set; }
        public Srcinstanceid40 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported40
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version40
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security40
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone40
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter40
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid40
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid40
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _914
    {
        public string name { get; set; }
        public Data48 data { get; set; }
    }

    public class Data48
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported41 supported { get; set; }
        public Version41 version { get; set; }
        public Security41 security { get; set; }
        public Interviewdone41 interviewDone { get; set; }
        public Interviewcounter41 interviewCounter { get; set; }
        public Maxscenes4 maxScenes { get; set; }
        public Currentscene9 currentScene { get; set; }
        public Keyattribute4 keyAttribute { get; set; }
        public Srcnodeid41 srcNodeId { get; set; }
        public Srcinstanceid41 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported41
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version41
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security41
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone41
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter41
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute4
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid41
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid41
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _5
    {
        public Data49 data { get; set; }
        public Commandclasses5 commandClasses { get; set; }
    }

    public class Data49
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic7 dynamic { get; set; }
        public Generictype6 genericType { get; set; }
        public Specifictype6 specificType { get; set; }
        public Nodeinfoframe6 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic7
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype6
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype6
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe6
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses5
    {
        public _325 _32 { get; set; }
        public _375 _37 { get; set; }
        public _385 _38 { get; set; }
        public _435 _43 { get; set; }
        public _915 _91 { get; set; }
    }

    public class _325
    {
        public string name { get; set; }
        public Data50 data { get; set; }
    }

    public class Data50
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported42 supported { get; set; }
        public Version42 version { get; set; }
        public Security42 security { get; set; }
        public Interviewdone42 interviewDone { get; set; }
        public Interviewcounter42 interviewCounter { get; set; }
        public Level16 level { get; set; }
        public Srcnodeid42 srcNodeId { get; set; }
        public Srcinstanceid42 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported42
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version42
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security42
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone42
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter42
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid42
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid42
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _375
    {
        public string name { get; set; }
        public Data51 data { get; set; }
    }

    public class Data51
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported43 supported { get; set; }
        public Version43 version { get; set; }
        public Security43 security { get; set; }
        public Interviewdone43 interviewDone { get; set; }
        public Interviewcounter43 interviewCounter { get; set; }
        public Level17 level { get; set; }
        public Srcnodeid43 srcNodeId { get; set; }
        public Srcinstanceid43 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported43
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version43
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security43
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone43
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter43
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level17
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid43
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid43
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _385
    {
        public string name { get; set; }
        public Data52 data { get; set; }
    }

    public class Data52
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported44 supported { get; set; }
        public Version44 version { get; set; }
        public Security44 security { get; set; }
        public Interviewdone44 interviewDone { get; set; }
        public Interviewcounter44 interviewCounter { get; set; }
        public Level18 level { get; set; }
        public Startchange5 startChange { get; set; }
        public Stopchange5 stopChange { get; set; }
        public Prevlevel5 prevLevel { get; set; }
        public Srcnodeid44 srcNodeId { get; set; }
        public Srcinstanceid44 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported44
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version44
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security44
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone44
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter44
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level18
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid44
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid44
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _435
    {
        public string name { get; set; }
        public Data53 data { get; set; }
    }

    public class Data53
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported45 supported { get; set; }
        public Version45 version { get; set; }
        public Security45 security { get; set; }
        public Interviewdone45 interviewDone { get; set; }
        public Interviewcounter45 interviewCounter { get; set; }
        public Currentscene10 currentScene { get; set; }
        public Dimmingduration5 dimmingDuration { get; set; }
        public Srcnodeid45 srcNodeId { get; set; }
        public Srcinstanceid45 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported45
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version45
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security45
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone45
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter45
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid45
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid45
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _915
    {
        public string name { get; set; }
        public Data54 data { get; set; }
    }

    public class Data54
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported46 supported { get; set; }
        public Version46 version { get; set; }
        public Security46 security { get; set; }
        public Interviewdone46 interviewDone { get; set; }
        public Interviewcounter46 interviewCounter { get; set; }
        public Maxscenes5 maxScenes { get; set; }
        public Currentscene11 currentScene { get; set; }
        public Keyattribute5 keyAttribute { get; set; }
        public Srcnodeid46 srcNodeId { get; set; }
        public Srcinstanceid46 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported46
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version46
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security46
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone46
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter46
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute5
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid46
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid46
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _6
    {
        public Data55 data { get; set; }
        public Commandclasses6 commandClasses { get; set; }
    }

    public class Data55
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic8 dynamic { get; set; }
        public Generictype7 genericType { get; set; }
        public Specifictype7 specificType { get; set; }
        public Nodeinfoframe7 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic8
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype7
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype7
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe7
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses6
    {
        public _326 _32 { get; set; }
        public _376 _37 { get; set; }
        public _386 _38 { get; set; }
        public _436 _43 { get; set; }
        public _916 _91 { get; set; }
    }

    public class _326
    {
        public string name { get; set; }
        public Data56 data { get; set; }
    }

    public class Data56
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported47 supported { get; set; }
        public Version47 version { get; set; }
        public Security47 security { get; set; }
        public Interviewdone47 interviewDone { get; set; }
        public Interviewcounter47 interviewCounter { get; set; }
        public Level19 level { get; set; }
        public Srcnodeid47 srcNodeId { get; set; }
        public Srcinstanceid47 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported47
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version47
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security47
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone47
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter47
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level19
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid47
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid47
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _376
    {
        public string name { get; set; }
        public Data57 data { get; set; }
    }

    public class Data57
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported48 supported { get; set; }
        public Version48 version { get; set; }
        public Security48 security { get; set; }
        public Interviewdone48 interviewDone { get; set; }
        public Interviewcounter48 interviewCounter { get; set; }
        public Level20 level { get; set; }
        public Srcnodeid48 srcNodeId { get; set; }
        public Srcinstanceid48 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported48
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version48
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security48
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone48
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter48
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level20
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid48
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid48
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _386
    {
        public string name { get; set; }
        public Data58 data { get; set; }
    }

    public class Data58
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported49 supported { get; set; }
        public Version49 version { get; set; }
        public Security49 security { get; set; }
        public Interviewdone49 interviewDone { get; set; }
        public Interviewcounter49 interviewCounter { get; set; }
        public Level21 level { get; set; }
        public Startchange6 startChange { get; set; }
        public Stopchange6 stopChange { get; set; }
        public Prevlevel6 prevLevel { get; set; }
        public Srcnodeid49 srcNodeId { get; set; }
        public Srcinstanceid49 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported49
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version49
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security49
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone49
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter49
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level21
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid49
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid49
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _436
    {
        public string name { get; set; }
        public Data59 data { get; set; }
    }

    public class Data59
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported50 supported { get; set; }
        public Version50 version { get; set; }
        public Security50 security { get; set; }
        public Interviewdone50 interviewDone { get; set; }
        public Interviewcounter50 interviewCounter { get; set; }
        public Currentscene12 currentScene { get; set; }
        public Dimmingduration6 dimmingDuration { get; set; }
        public Srcnodeid50 srcNodeId { get; set; }
        public Srcinstanceid50 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported50
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version50
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security50
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone50
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter50
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid50
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid50
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _916
    {
        public string name { get; set; }
        public Data60 data { get; set; }
    }

    public class Data60
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported51 supported { get; set; }
        public Version51 version { get; set; }
        public Security51 security { get; set; }
        public Interviewdone51 interviewDone { get; set; }
        public Interviewcounter51 interviewCounter { get; set; }
        public Maxscenes6 maxScenes { get; set; }
        public Currentscene13 currentScene { get; set; }
        public Keyattribute6 keyAttribute { get; set; }
        public Srcnodeid51 srcNodeId { get; set; }
        public Srcinstanceid51 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported51
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version51
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security51
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone51
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter51
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute6
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid51
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid51
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _7
    {
        public Data61 data { get; set; }
        public Commandclasses7 commandClasses { get; set; }
    }

    public class Data61
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic9 dynamic { get; set; }
        public Generictype8 genericType { get; set; }
        public Specifictype8 specificType { get; set; }
        public Nodeinfoframe8 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic9
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype8
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype8
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe8
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses7
    {
        public _327 _32 { get; set; }
        public _377 _37 { get; set; }
        public _387 _38 { get; set; }
        public _437 _43 { get; set; }
        public _917 _91 { get; set; }
    }

    public class _327
    {
        public string name { get; set; }
        public Data62 data { get; set; }
    }

    public class Data62
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported52 supported { get; set; }
        public Version52 version { get; set; }
        public Security52 security { get; set; }
        public Interviewdone52 interviewDone { get; set; }
        public Interviewcounter52 interviewCounter { get; set; }
        public Level22 level { get; set; }
        public Srcnodeid52 srcNodeId { get; set; }
        public Srcinstanceid52 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported52
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version52
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security52
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone52
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter52
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level22
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid52
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid52
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _377
    {
        public string name { get; set; }
        public Data63 data { get; set; }
    }

    public class Data63
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported53 supported { get; set; }
        public Version53 version { get; set; }
        public Security53 security { get; set; }
        public Interviewdone53 interviewDone { get; set; }
        public Interviewcounter53 interviewCounter { get; set; }
        public Level23 level { get; set; }
        public Srcnodeid53 srcNodeId { get; set; }
        public Srcinstanceid53 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported53
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version53
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security53
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone53
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter53
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level23
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid53
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid53
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _387
    {
        public string name { get; set; }
        public Data64 data { get; set; }
    }

    public class Data64
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported54 supported { get; set; }
        public Version54 version { get; set; }
        public Security54 security { get; set; }
        public Interviewdone54 interviewDone { get; set; }
        public Interviewcounter54 interviewCounter { get; set; }
        public Level24 level { get; set; }
        public Startchange7 startChange { get; set; }
        public Stopchange7 stopChange { get; set; }
        public Prevlevel7 prevLevel { get; set; }
        public Srcnodeid54 srcNodeId { get; set; }
        public Srcinstanceid54 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported54
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version54
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security54
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone54
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter54
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level24
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid54
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid54
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _437
    {
        public string name { get; set; }
        public Data65 data { get; set; }
    }

    public class Data65
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported55 supported { get; set; }
        public Version55 version { get; set; }
        public Security55 security { get; set; }
        public Interviewdone55 interviewDone { get; set; }
        public Interviewcounter55 interviewCounter { get; set; }
        public Currentscene14 currentScene { get; set; }
        public Dimmingduration7 dimmingDuration { get; set; }
        public Srcnodeid55 srcNodeId { get; set; }
        public Srcinstanceid55 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported55
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version55
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security55
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone55
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter55
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid55
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid55
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _917
    {
        public string name { get; set; }
        public Data66 data { get; set; }
    }

    public class Data66
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported56 supported { get; set; }
        public Version56 version { get; set; }
        public Security56 security { get; set; }
        public Interviewdone56 interviewDone { get; set; }
        public Interviewcounter56 interviewCounter { get; set; }
        public Maxscenes7 maxScenes { get; set; }
        public Currentscene15 currentScene { get; set; }
        public Keyattribute7 keyAttribute { get; set; }
        public Srcnodeid56 srcNodeId { get; set; }
        public Srcinstanceid56 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported56
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version56
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security56
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone56
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter56
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute7
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid56
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid56
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _8
    {
        public Data67 data { get; set; }
        public Commandclasses8 commandClasses { get; set; }
    }

    public class Data67
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic10 dynamic { get; set; }
        public Generictype9 genericType { get; set; }
        public Specifictype9 specificType { get; set; }
        public Nodeinfoframe9 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic10
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype9
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype9
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe9
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses8
    {
        public _328 _32 { get; set; }
        public _378 _37 { get; set; }
        public _388 _38 { get; set; }
        public _438 _43 { get; set; }
        public _918 _91 { get; set; }
    }

    public class _328
    {
        public string name { get; set; }
        public Data68 data { get; set; }
    }

    public class Data68
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported57 supported { get; set; }
        public Version57 version { get; set; }
        public Security57 security { get; set; }
        public Interviewdone57 interviewDone { get; set; }
        public Interviewcounter57 interviewCounter { get; set; }
        public Level25 level { get; set; }
        public Srcnodeid57 srcNodeId { get; set; }
        public Srcinstanceid57 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported57
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version57
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security57
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone57
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter57
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level25
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid57
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid57
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _378
    {
        public string name { get; set; }
        public Data69 data { get; set; }
    }

    public class Data69
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported58 supported { get; set; }
        public Version58 version { get; set; }
        public Security58 security { get; set; }
        public Interviewdone58 interviewDone { get; set; }
        public Interviewcounter58 interviewCounter { get; set; }
        public Level26 level { get; set; }
        public Srcnodeid58 srcNodeId { get; set; }
        public Srcinstanceid58 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported58
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version58
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security58
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone58
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter58
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level26
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid58
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid58
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _388
    {
        public string name { get; set; }
        public Data70 data { get; set; }
    }

    public class Data70
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported59 supported { get; set; }
        public Version59 version { get; set; }
        public Security59 security { get; set; }
        public Interviewdone59 interviewDone { get; set; }
        public Interviewcounter59 interviewCounter { get; set; }
        public Level27 level { get; set; }
        public Startchange8 startChange { get; set; }
        public Stopchange8 stopChange { get; set; }
        public Prevlevel8 prevLevel { get; set; }
        public Srcnodeid59 srcNodeId { get; set; }
        public Srcinstanceid59 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported59
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version59
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security59
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone59
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter59
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level27
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid59
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid59
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _438
    {
        public string name { get; set; }
        public Data71 data { get; set; }
    }

    public class Data71
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported60 supported { get; set; }
        public Version60 version { get; set; }
        public Security60 security { get; set; }
        public Interviewdone60 interviewDone { get; set; }
        public Interviewcounter60 interviewCounter { get; set; }
        public Currentscene16 currentScene { get; set; }
        public Dimmingduration8 dimmingDuration { get; set; }
        public Srcnodeid60 srcNodeId { get; set; }
        public Srcinstanceid60 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported60
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version60
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security60
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone60
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter60
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid60
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid60
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _918
    {
        public string name { get; set; }
        public Data72 data { get; set; }
    }

    public class Data72
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported61 supported { get; set; }
        public Version61 version { get; set; }
        public Security61 security { get; set; }
        public Interviewdone61 interviewDone { get; set; }
        public Interviewcounter61 interviewCounter { get; set; }
        public Maxscenes8 maxScenes { get; set; }
        public Currentscene17 currentScene { get; set; }
        public Keyattribute8 keyAttribute { get; set; }
        public Srcnodeid61 srcNodeId { get; set; }
        public Srcinstanceid61 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported61
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version61
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security61
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone61
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter61
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene17
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute8
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid61
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid61
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9
    {
        public Data73 data { get; set; }
        public Commandclasses9 commandClasses { get; set; }
    }

    public class Data73
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic11 dynamic { get; set; }
        public Generictype10 genericType { get; set; }
        public Specifictype10 specificType { get; set; }
        public Nodeinfoframe10 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic11
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype10
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype10
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe10
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses9
    {
        public _329 _32 { get; set; }
        public _379 _37 { get; set; }
        public _389 _38 { get; set; }
        public _439 _43 { get; set; }
        public _919 _91 { get; set; }
    }

    public class _329
    {
        public string name { get; set; }
        public Data74 data { get; set; }
    }

    public class Data74
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported62 supported { get; set; }
        public Version62 version { get; set; }
        public Security62 security { get; set; }
        public Interviewdone62 interviewDone { get; set; }
        public Interviewcounter62 interviewCounter { get; set; }
        public Level28 level { get; set; }
        public Srcnodeid62 srcNodeId { get; set; }
        public Srcinstanceid62 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported62
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version62
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security62
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone62
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter62
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level28
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid62
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid62
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _379
    {
        public string name { get; set; }
        public Data75 data { get; set; }
    }

    public class Data75
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported63 supported { get; set; }
        public Version63 version { get; set; }
        public Security63 security { get; set; }
        public Interviewdone63 interviewDone { get; set; }
        public Interviewcounter63 interviewCounter { get; set; }
        public Level29 level { get; set; }
        public Srcnodeid63 srcNodeId { get; set; }
        public Srcinstanceid63 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported63
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version63
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security63
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone63
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter63
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level29
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid63
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid63
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _389
    {
        public string name { get; set; }
        public Data76 data { get; set; }
    }

    public class Data76
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported64 supported { get; set; }
        public Version64 version { get; set; }
        public Security64 security { get; set; }
        public Interviewdone64 interviewDone { get; set; }
        public Interviewcounter64 interviewCounter { get; set; }
        public Level30 level { get; set; }
        public Startchange9 startChange { get; set; }
        public Stopchange9 stopChange { get; set; }
        public Prevlevel9 prevLevel { get; set; }
        public Srcnodeid64 srcNodeId { get; set; }
        public Srcinstanceid64 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported64
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version64
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security64
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone64
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter64
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level30
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid64
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid64
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _439
    {
        public string name { get; set; }
        public Data77 data { get; set; }
    }

    public class Data77
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported65 supported { get; set; }
        public Version65 version { get; set; }
        public Security65 security { get; set; }
        public Interviewdone65 interviewDone { get; set; }
        public Interviewcounter65 interviewCounter { get; set; }
        public Currentscene18 currentScene { get; set; }
        public Dimmingduration9 dimmingDuration { get; set; }
        public Srcnodeid65 srcNodeId { get; set; }
        public Srcinstanceid65 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported65
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version65
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security65
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone65
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter65
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene18
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid65
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid65
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _919
    {
        public string name { get; set; }
        public Data78 data { get; set; }
    }

    public class Data78
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported66 supported { get; set; }
        public Version66 version { get; set; }
        public Security66 security { get; set; }
        public Interviewdone66 interviewDone { get; set; }
        public Interviewcounter66 interviewCounter { get; set; }
        public Maxscenes9 maxScenes { get; set; }
        public Currentscene19 currentScene { get; set; }
        public Keyattribute9 keyAttribute { get; set; }
        public Srcnodeid66 srcNodeId { get; set; }
        public Srcinstanceid66 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported66
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version66
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security66
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone66
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter66
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene19
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute9
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid66
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid66
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _10
    {
        public Data79 data { get; set; }
        public Commandclasses10 commandClasses { get; set; }
    }

    public class Data79
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic12 dynamic { get; set; }
        public Generictype11 genericType { get; set; }
        public Specifictype11 specificType { get; set; }
        public Nodeinfoframe11 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic12
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype11
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype11
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe11
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses10
    {
        public _3210 _32 { get; set; }
        public _3710 _37 { get; set; }
        public _3810 _38 { get; set; }
        public _4310 _43 { get; set; }
        public _9110 _91 { get; set; }
    }

    public class _3210
    {
        public string name { get; set; }
        public Data80 data { get; set; }
    }

    public class Data80
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported67 supported { get; set; }
        public Version67 version { get; set; }
        public Security67 security { get; set; }
        public Interviewdone67 interviewDone { get; set; }
        public Interviewcounter67 interviewCounter { get; set; }
        public Level31 level { get; set; }
        public Srcnodeid67 srcNodeId { get; set; }
        public Srcinstanceid67 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported67
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version67
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security67
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone67
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter67
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level31
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid67
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid67
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3710
    {
        public string name { get; set; }
        public Data81 data { get; set; }
    }

    public class Data81
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported68 supported { get; set; }
        public Version68 version { get; set; }
        public Security68 security { get; set; }
        public Interviewdone68 interviewDone { get; set; }
        public Interviewcounter68 interviewCounter { get; set; }
        public Level32 level { get; set; }
        public Srcnodeid68 srcNodeId { get; set; }
        public Srcinstanceid68 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported68
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version68
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security68
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone68
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter68
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level32
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid68
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid68
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3810
    {
        public string name { get; set; }
        public Data82 data { get; set; }
    }

    public class Data82
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported69 supported { get; set; }
        public Version69 version { get; set; }
        public Security69 security { get; set; }
        public Interviewdone69 interviewDone { get; set; }
        public Interviewcounter69 interviewCounter { get; set; }
        public Level33 level { get; set; }
        public Startchange10 startChange { get; set; }
        public Stopchange10 stopChange { get; set; }
        public Prevlevel10 prevLevel { get; set; }
        public Srcnodeid69 srcNodeId { get; set; }
        public Srcinstanceid69 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported69
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version69
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security69
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone69
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter69
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level33
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid69
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid69
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4310
    {
        public string name { get; set; }
        public Data83 data { get; set; }
    }

    public class Data83
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported70 supported { get; set; }
        public Version70 version { get; set; }
        public Security70 security { get; set; }
        public Interviewdone70 interviewDone { get; set; }
        public Interviewcounter70 interviewCounter { get; set; }
        public Currentscene20 currentScene { get; set; }
        public Dimmingduration10 dimmingDuration { get; set; }
        public Srcnodeid70 srcNodeId { get; set; }
        public Srcinstanceid70 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported70
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version70
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security70
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone70
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter70
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene20
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid70
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid70
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9110
    {
        public string name { get; set; }
        public Data84 data { get; set; }
    }

    public class Data84
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported71 supported { get; set; }
        public Version71 version { get; set; }
        public Security71 security { get; set; }
        public Interviewdone71 interviewDone { get; set; }
        public Interviewcounter71 interviewCounter { get; set; }
        public Maxscenes10 maxScenes { get; set; }
        public Currentscene21 currentScene { get; set; }
        public Keyattribute10 keyAttribute { get; set; }
        public Srcnodeid71 srcNodeId { get; set; }
        public Srcinstanceid71 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported71
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version71
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security71
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone71
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter71
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene21
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute10
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid71
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid71
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _111
    {
        public Data85 data { get; set; }
        public Commandclasses11 commandClasses { get; set; }
    }

    public class Data85
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic13 dynamic { get; set; }
        public Generictype12 genericType { get; set; }
        public Specifictype12 specificType { get; set; }
        public Nodeinfoframe12 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic13
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype12
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype12
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe12
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses11
    {
        public _3211 _32 { get; set; }
        public _3711 _37 { get; set; }
        public _3811 _38 { get; set; }
        public _4311 _43 { get; set; }
        public _9111 _91 { get; set; }
    }

    public class _3211
    {
        public string name { get; set; }
        public Data86 data { get; set; }
    }

    public class Data86
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported72 supported { get; set; }
        public Version72 version { get; set; }
        public Security72 security { get; set; }
        public Interviewdone72 interviewDone { get; set; }
        public Interviewcounter72 interviewCounter { get; set; }
        public Level34 level { get; set; }
        public Srcnodeid72 srcNodeId { get; set; }
        public Srcinstanceid72 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported72
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version72
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security72
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone72
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter72
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level34
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid72
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid72
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3711
    {
        public string name { get; set; }
        public Data87 data { get; set; }
    }

    public class Data87
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported73 supported { get; set; }
        public Version73 version { get; set; }
        public Security73 security { get; set; }
        public Interviewdone73 interviewDone { get; set; }
        public Interviewcounter73 interviewCounter { get; set; }
        public Level35 level { get; set; }
        public Srcnodeid73 srcNodeId { get; set; }
        public Srcinstanceid73 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported73
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version73
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security73
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone73
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter73
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level35
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid73
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid73
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3811
    {
        public string name { get; set; }
        public Data88 data { get; set; }
    }

    public class Data88
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported74 supported { get; set; }
        public Version74 version { get; set; }
        public Security74 security { get; set; }
        public Interviewdone74 interviewDone { get; set; }
        public Interviewcounter74 interviewCounter { get; set; }
        public Level36 level { get; set; }
        public Startchange11 startChange { get; set; }
        public Stopchange11 stopChange { get; set; }
        public Prevlevel11 prevLevel { get; set; }
        public Srcnodeid74 srcNodeId { get; set; }
        public Srcinstanceid74 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported74
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version74
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security74
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone74
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter74
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level36
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid74
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid74
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4311
    {
        public string name { get; set; }
        public Data89 data { get; set; }
    }

    public class Data89
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported75 supported { get; set; }
        public Version75 version { get; set; }
        public Security75 security { get; set; }
        public Interviewdone75 interviewDone { get; set; }
        public Interviewcounter75 interviewCounter { get; set; }
        public Currentscene22 currentScene { get; set; }
        public Dimmingduration11 dimmingDuration { get; set; }
        public Srcnodeid75 srcNodeId { get; set; }
        public Srcinstanceid75 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported75
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version75
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security75
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone75
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter75
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene22
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid75
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid75
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9111
    {
        public string name { get; set; }
        public Data90 data { get; set; }
    }

    public class Data90
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported76 supported { get; set; }
        public Version76 version { get; set; }
        public Security76 security { get; set; }
        public Interviewdone76 interviewDone { get; set; }
        public Interviewcounter76 interviewCounter { get; set; }
        public Maxscenes11 maxScenes { get; set; }
        public Currentscene23 currentScene { get; set; }
        public Keyattribute11 keyAttribute { get; set; }
        public Srcnodeid76 srcNodeId { get; set; }
        public Srcinstanceid76 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported76
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version76
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security76
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone76
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter76
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene23
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute11
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid76
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid76
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _121
    {
        public Data91 data { get; set; }
        public Commandclasses12 commandClasses { get; set; }
    }

    public class Data91
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic14 dynamic { get; set; }
        public Generictype13 genericType { get; set; }
        public Specifictype13 specificType { get; set; }
        public Nodeinfoframe13 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic14
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype13
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype13
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe13
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses12
    {
        public _3212 _32 { get; set; }
        public _3712 _37 { get; set; }
        public _3812 _38 { get; set; }
        public _4312 _43 { get; set; }
        public _9112 _91 { get; set; }
    }

    public class _3212
    {
        public string name { get; set; }
        public Data92 data { get; set; }
    }

    public class Data92
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported77 supported { get; set; }
        public Version77 version { get; set; }
        public Security77 security { get; set; }
        public Interviewdone77 interviewDone { get; set; }
        public Interviewcounter77 interviewCounter { get; set; }
        public Level37 level { get; set; }
        public Srcnodeid77 srcNodeId { get; set; }
        public Srcinstanceid77 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported77
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version77
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security77
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone77
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter77
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level37
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid77
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid77
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3712
    {
        public string name { get; set; }
        public Data93 data { get; set; }
    }

    public class Data93
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported78 supported { get; set; }
        public Version78 version { get; set; }
        public Security78 security { get; set; }
        public Interviewdone78 interviewDone { get; set; }
        public Interviewcounter78 interviewCounter { get; set; }
        public Level38 level { get; set; }
        public Srcnodeid78 srcNodeId { get; set; }
        public Srcinstanceid78 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported78
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version78
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security78
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone78
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter78
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level38
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid78
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid78
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3812
    {
        public string name { get; set; }
        public Data94 data { get; set; }
    }

    public class Data94
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported79 supported { get; set; }
        public Version79 version { get; set; }
        public Security79 security { get; set; }
        public Interviewdone79 interviewDone { get; set; }
        public Interviewcounter79 interviewCounter { get; set; }
        public Level39 level { get; set; }
        public Startchange12 startChange { get; set; }
        public Stopchange12 stopChange { get; set; }
        public Prevlevel12 prevLevel { get; set; }
        public Srcnodeid79 srcNodeId { get; set; }
        public Srcinstanceid79 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported79
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version79
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security79
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone79
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter79
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level39
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid79
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid79
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4312
    {
        public string name { get; set; }
        public Data95 data { get; set; }
    }

    public class Data95
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported80 supported { get; set; }
        public Version80 version { get; set; }
        public Security80 security { get; set; }
        public Interviewdone80 interviewDone { get; set; }
        public Interviewcounter80 interviewCounter { get; set; }
        public Currentscene24 currentScene { get; set; }
        public Dimmingduration12 dimmingDuration { get; set; }
        public Srcnodeid80 srcNodeId { get; set; }
        public Srcinstanceid80 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported80
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version80
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security80
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone80
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter80
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene24
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid80
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid80
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9112
    {
        public string name { get; set; }
        public Data96 data { get; set; }
    }

    public class Data96
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported81 supported { get; set; }
        public Version81 version { get; set; }
        public Security81 security { get; set; }
        public Interviewdone81 interviewDone { get; set; }
        public Interviewcounter81 interviewCounter { get; set; }
        public Maxscenes12 maxScenes { get; set; }
        public Currentscene25 currentScene { get; set; }
        public Keyattribute12 keyAttribute { get; set; }
        public Srcnodeid81 srcNodeId { get; set; }
        public Srcinstanceid81 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported81
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version81
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security81
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone81
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter81
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene25
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute12
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid81
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid81
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _131
    {
        public Data97 data { get; set; }
        public Commandclasses13 commandClasses { get; set; }
    }

    public class Data97
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic15 dynamic { get; set; }
        public Generictype14 genericType { get; set; }
        public Specifictype14 specificType { get; set; }
        public Nodeinfoframe14 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic15
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype14
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype14
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe14
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses13
    {
        public _3213 _32 { get; set; }
        public _3713 _37 { get; set; }
        public _3813 _38 { get; set; }
        public _4313 _43 { get; set; }
        public _9113 _91 { get; set; }
    }

    public class _3213
    {
        public string name { get; set; }
        public Data98 data { get; set; }
    }

    public class Data98
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported82 supported { get; set; }
        public Version82 version { get; set; }
        public Security82 security { get; set; }
        public Interviewdone82 interviewDone { get; set; }
        public Interviewcounter82 interviewCounter { get; set; }
        public Level40 level { get; set; }
        public Srcnodeid82 srcNodeId { get; set; }
        public Srcinstanceid82 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported82
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version82
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security82
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone82
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter82
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level40
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid82
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid82
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3713
    {
        public string name { get; set; }
        public Data99 data { get; set; }
    }

    public class Data99
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported83 supported { get; set; }
        public Version83 version { get; set; }
        public Security83 security { get; set; }
        public Interviewdone83 interviewDone { get; set; }
        public Interviewcounter83 interviewCounter { get; set; }
        public Level41 level { get; set; }
        public Srcnodeid83 srcNodeId { get; set; }
        public Srcinstanceid83 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported83
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version83
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security83
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone83
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter83
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level41
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid83
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid83
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3813
    {
        public string name { get; set; }
        public Data100 data { get; set; }
    }

    public class Data100
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported84 supported { get; set; }
        public Version84 version { get; set; }
        public Security84 security { get; set; }
        public Interviewdone84 interviewDone { get; set; }
        public Interviewcounter84 interviewCounter { get; set; }
        public Level42 level { get; set; }
        public Startchange13 startChange { get; set; }
        public Stopchange13 stopChange { get; set; }
        public Prevlevel13 prevLevel { get; set; }
        public Srcnodeid84 srcNodeId { get; set; }
        public Srcinstanceid84 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported84
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version84
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security84
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone84
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter84
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level42
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid84
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid84
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4313
    {
        public string name { get; set; }
        public Data101 data { get; set; }
    }

    public class Data101
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported85 supported { get; set; }
        public Version85 version { get; set; }
        public Security85 security { get; set; }
        public Interviewdone85 interviewDone { get; set; }
        public Interviewcounter85 interviewCounter { get; set; }
        public Currentscene26 currentScene { get; set; }
        public Dimmingduration13 dimmingDuration { get; set; }
        public Srcnodeid85 srcNodeId { get; set; }
        public Srcinstanceid85 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported85
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version85
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security85
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone85
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter85
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene26
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid85
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid85
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9113
    {
        public string name { get; set; }
        public Data102 data { get; set; }
    }

    public class Data102
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported86 supported { get; set; }
        public Version86 version { get; set; }
        public Security86 security { get; set; }
        public Interviewdone86 interviewDone { get; set; }
        public Interviewcounter86 interviewCounter { get; set; }
        public Maxscenes13 maxScenes { get; set; }
        public Currentscene27 currentScene { get; set; }
        public Keyattribute13 keyAttribute { get; set; }
        public Srcnodeid86 srcNodeId { get; set; }
        public Srcinstanceid86 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported86
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version86
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security86
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone86
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter86
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene27
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute13
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid86
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid86
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _141
    {
        public Data103 data { get; set; }
        public Commandclasses14 commandClasses { get; set; }
    }

    public class Data103
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic16 dynamic { get; set; }
        public Generictype15 genericType { get; set; }
        public Specifictype15 specificType { get; set; }
        public Nodeinfoframe15 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic16
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype15
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype15
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe15
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses14
    {
        public _3214 _32 { get; set; }
        public _3714 _37 { get; set; }
        public _3814 _38 { get; set; }
        public _4314 _43 { get; set; }
        public _9114 _91 { get; set; }
    }

    public class _3214
    {
        public string name { get; set; }
        public Data104 data { get; set; }
    }

    public class Data104
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported87 supported { get; set; }
        public Version87 version { get; set; }
        public Security87 security { get; set; }
        public Interviewdone87 interviewDone { get; set; }
        public Interviewcounter87 interviewCounter { get; set; }
        public Level43 level { get; set; }
        public Srcnodeid87 srcNodeId { get; set; }
        public Srcinstanceid87 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported87
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version87
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security87
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone87
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter87
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level43
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid87
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid87
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3714
    {
        public string name { get; set; }
        public Data105 data { get; set; }
    }

    public class Data105
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported88 supported { get; set; }
        public Version88 version { get; set; }
        public Security88 security { get; set; }
        public Interviewdone88 interviewDone { get; set; }
        public Interviewcounter88 interviewCounter { get; set; }
        public Level44 level { get; set; }
        public Srcnodeid88 srcNodeId { get; set; }
        public Srcinstanceid88 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported88
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version88
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security88
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone88
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter88
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level44
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid88
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid88
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3814
    {
        public string name { get; set; }
        public Data106 data { get; set; }
    }

    public class Data106
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported89 supported { get; set; }
        public Version89 version { get; set; }
        public Security89 security { get; set; }
        public Interviewdone89 interviewDone { get; set; }
        public Interviewcounter89 interviewCounter { get; set; }
        public Level45 level { get; set; }
        public Startchange14 startChange { get; set; }
        public Stopchange14 stopChange { get; set; }
        public Prevlevel14 prevLevel { get; set; }
        public Srcnodeid89 srcNodeId { get; set; }
        public Srcinstanceid89 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported89
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version89
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security89
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone89
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter89
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level45
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid89
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid89
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4314
    {
        public string name { get; set; }
        public Data107 data { get; set; }
    }

    public class Data107
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported90 supported { get; set; }
        public Version90 version { get; set; }
        public Security90 security { get; set; }
        public Interviewdone90 interviewDone { get; set; }
        public Interviewcounter90 interviewCounter { get; set; }
        public Currentscene28 currentScene { get; set; }
        public Dimmingduration14 dimmingDuration { get; set; }
        public Srcnodeid90 srcNodeId { get; set; }
        public Srcinstanceid90 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported90
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version90
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security90
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone90
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter90
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene28
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid90
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid90
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9114
    {
        public string name { get; set; }
        public Data108 data { get; set; }
    }

    public class Data108
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported91 supported { get; set; }
        public Version91 version { get; set; }
        public Security91 security { get; set; }
        public Interviewdone91 interviewDone { get; set; }
        public Interviewcounter91 interviewCounter { get; set; }
        public Maxscenes14 maxScenes { get; set; }
        public Currentscene29 currentScene { get; set; }
        public Keyattribute14 keyAttribute { get; set; }
        public Srcnodeid91 srcNodeId { get; set; }
        public Srcinstanceid91 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported91
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version91
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security91
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone91
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter91
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene29
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute14
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid91
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid91
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _15
    {
        public Data109 data { get; set; }
        public Commandclasses15 commandClasses { get; set; }
    }

    public class Data109
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic17 dynamic { get; set; }
        public Generictype16 genericType { get; set; }
        public Specifictype16 specificType { get; set; }
        public Nodeinfoframe16 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic17
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype16
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype16
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe16
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses15
    {
        public _3215 _32 { get; set; }
        public _3715 _37 { get; set; }
        public _3815 _38 { get; set; }
        public _4315 _43 { get; set; }
        public _9115 _91 { get; set; }
    }

    public class _3215
    {
        public string name { get; set; }
        public Data110 data { get; set; }
    }

    public class Data110
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported92 supported { get; set; }
        public Version92 version { get; set; }
        public Security92 security { get; set; }
        public Interviewdone92 interviewDone { get; set; }
        public Interviewcounter92 interviewCounter { get; set; }
        public Level46 level { get; set; }
        public Srcnodeid92 srcNodeId { get; set; }
        public Srcinstanceid92 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported92
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version92
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security92
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone92
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter92
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level46
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid92
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid92
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3715
    {
        public string name { get; set; }
        public Data111 data { get; set; }
    }

    public class Data111
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported93 supported { get; set; }
        public Version93 version { get; set; }
        public Security93 security { get; set; }
        public Interviewdone93 interviewDone { get; set; }
        public Interviewcounter93 interviewCounter { get; set; }
        public Level47 level { get; set; }
        public Srcnodeid93 srcNodeId { get; set; }
        public Srcinstanceid93 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported93
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version93
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security93
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone93
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter93
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level47
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid93
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid93
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3815
    {
        public string name { get; set; }
        public Data112 data { get; set; }
    }

    public class Data112
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported94 supported { get; set; }
        public Version94 version { get; set; }
        public Security94 security { get; set; }
        public Interviewdone94 interviewDone { get; set; }
        public Interviewcounter94 interviewCounter { get; set; }
        public Level48 level { get; set; }
        public Startchange15 startChange { get; set; }
        public Stopchange15 stopChange { get; set; }
        public Prevlevel15 prevLevel { get; set; }
        public Srcnodeid94 srcNodeId { get; set; }
        public Srcinstanceid94 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported94
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version94
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security94
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone94
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter94
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level48
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid94
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid94
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4315
    {
        public string name { get; set; }
        public Data113 data { get; set; }
    }

    public class Data113
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported95 supported { get; set; }
        public Version95 version { get; set; }
        public Security95 security { get; set; }
        public Interviewdone95 interviewDone { get; set; }
        public Interviewcounter95 interviewCounter { get; set; }
        public Currentscene30 currentScene { get; set; }
        public Dimmingduration15 dimmingDuration { get; set; }
        public Srcnodeid95 srcNodeId { get; set; }
        public Srcinstanceid95 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported95
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version95
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security95
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone95
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter95
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene30
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid95
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid95
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9115
    {
        public string name { get; set; }
        public Data114 data { get; set; }
    }

    public class Data114
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported96 supported { get; set; }
        public Version96 version { get; set; }
        public Security96 security { get; set; }
        public Interviewdone96 interviewDone { get; set; }
        public Interviewcounter96 interviewCounter { get; set; }
        public Maxscenes15 maxScenes { get; set; }
        public Currentscene31 currentScene { get; set; }
        public Keyattribute15 keyAttribute { get; set; }
        public Srcnodeid96 srcNodeId { get; set; }
        public Srcinstanceid96 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported96
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version96
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security96
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone96
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter96
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene31
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute15
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid96
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid96
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _16
    {
        public Data115 data { get; set; }
        public Commandclasses16 commandClasses { get; set; }
    }

    public class Data115
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic18 dynamic { get; set; }
        public Generictype17 genericType { get; set; }
        public Specifictype17 specificType { get; set; }
        public Nodeinfoframe17 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic18
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype17
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype17
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe17
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses16
    {
        public _3216 _32 { get; set; }
        public _3716 _37 { get; set; }
        public _3816 _38 { get; set; }
        public _4316 _43 { get; set; }
        public _9116 _91 { get; set; }
    }

    public class _3216
    {
        public string name { get; set; }
        public Data116 data { get; set; }
    }

    public class Data116
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported97 supported { get; set; }
        public Version97 version { get; set; }
        public Security97 security { get; set; }
        public Interviewdone97 interviewDone { get; set; }
        public Interviewcounter97 interviewCounter { get; set; }
        public Level49 level { get; set; }
        public Srcnodeid97 srcNodeId { get; set; }
        public Srcinstanceid97 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported97
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version97
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security97
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone97
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter97
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level49
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid97
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid97
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3716
    {
        public string name { get; set; }
        public Data117 data { get; set; }
    }

    public class Data117
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported98 supported { get; set; }
        public Version98 version { get; set; }
        public Security98 security { get; set; }
        public Interviewdone98 interviewDone { get; set; }
        public Interviewcounter98 interviewCounter { get; set; }
        public Level50 level { get; set; }
        public Srcnodeid98 srcNodeId { get; set; }
        public Srcinstanceid98 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported98
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version98
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security98
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone98
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter98
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level50
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid98
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid98
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3816
    {
        public string name { get; set; }
        public Data118 data { get; set; }
    }

    public class Data118
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported99 supported { get; set; }
        public Version99 version { get; set; }
        public Security99 security { get; set; }
        public Interviewdone99 interviewDone { get; set; }
        public Interviewcounter99 interviewCounter { get; set; }
        public Level51 level { get; set; }
        public Startchange16 startChange { get; set; }
        public Stopchange16 stopChange { get; set; }
        public Prevlevel16 prevLevel { get; set; }
        public Srcnodeid99 srcNodeId { get; set; }
        public Srcinstanceid99 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported99
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version99
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security99
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone99
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter99
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level51
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Startchange16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Stopchange16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Prevlevel16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid99
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid99
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _4316
    {
        public string name { get; set; }
        public Data119 data { get; set; }
    }

    public class Data119
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported100 supported { get; set; }
        public Version100 version { get; set; }
        public Security100 security { get; set; }
        public Interviewdone100 interviewDone { get; set; }
        public Interviewcounter100 interviewCounter { get; set; }
        public Currentscene32 currentScene { get; set; }
        public Dimmingduration16 dimmingDuration { get; set; }
        public Srcnodeid100 srcNodeId { get; set; }
        public Srcinstanceid100 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported100
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version100
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security100
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone100
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter100
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene32
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dimmingduration16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid100
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid100
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _9116
    {
        public string name { get; set; }
        public Data120 data { get; set; }
    }

    public class Data120
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported101 supported { get; set; }
        public Version101 version { get; set; }
        public Security101 security { get; set; }
        public Interviewdone101 interviewDone { get; set; }
        public Interviewcounter101 interviewCounter { get; set; }
        public Maxscenes16 maxScenes { get; set; }
        public Currentscene33 currentScene { get; set; }
        public Keyattribute16 keyAttribute { get; set; }
        public Srcnodeid101 srcNodeId { get; set; }
        public Srcinstanceid101 srcInstanceId { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported101
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version101
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security101
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone101
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter101
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Maxscenes16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Currentscene33
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keyattribute16
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcnodeid101
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Srcinstanceid101
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _21
    {
        public Data121 data { get; set; }
        public Instances1 instances { get; set; }
    }

    public class Data121
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Basictype1 basicType { get; set; }
        public Generictype18 genericType { get; set; }
        public Specifictype18 specificType { get; set; }
        public Infoprotocolspecific1 infoProtocolSpecific { get; set; }
        public Devicetypestring1 deviceTypeString { get; set; }
        public Isvirtual1 isVirtual { get; set; }
        public Islistening1 isListening { get; set; }
        public Isrouting1 isRouting { get; set; }
        public Isawake1 isAwake { get; set; }
        public Optional1 optional { get; set; }
        public Isfailed1 isFailed { get; set; }
        public Sensor2501 sensor250 { get; set; }
        public Sensor10001 sensor1000 { get; set; }
        public Neighbours1 neighbours { get; set; }
        public Manufacturerid2 manufacturerId { get; set; }
        public Vendorstring1 vendorString { get; set; }
        public Manufacturerproducttype2 manufacturerProductType { get; set; }
        public Manufacturerproductid2 manufacturerProductId { get; set; }
        public Zwlib3 ZWLib { get; set; }
        public Zwprotocolmajor2 ZWProtocolMajor { get; set; }
        public Zwprotocolminor2 ZWProtocolMinor { get; set; }
        public SDK3 SDK { get; set; }
        public Applicationmajor2 applicationMajor { get; set; }
        public Applicationminor2 applicationMinor { get; set; }
        public Nodeinfoframe18 nodeInfoFrame { get; set; }
        public Zddxmlfile1 ZDDXMLFile { get; set; }
        public Lastsend1 lastSend { get; set; }
        public Lastnonceget1 lastNonceGet { get; set; }
        public Lastreceived1 lastReceived { get; set; }
        public Failurecount1 failureCount { get; set; }
        public Keepawake1 keepAwake { get; set; }
        public Queuelength1 queueLength { get; set; }
        public Givenname1 givenName { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Basictype1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype18
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype18
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Infoprotocolspecific1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Devicetypestring1
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isvirtual1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Islistening1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isrouting1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isawake1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Optional1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Isfailed1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Sensor2501
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Sensor10001
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Neighbours1
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerid2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Vendorstring1
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerproducttype2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerproductid2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwlib3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolmajor2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolminor2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class SDK3
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationmajor2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationminor2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe18
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zddxmlfile1
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastsend1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastnonceget1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Lastreceived1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Failurecount1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Keepawake1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Queuelength1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Givenname1
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Instances1
    {
        [JsonProperty("0")]
        public _01 _0 { get; set; }
    }

    public class _01
    {
        public Data122 data { get; set; }
        public Commandclasses17 commandClasses { get; set; }
    }

    public class Data122
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Dynamic19 dynamic { get; set; }
        public Generictype19 genericType { get; set; }
        public Specifictype19 specificType { get; set; }
        public Nodeinfoframe19 nodeInfoFrame { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic19
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Generictype19
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specifictype19
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodeinfoframe19
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commandclasses17
    {
        [JsonProperty("32")]
        public _3217 _32 { get; set; }
        public _3717 _37 { get; set; }
        public _39 _39 { get; set; }
        public _891 _89 { get; set; }
        public _903 _90 { get; set; }
        public _941 _94 { get; set; }
        public _112 _112 { get; set; }
        public _1141 _114 { get; set; }
        public _1151 _115 { get; set; }
        public _122 _122 { get; set; }
        public _1331 _133 { get; set; }
        public _1341 _134 { get; set; }
    }

    public class _3217
    {
        public string name { get; set; }
        public Data123 data { get; set; }
    }

    public class Data123
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported102 supported { get; set; }
        public Version102 version { get; set; }
        public Security102 security { get; set; }
        public Interviewdone102 interviewDone { get; set; }
        public Interviewcounter102 interviewCounter { get; set; }
        public Level52 level { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported102
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version102
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security102
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone102
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter102
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level52
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3717
    {
        public string name { get; set; }
        public Data124 data { get; set; }
    }

    public class Data124
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported103 supported { get; set; }
        public Version103 version { get; set; }
        public Security103 security { get; set; }
        public Interviewdone103 interviewDone { get; set; }
        public Interviewcounter103 interviewCounter { get; set; }
        public Level53 level { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported103
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version103
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security103
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone103
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter103
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level53
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _39
    {
        public string name { get; set; }
        public Data125 data { get; set; }
    }

    public class Data125
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported104 supported { get; set; }
        public Version104 version { get; set; }
        public Security104 security { get; set; }
        public Interviewdone104 interviewDone { get; set; }
        public Interviewcounter104 interviewCounter { get; set; }
        public Mode1 mode { get; set; }
        public Onoff onOff { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported104
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version104
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security104
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone104
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter104
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Mode1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Onoff
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _891
    {
        public string name { get; set; }
        public Data126 data { get; set; }
    }

    public class Data126
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported105 supported { get; set; }
        public Version105 version { get; set; }
        public Security105 security { get; set; }
        public Interviewdone105 interviewDone { get; set; }
        public Interviewcounter105 interviewCounter { get; set; }
        public Dynamic20 dynamic { get; set; }
        public _17 _1 { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported105
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version105
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security105
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone105
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter105
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Dynamic20
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _17
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Groupname1 groupName { get; set; }
        public Mode2 mode { get; set; }
        public Profile1 profile { get; set; }
        public Eventcode1 eventCode { get; set; }
        public Commands1 commands { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Groupname1
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Mode2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Profile1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Eventcode1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Commands1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public _902 _90 { get; set; }
        public _3718 _37 { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _902
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _3718
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _903
    {
        public string name { get; set; }
        public Data127 data { get; set; }
    }

    public class Data127
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported106 supported { get; set; }
        public Version106 version { get; set; }
        public Security106 security { get; set; }
        public Interviewdone106 interviewDone { get; set; }
        public Interviewcounter106 interviewCounter { get; set; }
        public Reset1 reset { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported106
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version106
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security106
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone106
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter106
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Reset1
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _941
    {
        public string name { get; set; }
        public Data128 data { get; set; }
    }

    public class Data128
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported107 supported { get; set; }
        public Version107 version { get; set; }
        public Security107 security { get; set; }
        public Interviewdone107 interviewDone { get; set; }
        public Interviewcounter107 interviewCounter { get; set; }
        public Plusversion1 plusVersion { get; set; }
        public Roletype1 roleType { get; set; }
        public Nodetype1 nodeType { get; set; }
        public Installericon1 installerIcon { get; set; }
        public Usericon1 userIcon { get; set; }
        public Roletypestring1 roleTypeString { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported107
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version107
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security107
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone107
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter107
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Plusversion1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Roletype1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodetype1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Installericon1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Usericon1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Roletypestring1
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _112
    {
        public string name { get; set; }
        public Data129 data { get; set; }
    }

    public class Data129
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported108 supported { get; set; }
        public Version108 version { get; set; }
        public Security108 security { get; set; }
        public Interviewdone108 interviewDone { get; set; }
        public Interviewcounter108 interviewCounter { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported108
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version108
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security108
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone108
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter108
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _1141
    {
        public string name { get; set; }
        public Data130 data { get; set; }
    }

    public class Data130
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported109 supported { get; set; }
        public Version109 version { get; set; }
        public Security109 security { get; set; }
        public Interviewdone109 interviewDone { get; set; }
        public Interviewcounter109 interviewCounter { get; set; }
        public Vendorid1 vendorId { get; set; }
        public Vendor2 vendor { get; set; }
        public Productid1 productId { get; set; }
        public Producttype1 productType { get; set; }
        public Serialnumber1 serialNumber { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported109
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version109
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security109
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone109
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter109
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Vendorid1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Vendor2
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Productid1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Producttype1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Serialnumber1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _1151
    {
        public string name { get; set; }
        public Data131 data { get; set; }
    }

    public class Data131
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported110 supported { get; set; }
        public Version110 version { get; set; }
        public Security110 security { get; set; }
        public Interviewdone110 interviewDone { get; set; }
        public Interviewcounter110 interviewCounter { get; set; }
        public Level54 level { get; set; }
        public Timeout1 timeout { get; set; }
        public _18 _1 { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported110
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version110
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security110
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone110
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter110
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Level54
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Timeout1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _18
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Status status { get; set; }
        public Totalframes totalFrames { get; set; }
        public Acknowledgedframes acknowledgedFrames { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Status
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Totalframes
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Acknowledgedframes
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _122
    {
        public string name { get; set; }
        public Data132 data { get; set; }
    }

    public class Data132
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported111 supported { get; set; }
        public Version111 version { get; set; }
        public Security111 security { get; set; }
        public Interviewdone111 interviewDone { get; set; }
        public Interviewcounter111 interviewCounter { get; set; }
        public Manufacturerid3 manufacturerId { get; set; }
        public Firmwareid firmwareId { get; set; }
        public Checksum checksum { get; set; }
        public Upgradeable upgradeable { get; set; }
        public Fragmentsize fragmentSize { get; set; }
        public Firmwarecount1 firmwareCount { get; set; }
        public Fragmenttransmitted fragmentTransmitted { get; set; }
        public Fragmentcount fragmentCount { get; set; }
        public Updatestatus updateStatus { get; set; }
        public Waittime waitTime { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported111
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version111
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security111
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone111
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter111
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Manufacturerid3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Firmwareid
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Checksum
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Upgradeable
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Fragmentsize
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Firmwarecount1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Fragmenttransmitted
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Fragmentcount
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Updatestatus
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Waittime
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _1331
    {
        public string name { get; set; }
        public Data133 data { get; set; }
    }

    public class Data133
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported112 supported { get; set; }
        public Version112 version { get; set; }
        public Security112 security { get; set; }
        public Interviewdone112 interviewDone { get; set; }
        public Interviewcounter112 interviewCounter { get; set; }
        public Groups2 groups { get; set; }
        public Specificgroup1 specificGroup { get; set; }
        public _19 _1 { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported112
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version112
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security112
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone112
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter112
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Groups2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Specificgroup1
    {
        public Value value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _19
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Max2 max { get; set; }
        public Nodes1 nodes { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Max2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Nodes1
    {
        public int[] value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class _1341
    {
        public string name { get; set; }
        public Data134 data { get; set; }
    }

    public class Data134
    {
        public Value value { get; set; }
        public string type { get; set; }
        public Supported113 supported { get; set; }
        public Version113 version { get; set; }
        public Security113 security { get; set; }
        public Interviewdone113 interviewDone { get; set; }
        public Interviewcounter113 interviewCounter { get; set; }
        public Zwlib4 ZWLib { get; set; }
        public Zwprotocolmajor3 ZWProtocolMajor { get; set; }
        public Zwprotocolminor3 ZWProtocolMinor { get; set; }
        public SDK4 SDK { get; set; }
        public Applicationmajor3 applicationMajor { get; set; }
        public Applicationminor3 applicationMinor { get; set; }
        public Hardwareversion1 hardwareVersion { get; set; }
        public Firmwarecount2 firmwareCount { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Supported113
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Version113
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Security113
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewdone113
    {
        public bool value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Interviewcounter113
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwlib4
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolmajor3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Zwprotocolminor3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class SDK4
    {
        public string value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationmajor3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Applicationminor3
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Hardwareversion1
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Firmwarecount2
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

    public class Value
    {
        public int value { get; set; }
        public string type { get; set; }
        public int invalidateTime { get; set; }
        public int updateTime { get; set; }
    }

}
