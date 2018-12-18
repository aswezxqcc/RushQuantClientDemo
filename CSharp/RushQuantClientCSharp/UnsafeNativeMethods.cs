using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RushQuant.Clients
{
    internal static class UnsafeNativeMethods
    {
        private static bool __is64bit = IntPtr.Size == sizeof(Int64);

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_initialize")]
        private static extern int rushquant_initialize32(string pUsername, byte[] pKey);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_initialize")]
        private static extern int rushquant_initialize64(string pUsername, byte[] pKey);
        internal static int rushquant_initialize(string pUsername, byte[] pKey)
        {
            if (__is64bit)
                return rushquant_initialize64(pUsername, pKey);
            else
                return rushquant_initialize32(pUsername, pKey);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_free")]
        private static extern void rushquant_free32(IntPtr pointer);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_free")]
        private static extern void rushquant_free64(IntPtr pointer);
        internal static void rushquant_free(IntPtr pointer)
        {
            if (__is64bit)
                rushquant_free64(pointer);
            else
                rushquant_free32(pointer);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_dispose")]
        private static extern int rushquant_dispose32();
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_dispose")]
        private static extern int rushquant_dispose64();
        internal static int rushquant_dispose()
        {
            if (__is64bit)
                return rushquant_dispose64();
            else
                return rushquant_dispose32();
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_GetAccountList")]
        private static extern int rushquant_trade_GetAccountList32(IntPtr pointer);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_GetAccountList")]
        private static extern int rushquant_trade_GetAccountList64(IntPtr pointer);
        internal static int rushquant_trade_GetAccountList(IntPtr pointer)
        {
            if (__is64bit)
                return rushquant_trade_GetAccountList64(pointer);
            else
                return rushquant_trade_GetAccountList32(pointer);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_Reset")]
        private static extern int rushquant_trade_Reset32(int accountId);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_Reset")]
        private static extern int rushquant_trade_Reset64(int accountId);
        internal static int rushquant_trade_Reset(int accountId)
        {
            if (__is64bit)
                return rushquant_trade_Reset64(accountId);
            else
                return rushquant_trade_Reset32(accountId);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_NextId")]
        private static extern int rushquant_trade_NextId32(int accountId);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_NextId")]
        private static extern int rushquant_trade_NextId64(int accountId);
        internal static int rushquant_trade_NextId(int accountId)
        {
            if (__is64bit)
                return rushquant_trade_NextId64(accountId);
            else
                return rushquant_trade_NextId32(accountId);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_Login")]
        private static extern int rushquant_trade_Login32(int accountId, IntPtr input, IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_Login")]
        private static extern int rushquant_trade_Login64(int accountId, IntPtr input, IntPtr output);
        internal static int rushquant_trade_Login(int accountId, IntPtr input, IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_Login64(accountId, input, output);
            else
                return rushquant_trade_Login32(accountId, input, output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QueryTickData")]
        private static extern int rushquant_trade_QueryTickData32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QueryTickData")]
        private static extern int rushquant_trade_QueryTickData64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QueryTickData(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QueryTickData64(accountId, input, ref output);
            else
                return rushquant_trade_QueryTickData32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QueryStockholderInfo")]
        private static extern int rushquant_trade_QueryStockholderInfo32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QueryStockholderInfo")]
        private static extern int rushquant_trade_QueryStockholderInfo64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QueryStockholderInfo(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QueryStockholderInfo64(accountId, input, ref output);
            else
                return rushquant_trade_QueryStockholderInfo32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QuerySecurityCapitalInfo")]
        private static extern int rushquant_trade_QuerySecurityCapitalInfo32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QuerySecurityCapitalInfo")]
        private static extern int rushquant_trade_QuerySecurityCapitalInfo64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QuerySecurityCapitalInfo(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QuerySecurityCapitalInfo64(accountId, input, ref output);
            else
                return rushquant_trade_QuerySecurityCapitalInfo32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QuerySecurityPositionInfo")]
        private static extern int rushquant_trade_QuerySecurityPositionInfo32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QuerySecurityPositionInfo")]
        private static extern int rushquant_trade_QuerySecurityPositionInfo64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QuerySecurityPositionInfo(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QuerySecurityPositionInfo64(accountId, input, ref output);
            else
                return rushquant_trade_QuerySecurityPositionInfo32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QuerySecurityOrderEvaluation")]
        private static extern int rushquant_trade_QuerySecurityOrderEvaluation32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QuerySecurityOrderEvaluation")]
        private static extern int rushquant_trade_QuerySecurityOrderEvaluation64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QuerySecurityOrderEvaluation(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QuerySecurityOrderEvaluation64(accountId, input, ref output);
            else
                return rushquant_trade_QuerySecurityOrderEvaluation32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QuerySecurityIntradayOrder")]
        private static extern int rushquant_trade_QuerySecurityIntradayOrder32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QuerySecurityIntradayOrder")]
        private static extern int rushquant_trade_QuerySecurityIntradayOrder64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QuerySecurityIntradayOrder(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QuerySecurityIntradayOrder64(accountId, input, ref output);
            else
                return rushquant_trade_QuerySecurityIntradayOrder32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QuerySecurityHistoricalOrder")]
        private static extern int rushquant_trade_QuerySecurityHistoricalOrder32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QuerySecurityHistoricalOrder")]
        private static extern int rushquant_trade_QuerySecurityHistoricalOrder64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QuerySecurityHistoricalOrder(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QuerySecurityHistoricalOrder64(accountId, input, ref output);
            else
                return rushquant_trade_QuerySecurityHistoricalOrder32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QuerySecurityIntradayDeal")]
        private static extern int rushquant_trade_QuerySecurityIntradayDeal32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QuerySecurityIntradayDeal")]
        private static extern int rushquant_trade_QuerySecurityIntradayDeal64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QuerySecurityIntradayDeal(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QuerySecurityIntradayDeal64(accountId, input, ref output);
            else
                return rushquant_trade_QuerySecurityIntradayDeal32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_QuerySecurityHistoricalDeal")]
        private static extern int rushquant_trade_QuerySecurityHistoricalDeal32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_QuerySecurityHistoricalDeal")]
        private static extern int rushquant_trade_QuerySecurityHistoricalDeal64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_QuerySecurityHistoricalDeal(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_QuerySecurityHistoricalDeal64(accountId, input, ref output);
            else
                return rushquant_trade_QuerySecurityHistoricalDeal32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_PostSecuritySubmitOrder")]
        private static extern int rushquant_trade_PostSecuritySubmitOrder32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_PostSecuritySubmitOrder")]
        private static extern int rushquant_trade_PostSecuritySubmitOrder64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_PostSecuritySubmitOrder(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_PostSecuritySubmitOrder64(accountId, input, ref output);
            else
                return rushquant_trade_PostSecuritySubmitOrder32(accountId, input, ref output);
        }

        [DllImport("RushQuantClient32.dll", EntryPoint = "rushquant_trade_PostSecurityCancelOrder")]
        private static extern int rushquant_trade_PostSecurityCancelOrder32(int accountId, IntPtr input, ref IntPtr output);
        [DllImport("RushQuantClient64.dll", EntryPoint = "rushquant_trade_PostSecurityCancelOrder")]
        private static extern int rushquant_trade_PostSecurityCancelOrder64(int accountId, IntPtr input, ref IntPtr output);
        internal static int rushquant_trade_PostSecurityCancelOrder(int accountId, IntPtr input, ref IntPtr output)
        {
            if (__is64bit)
                return rushquant_trade_PostSecurityCancelOrder64(accountId, input, ref output);
            else
                return rushquant_trade_PostSecurityCancelOrder32(accountId, input, ref output);
        }
    }
}
