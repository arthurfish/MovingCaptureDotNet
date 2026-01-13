using MvCameraControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCaptureDotNet.Hardware.Utils
{
    static class CameraErrorInfo
    {
        public static void infoCameraError(Int32 ret)
        {
            if (!(ret == MvError.MV_OK))
            {
                Console.WriteLine($"Camera: Error. {getErrorInfo((UInt32)ret)}");
            }
        }
        public static string getErrorInfo(UInt32 ret)
        {
            switch (ret)
            {
                // 基础错误码
                case 0x00000000: return "成功，无错误";
                case 0x80000000: return "错误或无效的句柄";
                case 0x80000001: return "不支持的功能";
                case 0x80000002: return "缓存已满";
                case 0x80000003: return "函数调用顺序错误";
                case 0x80000004: return "错误的参数";
                case 0x80000006: return "资源申请失败";
                case 0x80000007: return "无数据";
                case 0x80000008: return "前置条件有误，或运行环境已发生变化";
                case 0x80000009: return "版本不匹配";
                case 0x8000000A: return "传入的内存空间不足";
                case 0x8000000B: return "异常图像，可能是丢包导致图像不完整";
                case 0x8000000C: return "动态导入DLL失败";
                case 0x8000000D: return "没有可输出的缓存";
                case 0x8000000E: return "加密错误";
                case 0x800000FF: return "未知的错误";

                // GenICam错误
                case 0x80000100: return "通用错误";
                case 0x80000101: return "参数非法";
                case 0x80000102: return "值超出范围";
                case 0x80000103: return "属性错误";
                case 0x80000104: return "运行环境有问题";
                case 0x80000105: return "逻辑错误";
                case 0x80000106: return "节点访问条件有误";
                case 0x80000107: return "超时";
                case 0x80000108: return "转换异常";
                case 0x800001FF: return "GenICam未知错误";

                // 设备错误
                case 0x80000200: return "命令不被设备支持";
                case 0x80000201: return "访问的目标地址不存在";
                case 0x80000202: return "目标地址不可写";
                case 0x80000203: return "设备无访问权限";
                case 0x80000204: return "设备忙，或网络断开";
                case 0x80000205: return "网络包数据错误";
                case 0x80000206: return "网络相关错误";
                case 0x80000221: return "设备IP冲突";

                // USB错误
                case 0x80000300: return "读USB出错";
                case 0x80000301: return "写USB出错";
                case 0x80000302: return "设备异常";
                case 0x80000303: return "GenICam相关错误";
                case 0x80000304: return "带宽不足";
                case 0x80000305: return "驱动不匹配或者未装驱动";
                case 0x800003FF: return "USB未知的错误";

                // 算法错误
                case 0x10000000: return "不确定类型错误";
                case 0x10000001: return "能力集中存在无效参数";
                case 0x10000002: return "内存地址为空";
                case 0x10000003: return "内存对齐不满足要求";
                case 0x10000004: return "内存空间大小不够";
                case 0x10000014: return "函数参数指针为空";
                case 0x10000015: return "超过限定的最大内存";
                case 0x1000001D: return "警告";
                case 0x1000001E: return "算法库超时";

                // 未知错误
                default:
                    return string.Format("未定义的错误码: 0x{0:X8}", ret);
            }
        }
    }
}
