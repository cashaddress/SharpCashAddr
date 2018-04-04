using System;
using Xunit;
using static SharpCashAddr.Converter;

namespace SharpCashAddrTests
{
	public static class Test
	{
		static readonly string[] oldAddr = new string[10] {
			"1111111111111111111114oLvT2",
			"11111111111111111111BZbvjr",
			"1BpEi6DfDAUFd7GtittLSdBeYJvcoaVggu",
			"1KXrWXciRDZUpQwQmuM1DbwsKDLYAYsVLR",
			"16w1D5WRVKJuZUsSRzdLp9w3YGcgoxDXb",
			"3CWFddi6m4ndiGyKqzYvsFYagqDLPVMTzC",
			"3LDsS579y7sruadqu11beEJoTjdFiFCdX4",
			"31nwvkZwyPdgzjBJZXfDmSWsC4ZLKpYyUw",
			"mipcBbFg9gMiCh81Kj8tqqdgoZub1ZJRfn",
			"2MzQwSSnBHWHqSAqtTVQ6v47XtaisrJa1Vc"
		};
		static readonly string[] cashAddr = new string[10] {
			"bitcoincash:qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqfnhks603",
			"bitcoincash:qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqyhlgn0k34",
			"bitcoincash:qpm2qsznhks23z7629mms6s4cwef74vcwvy22gdx6a",
			"bitcoincash:qr95sy3j9xwd2ap32xkykttr4cvcu7as4y0qverfuy",
			"bitcoincash:qqq3728yw0y47sqn6l2na30mcw6zm78dzqre909m2r",
			"bitcoincash:ppm2qsznhks23z7629mms6s4cwef74vcwvn0h829pq",
			"bitcoincash:pr95sy3j9xwd2ap32xkykttr4cvcu7as4yc93ky28e",
			"bitcoincash:pqq3728yw0y47sqn6l2na30mcw6zm78dzq5ucqzc37",
			"bchtest:qqjr7yu573z4faxw8ltgvjwpntwys08fysk07zmvce",
			"bchtest:pp8f7ww2g6y07ypp9r4yendrgyznysc9kqxh6acwu3"
		};
		[Fact]
		public static void conversionToCashAddr()
		{
			for (int i = 0; i < oldAddr.Length; i++)
				Assert.Equal(oldAddrToCashAddr(oldAddr[i], out _, out _), cashAddr[i]);
		}
		[Fact]
		public static void conversionToOldAddr()
		{
			for (int i = 0; i < cashAddr.Length; i++)
				Assert.Equal(cashAddrToOldAddr(cashAddr[i], out _, out _), oldAddr[i]);
		}
	}
}
