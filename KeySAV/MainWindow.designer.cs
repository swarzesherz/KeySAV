// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace KeySAV
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSButton B_ChangeOutputFolder { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DoBreak { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpBlank { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpBoxEKXs { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpBoxKey { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpBreakBox1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpBreakBox2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpEKX { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpKey { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_FindOffset { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_FixEKX { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_FixKey { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_GetKey2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OpenBlank { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OpenBoxKey { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OpenEKX { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OpenKey { get; set; }

		[Outlet]
		MonoMac.AppKit.NSComboBox C_Format { get; set; }

		[Outlet]
		MonoMac.AppKit.NSComboBox CB_Box { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CHK_ALT { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_0xE0 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_0xE1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_0xE2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_0xE3 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_BoxOffset { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_Nick { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_0xE0 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_0xE1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_0xE2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_0xE3 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_Blank { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_BoxKey { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_BoxOffset { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_BoxSAV { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextView T_Dialog { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_E1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_E2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_ekx { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_FixKey { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_key { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_Key2Offset { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_KeyOffset { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_Nick { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_OBreak1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_OBreak2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_Open1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_OutPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_S1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_S2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTabViewItem Tab_Foreign2Key { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTabViewItem Tab_RipEKX { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTabView TC { get; set; }

		[Action ("B_ChangeOutputFolder_Click:")]
		partial void B_ChangeOutputFolder_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DoBreak_Click:")]
		partial void B_DoBreak_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpBlank_Click:")]
		partial void B_DumpBlank_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpBoxEKXs_Click:")]
		partial void B_DumpBoxEKXs_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpBoxKey_Click:")]
		partial void B_DumpBoxKey_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpBreakBox1_Click:")]
		partial void B_DumpBreakBox1_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpBreakBox2_Click:")]
		partial void B_DumpBreakBox2_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpEKX_Click:")]
		partial void B_DumpEKX_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpKey_Click:")]
		partial void B_DumpKey_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpKey2_Click:")]
		partial void B_DumpKey2_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_E1_Click:")]
		partial void B_E1_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_E2_Click:")]
		partial void B_E2_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_FindOffset_Click:")]
		partial void B_FindOffset_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_FixEKX_Click:")]
		partial void B_FixEKX_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_FixKey_Click:")]
		partial void B_FixKey_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OBreak1_Click:")]
		partial void B_OBreak1_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OBreak2_Click:")]
		partial void B_OBreak2_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenBlank_Click:")]
		partial void B_OpenBlank_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenBoxKey_Click:")]
		partial void B_OpenBoxKey_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenBoxSave_Click:")]
		partial void B_OpenBoxSave_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenEKX_Click:")]
		partial void B_OpenEKX_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenKey_Click:")]
		partial void B_OpenKey_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenSave_Click:")]
		partial void B_OpenSave_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_S1_Click:")]
		partial void B_S1_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_S2_Click:")]
		partial void B_S2_Click (MonoMac.Foundation.NSObject sender);

		[Action ("changebox:")]
		partial void changebox (MonoMac.Foundation.NSObject sender);

		[Action ("CHK_ALT_CheckedChanged:")]
		partial void CHK_ALT_CheckedChanged (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (T_Dialog != null) {
				T_Dialog.Dispose ();
				T_Dialog = null;
			}

			if (B_ChangeOutputFolder != null) {
				B_ChangeOutputFolder.Dispose ();
				B_ChangeOutputFolder = null;
			}

			if (B_DoBreak != null) {
				B_DoBreak.Dispose ();
				B_DoBreak = null;
			}

			if (B_DumpBlank != null) {
				B_DumpBlank.Dispose ();
				B_DumpBlank = null;
			}

			if (B_DumpBoxEKXs != null) {
				B_DumpBoxEKXs.Dispose ();
				B_DumpBoxEKXs = null;
			}

			if (B_DumpBoxKey != null) {
				B_DumpBoxKey.Dispose ();
				B_DumpBoxKey = null;
			}

			if (B_DumpBreakBox1 != null) {
				B_DumpBreakBox1.Dispose ();
				B_DumpBreakBox1 = null;
			}

			if (B_DumpBreakBox2 != null) {
				B_DumpBreakBox2.Dispose ();
				B_DumpBreakBox2 = null;
			}

			if (B_DumpEKX != null) {
				B_DumpEKX.Dispose ();
				B_DumpEKX = null;
			}

			if (B_DumpKey != null) {
				B_DumpKey.Dispose ();
				B_DumpKey = null;
			}

			if (B_FindOffset != null) {
				B_FindOffset.Dispose ();
				B_FindOffset = null;
			}

			if (B_FixEKX != null) {
				B_FixEKX.Dispose ();
				B_FixEKX = null;
			}

			if (B_FixKey != null) {
				B_FixKey.Dispose ();
				B_FixKey = null;
			}

			if (B_GetKey2 != null) {
				B_GetKey2.Dispose ();
				B_GetKey2 = null;
			}

			if (B_OpenBlank != null) {
				B_OpenBlank.Dispose ();
				B_OpenBlank = null;
			}

			if (B_OpenBoxKey != null) {
				B_OpenBoxKey.Dispose ();
				B_OpenBoxKey = null;
			}

			if (B_OpenEKX != null) {
				B_OpenEKX.Dispose ();
				B_OpenEKX = null;
			}

			if (B_OpenKey != null) {
				B_OpenKey.Dispose ();
				B_OpenKey = null;
			}

			if (C_Format != null) {
				C_Format.Dispose ();
				C_Format = null;
			}

			if (CB_Box != null) {
				CB_Box.Dispose ();
				CB_Box = null;
			}

			if (CHK_ALT != null) {
				CHK_ALT.Dispose ();
				CHK_ALT = null;
			}

			if (L_0xE0 != null) {
				L_0xE0.Dispose ();
				L_0xE0 = null;
			}

			if (L_0xE1 != null) {
				L_0xE1.Dispose ();
				L_0xE1 = null;
			}

			if (L_0xE2 != null) {
				L_0xE2.Dispose ();
				L_0xE2 = null;
			}

			if (L_0xE3 != null) {
				L_0xE3.Dispose ();
				L_0xE3 = null;
			}

			if (L_BoxOffset != null) {
				L_BoxOffset.Dispose ();
				L_BoxOffset = null;
			}

			if (L_Nick != null) {
				L_Nick.Dispose ();
				L_Nick = null;
			}

			if (T_0xE0 != null) {
				T_0xE0.Dispose ();
				T_0xE0 = null;
			}

			if (T_0xE1 != null) {
				T_0xE1.Dispose ();
				T_0xE1 = null;
			}

			if (T_0xE2 != null) {
				T_0xE2.Dispose ();
				T_0xE2 = null;
			}

			if (T_0xE3 != null) {
				T_0xE3.Dispose ();
				T_0xE3 = null;
			}

			if (T_Blank != null) {
				T_Blank.Dispose ();
				T_Blank = null;
			}

			if (T_BoxKey != null) {
				T_BoxKey.Dispose ();
				T_BoxKey = null;
			}

			if (T_BoxOffset != null) {
				T_BoxOffset.Dispose ();
				T_BoxOffset = null;
			}

			if (T_BoxSAV != null) {
				T_BoxSAV.Dispose ();
				T_BoxSAV = null;
			}

			if (T_E1 != null) {
				T_E1.Dispose ();
				T_E1 = null;
			}

			if (T_E2 != null) {
				T_E2.Dispose ();
				T_E2 = null;
			}

			if (T_ekx != null) {
				T_ekx.Dispose ();
				T_ekx = null;
			}

			if (T_FixKey != null) {
				T_FixKey.Dispose ();
				T_FixKey = null;
			}

			if (T_key != null) {
				T_key.Dispose ();
				T_key = null;
			}

			if (T_Key2Offset != null) {
				T_Key2Offset.Dispose ();
				T_Key2Offset = null;
			}

			if (T_KeyOffset != null) {
				T_KeyOffset.Dispose ();
				T_KeyOffset = null;
			}

			if (T_Nick != null) {
				T_Nick.Dispose ();
				T_Nick = null;
			}

			if (T_OBreak1 != null) {
				T_OBreak1.Dispose ();
				T_OBreak1 = null;
			}

			if (T_OBreak2 != null) {
				T_OBreak2.Dispose ();
				T_OBreak2 = null;
			}

			if (T_Open1 != null) {
				T_Open1.Dispose ();
				T_Open1 = null;
			}

			if (T_OutPath != null) {
				T_OutPath.Dispose ();
				T_OutPath = null;
			}

			if (T_S1 != null) {
				T_S1.Dispose ();
				T_S1 = null;
			}

			if (T_S2 != null) {
				T_S2.Dispose ();
				T_S2 = null;
			}

			if (Tab_Foreign2Key != null) {
				Tab_Foreign2Key.Dispose ();
				Tab_Foreign2Key = null;
			}

			if (Tab_RipEKX != null) {
				Tab_RipEKX.Dispose ();
				Tab_RipEKX = null;
			}

			if (TC != null) {
				TC.Dispose ();
				TC = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
