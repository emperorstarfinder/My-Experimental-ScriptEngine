//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.3.1.7705
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.3.1.7705 Analyze.g 2012-05-22 12:14:59

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


	using Inworldz.Joke.Compiler.BranchAnalyze;


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;
namespace  Inworldz.Joke.Compiler 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3.1.7705")]
[System.CLSCompliant(false)]
public partial class Analyze : Antlr.Runtime.Tree.TreeFilter
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ASSIGN_EQ", "COMMA", "COMMENT_BLOCK", "COMMENT_SINGLE", "DO_WHILE_STMT", "ELIST", "ELSE_PART", "ESC_SEQ", "EVENT_DEF", "EXPONENT", "EXPR", "FLOAT_LITERAL", "FOR_STMT", "FUNC_BLOCK", "GT", "ID", "IF_STMT", "INDEX", "INTEGER_LITERAL", "JUMP_STMT", "LABEL", "LIST_LITERAL", "LPAREN", "LT", "METHOD_CALL", "METHOD_DEF", "MINUS", "NEWLINE", "PARAM_DECL", "POST_DECREMENT", "POST_INCREMENT", "PRE_DECREMENT", "PRE_INCREMENT", "RETURN_STMT", "ROTATION_LITERAL", "RPAREN", "SEMI", "STATE_BLOCK", "STATE_CHG", "STATE_DEF", "STRING_LITERAL", "SUBSCRIPT", "TYPE", "TYPE_CAST", "UNARY_BIT_NOT", "UNARY_BOOL_NOT", "UNARY_MINUS", "VAR_DECL", "VECTOR_LITERAL", "WHILE_STMT", "WS", "'!'", "'!='", "'%'", "'%='", "'&&'", "'&'", "'*'", "'*='", "'+'", "'++'", "'+='", "'--'", "'-='", "'.'", "'/'", "'/='", "'<<'", "'<<='", "'<='", "'=='", "'>='", "'>>'", "'>>='", "'@'", "'['", "']'", "'^'", "'default'", "'do'", "'else'", "'for'", "'if'", "'jump'", "'return'", "'state'", "'while'", "'{'", "'|'", "'||'", "'}'", "'~'"
	};
	public const int EOF=-1;
	public const int ASSIGN_EQ=4;
	public const int COMMA=5;
	public const int COMMENT_BLOCK=6;
	public const int COMMENT_SINGLE=7;
	public const int DO_WHILE_STMT=8;
	public const int ELIST=9;
	public const int ELSE_PART=10;
	public const int ESC_SEQ=11;
	public const int EVENT_DEF=12;
	public const int EXPONENT=13;
	public const int EXPR=14;
	public const int FLOAT_LITERAL=15;
	public const int FOR_STMT=16;
	public const int FUNC_BLOCK=17;
	public const int GT=18;
	public const int ID=19;
	public const int IF_STMT=20;
	public const int INDEX=21;
	public const int INTEGER_LITERAL=22;
	public const int JUMP_STMT=23;
	public const int LABEL=24;
	public const int LIST_LITERAL=25;
	public const int LPAREN=26;
	public const int LT=27;
	public const int METHOD_CALL=28;
	public const int METHOD_DEF=29;
	public const int MINUS=30;
	public const int NEWLINE=31;
	public const int PARAM_DECL=32;
	public const int POST_DECREMENT=33;
	public const int POST_INCREMENT=34;
	public const int PRE_DECREMENT=35;
	public const int PRE_INCREMENT=36;
	public const int RETURN_STMT=37;
	public const int ROTATION_LITERAL=38;
	public const int RPAREN=39;
	public const int SEMI=40;
	public const int STATE_BLOCK=41;
	public const int STATE_CHG=42;
	public const int STATE_DEF=43;
	public const int STRING_LITERAL=44;
	public const int SUBSCRIPT=45;
	public const int TYPE=46;
	public const int TYPE_CAST=47;
	public const int UNARY_BIT_NOT=48;
	public const int UNARY_BOOL_NOT=49;
	public const int UNARY_MINUS=50;
	public const int VAR_DECL=51;
	public const int VECTOR_LITERAL=52;
	public const int WHILE_STMT=53;
	public const int WS=54;
	public const int T__55=55;
	public const int T__56=56;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
	public const int T__72=72;
	public const int T__73=73;
	public const int T__74=74;
	public const int T__75=75;
	public const int T__76=76;
	public const int T__77=77;
	public const int T__78=78;
	public const int T__79=79;
	public const int T__80=80;
	public const int T__81=81;
	public const int T__82=82;
	public const int T__83=83;
	public const int T__84=84;
	public const int T__85=85;
	public const int T__86=86;
	public const int T__87=87;
	public const int T__88=88;
	public const int T__89=89;
	public const int T__90=90;
	public const int T__91=91;
	public const int T__92=92;
	public const int T__93=93;
	public const int T__94=94;
	public const int T__95=95;

	// delegates
	// delegators

	public Analyze( ITreeNodeStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public Analyze(ITreeNodeStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
		

	public override string[] TokenNames { get { return Analyze.tokenNames; } }
	public override string GrammarFileName { get { return "Analyze.g"; } }


		SymbolTable symtab;
		public List<FunctionBranch> FunctionBranches = new List<FunctionBranch>();
		Branch currentBranch = null;
		
		public Analyze(ITreeNodeStream input, SymbolTable symtab) : this(input) {
			this.symtab = symtab;
		}
		
		protected override void Topdown() { topdown(); }
		protected override void Bottomup() { bottomup(); }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules

	partial void EnterRule_topdown();
	partial void LeaveRule_topdown();

	// $ANTLR start "topdown"
	// Analyze.g:30:1: topdown : ( methodDef | ifElseStmt | elsePart | returnStmt | loopStmt | labelDef );
	[GrammarRule("topdown")]
	private void topdown()
	{
		EnterRule_topdown();
		EnterRule("topdown", 1);
		TraceIn("topdown", 1);
		try { DebugEnterRule(GrammarFileName, "topdown");
		DebugLocation(30, 1);
		try
		{
			// Analyze.g:31:2: ( methodDef | ifElseStmt | elsePart | returnStmt | loopStmt | labelDef )
			int alt1=6;
			try { DebugEnterDecision(1, false);
			switch (input.LA(1))
			{
			case METHOD_DEF:
				{
				alt1 = 1;
				}
				break;
			case IF_STMT:
				{
				alt1 = 2;
				}
				break;
			case ELSE_PART:
				{
				alt1 = 3;
				}
				break;
			case RETURN_STMT:
				{
				alt1 = 4;
				}
				break;
			case DO_WHILE_STMT:
			case FOR_STMT:
			case WHILE_STMT:
				{
				alt1 = 5;
				}
				break;
			case LABEL:
				{
				alt1 = 6;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// Analyze.g:31:4: methodDef
				{
				DebugLocation(31, 4);
				PushFollow(Follow._methodDef_in_topdown70);
				methodDef();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Analyze.g:32:4: ifElseStmt
				{
				DebugLocation(32, 4);
				PushFollow(Follow._ifElseStmt_in_topdown75);
				ifElseStmt();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Analyze.g:33:4: elsePart
				{
				DebugLocation(33, 4);
				PushFollow(Follow._elsePart_in_topdown80);
				elsePart();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Analyze.g:34:4: returnStmt
				{
				DebugLocation(34, 4);
				PushFollow(Follow._returnStmt_in_topdown85);
				returnStmt();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Analyze.g:35:4: loopStmt
				{
				DebugLocation(35, 4);
				PushFollow(Follow._loopStmt_in_topdown90);
				loopStmt();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Analyze.g:36:4: labelDef
				{
				DebugLocation(36, 4);
				PushFollow(Follow._labelDef_in_topdown95);
				labelDef();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("topdown", 1);
			LeaveRule("topdown", 1);
			LeaveRule_topdown();
		}
		DebugLocation(37, 1);
		} finally { DebugExitRule(GrammarFileName, "topdown"); }
		return;

	}
	// $ANTLR end "topdown"


	partial void EnterRule_bottomup();
	partial void LeaveRule_bottomup();

	// $ANTLR start "bottomup"
	// Analyze.g:39:1: bottomup : ( methodOut | ifElseOut | loopOut );
	[GrammarRule("bottomup")]
	private void bottomup()
	{
		EnterRule_bottomup();
		EnterRule("bottomup", 2);
		TraceIn("bottomup", 2);
		try { DebugEnterRule(GrammarFileName, "bottomup");
		DebugLocation(39, 1);
		try
		{
			// Analyze.g:40:2: ( methodOut | ifElseOut | loopOut )
			int alt2=3;
			try { DebugEnterDecision(2, false);
			switch (input.LA(1))
			{
			case METHOD_DEF:
				{
				alt2 = 1;
				}
				break;
			case IF_STMT:
				{
				alt2 = 2;
				}
				break;
			case DO_WHILE_STMT:
			case FOR_STMT:
			case WHILE_STMT:
				{
				alt2 = 3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// Analyze.g:40:4: methodOut
				{
				DebugLocation(40, 4);
				PushFollow(Follow._methodOut_in_bottomup106);
				methodOut();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Analyze.g:41:4: ifElseOut
				{
				DebugLocation(41, 4);
				PushFollow(Follow._ifElseOut_in_bottomup111);
				ifElseOut();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Analyze.g:42:4: loopOut
				{
				DebugLocation(42, 4);
				PushFollow(Follow._loopOut_in_bottomup116);
				loopOut();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("bottomup", 2);
			LeaveRule("bottomup", 2);
			LeaveRule_bottomup();
		}
		DebugLocation(43, 1);
		} finally { DebugExitRule(GrammarFileName, "bottomup"); }
		return;

	}
	// $ANTLR end "bottomup"


	partial void EnterRule_loopStmt();
	partial void LeaveRule_loopStmt();

	// $ANTLR start "loopStmt"
	// Analyze.g:45:1: loopStmt : ( WHILE_STMT | FOR_STMT | DO_WHILE_STMT ) ;
	[GrammarRule("loopStmt")]
	private void loopStmt()
	{
		EnterRule_loopStmt();
		EnterRule("loopStmt", 3);
		TraceIn("loopStmt", 3);
		try { DebugEnterRule(GrammarFileName, "loopStmt");
		DebugLocation(45, 1);
		try
		{
			// Analyze.g:46:2: ( ( WHILE_STMT | FOR_STMT | DO_WHILE_STMT ) )
			DebugEnterAlt(1);
			// Analyze.g:46:4: ( WHILE_STMT | FOR_STMT | DO_WHILE_STMT )
			{
			DebugLocation(46, 4);
			if (input.LA(1)==DO_WHILE_STMT||input.LA(1)==FOR_STMT||input.LA(1)==WHILE_STMT)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(47, 3);
			if (state.backtracking == 1)
			{

							if (currentBranch != null)
							{
								LoopStatement loop = new LoopStatement(currentBranch);
								currentBranch.SetNextStatement(loop);
								currentBranch = loop;
							}
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("loopStmt", 3);
			LeaveRule("loopStmt", 3);
			LeaveRule_loopStmt();
		}
		DebugLocation(55, 1);
		} finally { DebugExitRule(GrammarFileName, "loopStmt"); }
		return;

	}
	// $ANTLR end "loopStmt"


	partial void EnterRule_loopOut();
	partial void LeaveRule_loopOut();

	// $ANTLR start "loopOut"
	// Analyze.g:57:1: loopOut : ( WHILE_STMT | FOR_STMT | DO_WHILE_STMT ) ;
	[GrammarRule("loopOut")]
	private void loopOut()
	{
		EnterRule_loopOut();
		EnterRule("loopOut", 4);
		TraceIn("loopOut", 4);
		try { DebugEnterRule(GrammarFileName, "loopOut");
		DebugLocation(57, 1);
		try
		{
			// Analyze.g:58:2: ( ( WHILE_STMT | FOR_STMT | DO_WHILE_STMT ) )
			DebugEnterAlt(1);
			// Analyze.g:59:3: ( WHILE_STMT | FOR_STMT | DO_WHILE_STMT )
			{
			DebugLocation(59, 3);
			if (input.LA(1)==DO_WHILE_STMT||input.LA(1)==FOR_STMT||input.LA(1)==WHILE_STMT)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(60, 3);
			if (state.backtracking == 1)
			{

							if (currentBranch != null)
							{
								currentBranch = currentBranch.ParentBranch;
							}
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("loopOut", 4);
			LeaveRule("loopOut", 4);
			LeaveRule_loopOut();
		}
		DebugLocation(66, 1);
		} finally { DebugExitRule(GrammarFileName, "loopOut"); }
		return;

	}
	// $ANTLR end "loopOut"


	partial void EnterRule_ifElseStmt();
	partial void LeaveRule_ifElseStmt();

	// $ANTLR start "ifElseStmt"
	// Analyze.g:68:1: ifElseStmt : IF_STMT ;
	[GrammarRule("ifElseStmt")]
	private void ifElseStmt()
	{
		EnterRule_ifElseStmt();
		EnterRule("ifElseStmt", 5);
		TraceIn("ifElseStmt", 5);
		try { DebugEnterRule(GrammarFileName, "ifElseStmt");
		DebugLocation(68, 1);
		try
		{
			// Analyze.g:69:2: ( IF_STMT )
			DebugEnterAlt(1);
			// Analyze.g:69:4: IF_STMT
			{
			DebugLocation(69, 4);
			Match(input,IF_STMT,Follow._IF_STMT_in_ifElseStmt180); if (state.failed) return;
			DebugLocation(70, 3);
			if (state.backtracking == 1)
			{

							if (currentBranch != null)
							{
								IfElseStatement ifelse = new IfElseStatement(currentBranch);
								currentBranch.SetNextStatement(ifelse);
								currentBranch = ifelse.IfBranch;
							}
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("ifElseStmt", 5);
			LeaveRule("ifElseStmt", 5);
			LeaveRule_ifElseStmt();
		}
		DebugLocation(78, 1);
		} finally { DebugExitRule(GrammarFileName, "ifElseStmt"); }
		return;

	}
	// $ANTLR end "ifElseStmt"


	partial void EnterRule_ifElseOut();
	partial void LeaveRule_ifElseOut();

	// $ANTLR start "ifElseOut"
	// Analyze.g:80:1: ifElseOut : IF_STMT ;
	[GrammarRule("ifElseOut")]
	private void ifElseOut()
	{
		EnterRule_ifElseOut();
		EnterRule("ifElseOut", 6);
		TraceIn("ifElseOut", 6);
		try { DebugEnterRule(GrammarFileName, "ifElseOut");
		DebugLocation(80, 1);
		try
		{
			// Analyze.g:81:2: ( IF_STMT )
			DebugEnterAlt(1);
			// Analyze.g:81:4: IF_STMT
			{
			DebugLocation(81, 4);
			Match(input,IF_STMT,Follow._IF_STMT_in_ifElseOut195); if (state.failed) return;
			DebugLocation(82, 3);
			if (state.backtracking == 1)
			{

							if (currentBranch != null)
							{
								currentBranch = currentBranch.ParentBranch.ParentBranch;
							}
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("ifElseOut", 6);
			LeaveRule("ifElseOut", 6);
			LeaveRule_ifElseOut();
		}
		DebugLocation(88, 1);
		} finally { DebugExitRule(GrammarFileName, "ifElseOut"); }
		return;

	}
	// $ANTLR end "ifElseOut"


	partial void EnterRule_elsePart();
	partial void LeaveRule_elsePart();

	// $ANTLR start "elsePart"
	// Analyze.g:90:1: elsePart : ^( ELSE_PART . ) ;
	[GrammarRule("elsePart")]
	private void elsePart()
	{
		EnterRule_elsePart();
		EnterRule("elsePart", 7);
		TraceIn("elsePart", 7);
		try { DebugEnterRule(GrammarFileName, "elsePart");
		DebugLocation(90, 1);
		try
		{
			// Analyze.g:91:2: ( ^( ELSE_PART . ) )
			DebugEnterAlt(1);
			// Analyze.g:91:4: ^( ELSE_PART . )
			{
			DebugLocation(91, 4);
			DebugLocation(91, 6);
			Match(input,ELSE_PART,Follow._ELSE_PART_in_elsePart211); if (state.failed) return;

			Match(input, TokenTypes.Down, null); if (state.failed) return;
			DebugLocation(91, 16);
			MatchAny(input); if (state.failed) return;

			Match(input, TokenTypes.Up, null); if (state.failed) return;
			DebugLocation(92, 3);
			if (state.backtracking == 1)
			{

							if (currentBranch != null)
							{
								currentBranch = ((IfElseStatement)currentBranch.ParentBranch).ElseBranch;
							}
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("elsePart", 7);
			LeaveRule("elsePart", 7);
			LeaveRule_elsePart();
		}
		DebugLocation(98, 1);
		} finally { DebugExitRule(GrammarFileName, "elsePart"); }
		return;

	}
	// $ANTLR end "elsePart"


	partial void EnterRule_labelDef();
	partial void LeaveRule_labelDef();

	// $ANTLR start "labelDef"
	// Analyze.g:100:1: labelDef : ^( LABEL ID ) ;
	[GrammarRule("labelDef")]
	private void labelDef()
	{
		EnterRule_labelDef();
		EnterRule("labelDef", 8);
		TraceIn("labelDef", 8);
		try { DebugEnterRule(GrammarFileName, "labelDef");
		DebugLocation(100, 1);
		try
		{
			// Analyze.g:101:2: ( ^( LABEL ID ) )
			DebugEnterAlt(1);
			// Analyze.g:101:4: ^( LABEL ID )
			{
			DebugLocation(101, 4);
			DebugLocation(101, 6);
			Match(input,LABEL,Follow._LABEL_in_labelDef230); if (state.failed) return;

			Match(input, TokenTypes.Down, null); if (state.failed) return;
			DebugLocation(101, 12);
			Match(input,ID,Follow._ID_in_labelDef232); if (state.failed) return;

			Match(input, TokenTypes.Up, null); if (state.failed) return;
			DebugLocation(102, 3);
			if (state.backtracking == 1)
			{

							if (currentBranch != null)
							{
								Label lbl = new Label(currentBranch);
								currentBranch.SetNextStatement(lbl);
							}
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("labelDef", 8);
			LeaveRule("labelDef", 8);
			LeaveRule_labelDef();
		}
		DebugLocation(109, 1);
		} finally { DebugExitRule(GrammarFileName, "labelDef"); }
		return;

	}
	// $ANTLR end "labelDef"


	partial void EnterRule_returnStmt();
	partial void LeaveRule_returnStmt();

	// $ANTLR start "returnStmt"
	// Analyze.g:111:1: returnStmt : RETURN_STMT ;
	[GrammarRule("returnStmt")]
	private void returnStmt()
	{
		EnterRule_returnStmt();
		EnterRule("returnStmt", 9);
		TraceIn("returnStmt", 9);
		try { DebugEnterRule(GrammarFileName, "returnStmt");
		DebugLocation(111, 1);
		try
		{
			// Analyze.g:112:2: ( RETURN_STMT )
			DebugEnterAlt(1);
			// Analyze.g:112:4: RETURN_STMT
			{
			DebugLocation(112, 4);
			Match(input,RETURN_STMT,Follow._RETURN_STMT_in_returnStmt248); if (state.failed) return;
			DebugLocation(113, 3);
			if (state.backtracking == 1)
			{

							if (currentBranch != null)
							{
								ReturnStatement ret = new ReturnStatement(currentBranch);
								currentBranch.SetNextStatement(ret);
							}
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("returnStmt", 9);
			LeaveRule("returnStmt", 9);
			LeaveRule_returnStmt();
		}
		DebugLocation(120, 1);
		} finally { DebugExitRule(GrammarFileName, "returnStmt"); }
		return;

	}
	// $ANTLR end "returnStmt"


	partial void EnterRule_methodDef();
	partial void LeaveRule_methodDef();

	// $ANTLR start "methodDef"
	// Analyze.g:122:1: methodDef : ^( METHOD_DEF ( TYPE )? ID ( . )* ) ;
	[GrammarRule("methodDef")]
	private void methodDef()
	{
		EnterRule_methodDef();
		EnterRule("methodDef", 10);
		TraceIn("methodDef", 10);
		LSLAst ID1 = default(LSLAst);
		LSLAst TYPE2 = default(LSLAst);

		try { DebugEnterRule(GrammarFileName, "methodDef");
		DebugLocation(122, 1);
		try
		{
			// Analyze.g:123:2: ( ^( METHOD_DEF ( TYPE )? ID ( . )* ) )
			DebugEnterAlt(1);
			// Analyze.g:123:4: ^( METHOD_DEF ( TYPE )? ID ( . )* )
			{
			DebugLocation(123, 4);
			DebugLocation(123, 6);
			Match(input,METHOD_DEF,Follow._METHOD_DEF_in_methodDef264); if (state.failed) return;

			Match(input, TokenTypes.Down, null); if (state.failed) return;
			DebugLocation(123, 17);
			// Analyze.g:123:17: ( TYPE )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, false);
			int LA3_0 = input.LA(1);

			if ((LA3_0==TYPE))
			{
				alt3 = 1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// Analyze.g:123:17: TYPE
				{
				DebugLocation(123, 17);
				TYPE2=(LSLAst)Match(input,TYPE,Follow._TYPE_in_methodDef266); if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(123, 23);
			ID1=(LSLAst)Match(input,ID,Follow._ID_in_methodDef269); if (state.failed) return;
			DebugLocation(123, 26);
			// Analyze.g:123:26: ( . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_0 = input.LA(1);

				if (((LA4_0>=ASSIGN_EQ && LA4_0<=95)))
				{
					alt4 = 1;
				}
				else if ((LA4_0==UP))
				{
					alt4 = 2;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// Analyze.g:123:26: .
					{
					DebugLocation(123, 26);
					MatchAny(input); if (state.failed) return;

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			Match(input, TokenTypes.Up, null); if (state.failed) return;
			DebugLocation(124, 3);
			if (state.backtracking == 1)
			{

							currentBranch = new FunctionBranch(ID1, (TYPE2!=null?TYPE2.Text:null));
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("methodDef", 10);
			LeaveRule("methodDef", 10);
			LeaveRule_methodDef();
		}
		DebugLocation(127, 1);
		} finally { DebugExitRule(GrammarFileName, "methodDef"); }
		return;

	}
	// $ANTLR end "methodDef"


	partial void EnterRule_methodOut();
	partial void LeaveRule_methodOut();

	// $ANTLR start "methodOut"
	// Analyze.g:129:1: methodOut : METHOD_DEF ;
	[GrammarRule("methodOut")]
	private void methodOut()
	{
		EnterRule_methodOut();
		EnterRule("methodOut", 11);
		TraceIn("methodOut", 11);
		try { DebugEnterRule(GrammarFileName, "methodOut");
		DebugLocation(129, 1);
		try
		{
			// Analyze.g:130:2: ( METHOD_DEF )
			DebugEnterAlt(1);
			// Analyze.g:130:4: METHOD_DEF
			{
			DebugLocation(130, 4);
			Match(input,METHOD_DEF,Follow._METHOD_DEF_in_methodOut288); if (state.failed) return;
			DebugLocation(131, 3);
			if (state.backtracking == 1)
			{

							FunctionBranches.Add((FunctionBranch)currentBranch);
							currentBranch = null;
						
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("methodOut", 11);
			LeaveRule("methodOut", 11);
			LeaveRule_methodOut();
		}
		DebugLocation(135, 1);
		} finally { DebugExitRule(GrammarFileName, "methodOut"); }
		return;

	}
	// $ANTLR end "methodOut"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _methodDef_in_topdown70 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifElseStmt_in_topdown75 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _elsePart_in_topdown80 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnStmt_in_topdown85 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _loopStmt_in_topdown90 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _labelDef_in_topdown95 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodOut_in_bottomup106 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifElseOut_in_bottomup111 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _loopOut_in_bottomup116 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_loopStmt127 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_loopOut155 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_STMT_in_ifElseStmt180 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_STMT_in_ifElseOut195 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_PART_in_elsePart211 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _LABEL_in_labelDef230 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _ID_in_labelDef232 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _RETURN_STMT_in_returnStmt248 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _METHOD_DEF_in_methodDef264 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _TYPE_in_methodDef266 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ID_in_methodDef269 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF8UL,0xFFFFFFFFUL});
		public static readonly BitSet _METHOD_DEF_in_methodOut288 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  Inworldz.Joke.Compiler 
