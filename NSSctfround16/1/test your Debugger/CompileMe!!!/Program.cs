﻿//NET8.0


namespace NSSCTF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _ = new ulong[] { 0x57656c636f6d6520, 0x746f204e53534354, 0x4620526f756e6423, 0x3136204261736963 };
            var __ = new ulong[] { 0xc60b34b2bff9d34a, 0xf50af3aa8fd96c6b, 0x680ed11f0c05c4f1, 0x6e83b0a4aaf7c1a3, 0xd69b3d568695c3c5, 0xa88f4ff50a351da2, 0x5cfa195968e1bb5b, 0xc4168018d92196d9 };
            const ulong ___ = 0x9E3779B9;
            var ____ = Enumerable.Range(0, 32).Select(______ => ___ * (32 - (uint)______)).ToArray();

            var _____ = __.Select((_______, ________) => new { Value = _______, Index = ________ })
                .GroupBy(____________ => ____________.Index / 2)
                .Select(___________ =>
                {
                    ulong _________ = ___________.ElementAt(0).Value;
                    ulong __________ = ___________.ElementAt(1).Value;
                    ulong _____________ = ___ * 32;

                    ____.ToList().ForEach(_____________________ =>
                    {
                        __________ -= (((_________ << 4) ^ (_________ >> 5)) + _________) ^ (_____________ + _[(_____________ >> 11) & 3]);
                        _____________ -= ___;
                        _________ -= (((__________ << 4) ^ (__________ >> 5)) + __________) ^ (_____________ + _[_____________ & 3]);
                    });
                    return new[] { _________, __________ };
                })
                .SelectMany(______________ => ______________)
                .ToArray();

            Array.Copy(_____, __, __.Length);

            __.SelectMany(_______________ => BitConverter.GetBytes(new ZZZ(_______________).GetVal()).Reverse()).ToList().ForEach(________________ => Console.Write(Encoding.ASCII.GetString(new[] { ________________ })));
            //Output: NSSCTF{xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx}
            //Try to compile me!!!
        }
    }

    abstract class _(ulong val)
    {
        public abstract ulong GetVal();
    }

    class A(ulong val) : _(val)
    {
        public override ulong GetVal()
        {
            return val + 0x79013C0BD7467DC;
        }
    }

    class B(ulong val) : A(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78D23D50E23FC98;
        }
    }

    class C(ulong val) : B(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E83D35728928CB;
        }
    }

    class D(ulong val) : C(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4901E49CF9D63E8;
        }
    }

    class E(ulong val) : D(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x664DCA766EBA177;
        }
    }

    class F(ulong val) : E(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7532EA705E8D596;
        }
    }

    class G(ulong val) : F(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x703A7337269BDED;
        }
    }

    class H(ulong val) : G(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FD783765C32290;
        }
    }

    class I(ulong val) : H(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A443D7480A09F7;
        }
    }

    class J(ulong val) : I(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56DA61F2838D0F0;
        }
    }

    class K(ulong val) : J(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8BB265728FB7DFB;
        }
    }

    class L(ulong val) : K(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x269BACD67A90847;
        }
    }

    class M(ulong val) : L(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DA9FD8227B3C0E;
        }
    }

    class N(ulong val) : M(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4BD63AD64645382;
        }
    }

    class O(ulong val) : N(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x217B8BBBA1796D6;
        }
    }

    class P(ulong val) : O(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x114B0C17F0131BB;
        }
    }

    class Q(ulong val) : P(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80DB2BFACB2D5E7;
        }
    }

    class R(ulong val) : Q(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AAAFAD585E5AEF;
        }
    }

    class S(ulong val) : R(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x12F889D091122DD;
        }
    }

    class T(ulong val) : S(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1DF71FE738C31AF;
        }
    }

    class U(ulong val) : T(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x34544AFDC0CB48A;
        }
    }

    class V(ulong val) : U(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D5B5BEEB91F4A1;
        }
    }

    class W(ulong val) : V(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5194D4F661444C3;
        }
    }

    class X(ulong val) : W(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x813FD7772E9FF63;
        }
    }

    class Y(ulong val) : X(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CCCA1F58803A93;
        }
    }

    class Z(ulong val) : Y(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1F288EFE8770E97;
        }
    }

    class AA(ulong val) : Z(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x22A37F6D6A0D130;
        }
    }

    class AB(ulong val) : AA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45DB5DAE3EE2293;
        }
    }

    class AC(ulong val) : AB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19B1E1B08FDC822;
        }
    }

    class AD(ulong val) : AC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8A637068E2659D5;
        }
    }

    class AE(ulong val) : AD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21E6B43B042B3B5;
        }
    }

    class AF(ulong val) : AE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6BE099202B475F6;
        }
    }

    class AG(ulong val) : AF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92F37D2391D8626;
        }
    }

    class AH(ulong val) : AG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B17B19470F8DE7;
        }
    }

    class AI(ulong val) : AH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x664E77DFBE665D0;
        }
    }

    class AJ(ulong val) : AI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x588CFC44B8DA2B6;
        }
    }

    class AK(ulong val) : AJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x776D7B72BCE2BEA;
        }
    }

    class AL(ulong val) : AK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x711B95FE75E581F;
        }
    }

    class AM(ulong val) : AL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3000738251EC046;
        }
    }

    class AN(ulong val) : AM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96317DC82EF70A7;
        }
    }

    class AO(ulong val) : AN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85D8CAB672C7588;
        }
    }

    class AP(ulong val) : AO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x28220B50B3DD0F2;
        }
    }

    class AQ(ulong val) : AP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x253FC6B4A074971;
        }
    }

    class AR(ulong val) : AQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x59526536D516993;
        }
    }

    class AS(ulong val) : AR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80E26D200544E34;
        }
    }

    class AT(ulong val) : AS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CFB7B88B3CB8CC;
        }
    }

    class AU(ulong val) : AT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1E7B74BE691A7D8;
        }
    }

    class AV(ulong val) : AU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x318DE0C602FFAC2;
        }
    }

    class AW(ulong val) : AV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2038C1D12E5B7D7;
        }
    }

    class AX(ulong val) : AW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7975FBE8F807C2E;
        }
    }

    class AY(ulong val) : AX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x482CC76806CA226;
        }
    }

    class AZ(ulong val) : AY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1F60DBF2752BBC3;
        }
    }

    class BA(ulong val) : AZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98235F30FAA74DB;
        }
    }

    class BB(ulong val) : BA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x533F9FA2D9DF4CF;
        }
    }

    class BC(ulong val) : BB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A8A820F0255BC0;
        }
    }

    class BD(ulong val) : BC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x14D9E0088DDCC51;
        }
    }

    class BE(ulong val) : BD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x27D96166839D5FE;
        }
    }

    class BF(ulong val) : BE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F9C5C43D316308;
        }
    }

    class BG(ulong val) : BF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DE5B1422FCF714;
        }
    }

    class BH(ulong val) : BG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x958FFEE2B58F4FB;
        }
    }

    class BI(ulong val) : BH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3700C21481EE435;
        }
    }

    class BJ(ulong val) : BI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4E9A7E6A60DAABC;
        }
    }

    class BK(ulong val) : BJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x424FEECACEB9CE2;
        }
    }

    class BL(ulong val) : BK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x28147538600C7FC;
        }
    }

    class BM(ulong val) : BL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8969403B65BB223;
        }
    }

    class BN(ulong val) : BM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B6873F730D8FC9;
        }
    }

    class BO(ulong val) : BN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x35F14B742D4E8E4;
        }
    }

    class BP(ulong val) : BO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x141556BD9D361B2;
        }
    }

    class BQ(ulong val) : BP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x482FD3B221A17FE;
        }
    }

    class BR(ulong val) : BQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B8A822CC9D2CD5;
        }
    }

    class BS(ulong val) : BR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6CE65DC7D452DF2;
        }
    }

    class BT(ulong val) : BS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x425E14ACFFB890F;
        }
    }

    class BU(ulong val) : BT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45D283641A509ED;
        }
    }

    class BV(ulong val) : BU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4DCEC8AF1EC889C;
        }
    }

    class BW(ulong val) : BV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7511CC6748337A6;
        }
    }

    class BX(ulong val) : BW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63560B78B8CE691;
        }
    }

    class BY(ulong val) : BX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x24B1EB8F7F28B1B;
        }
    }

    class BZ(ulong val) : BY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2673AB09CAC3168;
        }
    }

    class CA(ulong val) : BZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B3D918CF650797;
        }
    }

    class CB(ulong val) : CA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1EEA233056CA0EB;
        }
    }

    class CC(ulong val) : CB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48819E2E1B98DD2;
        }
    }

    class CD(ulong val) : CC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3E622F2771D8951;
        }
    }

    class CE(ulong val) : CD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x309DA8874909928;
        }
    }

    class CF(ulong val) : CE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x944B291B281A25A;
        }
    }

    class CG(ulong val) : CF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92766A985E4D8C1;
        }
    }

    class CH(ulong val) : CG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E4581A6BF42CCB;
        }
    }

    class CI(ulong val) : CH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x40B61A326E07B10;
        }
    }

    class CJ(ulong val) : CI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x97A1C220333F76A;
        }
    }

    class CK(ulong val) : CJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x416F0D8A5C8DAB7;
        }
    }

    class CL(ulong val) : CK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49E4842C8858445;
        }
    }

    class CM(ulong val) : CL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20DF2E3D57BDB02;
        }
    }

    class CN(ulong val) : CM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4058146DD48371A;
        }
    }

    class CO(ulong val) : CN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x83CD46B12C3447E;
        }
    }

    class CP(ulong val) : CO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x907A0FCA22D5577;
        }
    }

    class CQ(ulong val) : CP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x30849AFFE465D16;
        }
    }

    class CR(ulong val) : CQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x868FFC8C8B98BD2;
        }
    }

    class CS(ulong val) : CR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56362927A5F9D6C;
        }
    }

    class CT(ulong val) : CS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C5F32E41FB9FCC;
        }
    }

    class CU(ulong val) : CT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E393D252B62473;
        }
    }

    class CV(ulong val) : CU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x82D3814A7C4CAA7;
        }
    }

    class CW(ulong val) : CV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35DEEB1EC9943AA;
        }
    }

    class CX(ulong val) : CW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x93E48E2A0AF2DBD;
        }
    }

    class CY(ulong val) : CX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x68C8BED541AE60C;
        }
    }

    class CZ(ulong val) : CY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79EF6012BBFEC62;
        }
    }

    class DA(ulong val) : CZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x416020EC167C7EC;
        }
    }

    class DB(ulong val) : DA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1CD9036A28F43A7;
        }
    }

    class DC(ulong val) : DB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x151197BA2ED4A2B;
        }
    }

    class DD(ulong val) : DC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x243295F1CAEF93B;
        }
    }

    class DE(ulong val) : DD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x663258A322F4582;
        }
    }

    class DF(ulong val) : DE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x811C7182A9EB781;
        }
    }

    class DG(ulong val) : DF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x998AC862C282012;
        }
    }

    class DH(ulong val) : DG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8BF8D2A6AF0A172;
        }
    }

    class DI(ulong val) : DH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x690D44F018131EE;
        }
    }

    class DJ(ulong val) : DI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5EB55F35ECDEFC6;
        }
    }

    class DK(ulong val) : DJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x977D7D26EC124EA;
        }
    }

    class DL(ulong val) : DK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2B329ED4E8DD9BB;
        }
    }

    class DM(ulong val) : DL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6073B0E0AECF060;
        }
    }

    class DN(ulong val) : DM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x74D39F02899B1C2;
        }
    }

    class DO(ulong val) : DN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x60CFCF9274CAB88;
        }
    }

    class DP(ulong val) : DO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B270AC507A6AF8;
        }
    }

    class DQ(ulong val) : DP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23D8733D27D651A;
        }
    }

    class DR(ulong val) : DQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2DC542D7F2548ED;
        }
    }

    class DS(ulong val) : DR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9295F339EC8C095;
        }
    }

    class DT(ulong val) : DS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x138CC523C0D355E;
        }
    }

    class DU(ulong val) : DT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17A74AE0E8B5C18;
        }
    }

    class DV(ulong val) : DU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20A1A98C898A92A;
        }
    }

    class DW(ulong val) : DV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x96EACED99024679;
        }
    }

    class DX(ulong val) : DW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x275AAAD8097801E;
        }
    }

    class DY(ulong val) : DX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D9A7007822AD3D;
        }
    }

    class DZ(ulong val) : DY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8516E2350013B1B;
        }
    }

    class EA(ulong val) : DZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x197E89EBCB735E6;
        }
    }

    class EB(ulong val) : EA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x31EE06E26B83F15;
        }
    }

    class EC(ulong val) : EB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x744192646B77D67;
        }
    }

    class ED(ulong val) : EC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55680872D10CA25;
        }
    }

    class EE(ulong val) : ED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4EA1F70CA31D5F4;
        }
    }

    class EF(ulong val) : EE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x513F3FAC54C927F;
        }
    }

    class EG(ulong val) : EF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x676230DD8C3E231;
        }
    }

    class EH(ulong val) : EG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x30FBB0482D806D0;
        }
    }

    class EI(ulong val) : EH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5839B4B43BA8735;
        }
    }

    class EJ(ulong val) : EI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x135735DB5978AD6;
        }
    }

    class EK(ulong val) : EJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x43D10FA4D094BDF;
        }
    }

    class EL(ulong val) : EK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4D524B6684D8C78;
        }
    }

    class EM(ulong val) : EL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94447D188D1E23F;
        }
    }

    class EN(ulong val) : EM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5AE510B05F79E00;
        }
    }

    class EO(ulong val) : EN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56F6AE4A1EB5813;
        }
    }

    class EP(ulong val) : EO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x46284B259DC92C7;
        }
    }

    class EQ(ulong val) : EP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x67963829E7A8806;
        }
    }

    class ER(ulong val) : EQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54852B01F45DF76;
        }
    }

    class ES(ulong val) : ER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x498A28FAE855756;
        }
    }

    class ET(ulong val) : ES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26B51EDF9AF0B49;
        }
    }

    class EU(ulong val) : ET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D3FCAA5F0D1F3B;
        }
    }

    class EV(ulong val) : EU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x251788B4F870C0C;
        }
    }

    class EW(ulong val) : EV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22B16A7FF84B927;
        }
    }

    class EX(ulong val) : EW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FA815003C148B7;
        }
    }

    class EY(ulong val) : EX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x69D167833C121F8;
        }
    }

    class EZ(ulong val) : EY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x946F3CC1A3E7BCB;
        }
    }

    class FA(ulong val) : EZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x76D9654390F4F53;
        }
    }

    class FB(ulong val) : FA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B0C4512719016E;
        }
    }

    class FC(ulong val) : FB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x61AB5C14F1E5E18;
        }
    }

    class FD(ulong val) : FC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71C85CB8BF35CA8;
        }
    }

    class FE(ulong val) : FD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DB08DC8C571567;
        }
    }

    class FF(ulong val) : FE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3969515CD7AB1B7;
        }
    }

    class FG(ulong val) : FF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70A2CAF3E26BE39;
        }
    }

    class FH(ulong val) : FG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19105E79977B2B6;
        }
    }

    class FI(ulong val) : FH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7CADAE59362D904;
        }
    }

    class FJ(ulong val) : FI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6EE8428222AF63C;
        }
    }

    class FK(ulong val) : FJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x59FD9C3BBBECD7A;
        }
    }

    class FL(ulong val) : FK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3467F3857ABF99A;
        }
    }

    class FM(ulong val) : FL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C0E34737E3A3E9;
        }
    }

    class FN(ulong val) : FM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x30EBA39B172018B;
        }
    }

    class FO(ulong val) : FN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1BB2C18F6779A9D;
        }
    }

    class FP(ulong val) : FO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x97868BDD90C006F;
        }
    }

    class FQ(ulong val) : FP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E271BC85553CBC;
        }
    }

    class FR(ulong val) : FQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x755A45814200EFF;
        }
    }

    class FS(ulong val) : FR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8059E554E0CE648;
        }
    }

    class FT(ulong val) : FS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A931C86F8B1CC7;
        }
    }

    class FU(ulong val) : FT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x40832BC3B2E9C68;
        }
    }

    class FV(ulong val) : FU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CF4E1B83EA5404;
        }
    }

    class FW(ulong val) : FV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CEB6D326CB0560;
        }
    }

    class FX(ulong val) : FW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FFA4FD26B2E772;
        }
    }

    class FY(ulong val) : FX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6129E81DA87B64F;
        }
    }

    class FZ(ulong val) : FY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1AF46EC2C5DCE99;
        }
    }

    class GA(ulong val) : FZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9406596BC3EFA31;
        }
    }

    class GB(ulong val) : GA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x51BF7FD8E5F0D61;
        }
    }

    class GC(ulong val) : GB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9451030254D1BDA;
        }
    }

    class GD(ulong val) : GC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BB8EA9EB05AE93;
        }
    }

    class GE(ulong val) : GD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x97F9D9C37EA2D11;
        }
    }

    class GF(ulong val) : GE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x661B85633E0A5B3;
        }
    }

    class GG(ulong val) : GF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5058ECA2D4656DF;
        }
    }

    class GH(ulong val) : GG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x926B5BADE09D53B;
        }
    }

    class GI(ulong val) : GH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x44564B09E3655C9;
        }
    }

    class GJ(ulong val) : GI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x37D4B3FB131F986;
        }
    }

    class GK(ulong val) : GJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BFD315DCA85287;
        }
    }

    class GL(ulong val) : GK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6761E1923618A2A;
        }
    }

    class GM(ulong val) : GL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x41D903E816A1CDF;
        }
    }

    class GN(ulong val) : GM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x232284D6F7C1BC4;
        }
    }

    class GO(ulong val) : GN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6D632057D15B4BE;
        }
    }

    class GP(ulong val) : GO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7AD4C24ACE928FD;
        }
    }

    class GQ(ulong val) : GP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4643D879394B818;
        }
    }

    class GR(ulong val) : GQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C69444047505B9;
        }
    }

    class GS(ulong val) : GR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x14A6244C0439235;
        }
    }

    class GT(ulong val) : GS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x28E5B6B36407A29;
        }
    }

    class GU(ulong val) : GT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6433569A18BEBFF;
        }
    }

    class GV(ulong val) : GU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x179B586EF8471C2;
        }
    }

    class GW(ulong val) : GV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8DFDB7B2C8C5A8E;
        }
    }

    class GX(ulong val) : GW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3E94977DC1B66E9;
        }
    }

    class GY(ulong val) : GX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8F84C40B93055BC;
        }
    }

    class GZ(ulong val) : GY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x76C7C729810E345;
        }
    }

    class HA(ulong val) : GZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DC1173DCB14783;
        }
    }

    class HB(ulong val) : HA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1C26058B51D0F0D;
        }
    }

    class HC(ulong val) : HB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2FCCD878009D6BA;
        }
    }

    class HD(ulong val) : HC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x114A3A82E420D9B;
        }
    }

    class HE(ulong val) : HD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2EB1CE3450E03BD;
        }
    }

    class HF(ulong val) : HE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x263D9481FC1255B;
        }
    }

    class HG(ulong val) : HF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62B85962E14AC6B;
        }
    }

    class HH(ulong val) : HG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F8A3F7859B2618;
        }
    }

    class HI(ulong val) : HH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5C0E2723AAB01B9;
        }
    }

    class HJ(ulong val) : HI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x65669E779799DAD;
        }
    }

    class HK(ulong val) : HJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FECC3F6C9406E1;
        }
    }

    class HL(ulong val) : HK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2157340E6DE52F2;
        }
    }

    class HM(ulong val) : HL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F797418431FAFA;
        }
    }

    class HN(ulong val) : HM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4D458F2781BF125;
        }
    }

    class HO(ulong val) : HN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1C802109A579E0A;
        }
    }

    class HP(ulong val) : HO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34EDC33BF85C6B7;
        }
    }

    class HQ(ulong val) : HP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F9B0445A696BE0;
        }
    }

    class HR(ulong val) : HQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74FFD7A7D592578;
        }
    }

    class HS(ulong val) : HR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11ABA72593B6B65;
        }
    }

    class HT(ulong val) : HS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DCA0C029DADA6E;
        }
    }

    class HU(ulong val) : HT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5662DF1C62DF017;
        }
    }

    class HV(ulong val) : HU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D0BD0F19AAC029;
        }
    }

    class HW(ulong val) : HV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63EB752CAE478B9;
        }
    }

    class HX(ulong val) : HW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2AE2E574A3D7585;
        }
    }

    class HY(ulong val) : HX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23BB43EBDDC62E6;
        }
    }

    class HZ(ulong val) : HY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88313829817EDC2;
        }
    }

    class IA(ulong val) : HZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72C94DF734C3FBF;
        }
    }

    class IB(ulong val) : IA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15691A8894EBD32;
        }
    }

    class IC(ulong val) : IB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9257608F42D72E5;
        }
    }

    class ID(ulong val) : IC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x975D193CFDC3828;
        }
    }

    class IE(ulong val) : ID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x541A810843BE744;
        }
    }

    class IF(ulong val) : IE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x315619F79087B5B;
        }
    }

    class IG(ulong val) : IF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x95849B186A091C0;
        }
    }

    class IH(ulong val) : IG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4E0CBAE64DD80BC;
        }
    }

    class II(ulong val) : IH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3436175CEC8E1D5;
        }
    }

    class IJ(ulong val) : II(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7AC3B5AC71CDB14;
        }
    }

    class IK(ulong val) : IJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8A5AC72ECAEF7BB;
        }
    }

    class IL(ulong val) : IK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2B71513730D957B;
        }
    }

    class IM(ulong val) : IL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x29B86C413E0C401;
        }
    }

    class IN(ulong val) : IM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5144F92D0D12DA9;
        }
    }

    class IO(ulong val) : IN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FB6F1BAF075263;
        }
    }

    class IP(ulong val) : IO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x946BD36BDD4C766;
        }
    }

    class IQ(ulong val) : IP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x553DF3BAF84F3C1;
        }
    }

    class IR(ulong val) : IQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x473AEDD59D83EF8;
        }
    }

    class IS(ulong val) : IR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36406368FED5707;
        }
    }

    class IT(ulong val) : IS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2611657CFFE6FE2;
        }
    }

    class IU(ulong val) : IT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E9E8554231E41E;
        }
    }

    class IV(ulong val) : IU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3EB2EF2EB458544;
        }
    }

    class IW(ulong val) : IV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2BC290FAE27ADF0;
        }
    }

    class IX(ulong val) : IW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15B4247A4C40934;
        }
    }

    class IY(ulong val) : IX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x30DC2D09C6A5673;
        }
    }

    class IZ(ulong val) : IY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E6D7B831BF2423;
        }
    }

    class JA(ulong val) : IZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F12FBE3009CE82;
        }
    }

    class JB(ulong val) : JA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x354D5E69AB1C646;
        }
    }

    class JC(ulong val) : JB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A03C04D69EDC58;
        }
    }

    class JD(ulong val) : JC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x388ACB600992AE4;
        }
    }

    class JE(ulong val) : JD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81B7C3BD6E57CE4;
        }
    }

    class JF(ulong val) : JE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DE4794E2F1AF2F;
        }
    }

    class JG(ulong val) : JF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9024CCC03296185;
        }
    }

    class JH(ulong val) : JG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64481C7A51BEEF7;
        }
    }

    class JI(ulong val) : JH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BEA0CEF3C58073;
        }
    }

    class JJ(ulong val) : JI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x433242C48D8628E;
        }
    }

    class JK(ulong val) : JJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7AC2EA80A741185;
        }
    }

    class JL(ulong val) : JK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9506A2B4A3AF522;
        }
    }

    class JM(ulong val) : JL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17EB1E12BAF8D0C;
        }
    }

    class JN(ulong val) : JM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5045448D12F4234;
        }
    }

    class JO(ulong val) : JN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57BBCE2ECC575D9;
        }
    }

    class JP(ulong val) : JO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7C7931E3C36929A;
        }
    }

    class JQ(ulong val) : JP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x95735245FDAE9E0;
        }
    }

    class JR(ulong val) : JQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70518B3846BE634;
        }
    }

    class JS(ulong val) : JR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BF3D5A03CB61D6;
        }
    }

    class JT(ulong val) : JS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1AAE3E19FE30781;
        }
    }

    class JU(ulong val) : JT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DC9C09AAFA1E4A;
        }
    }

    class JV(ulong val) : JU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x106D3047117E625;
        }
    }

    class JW(ulong val) : JV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56D6AF63CFBA38A;
        }
    }

    class JX(ulong val) : JW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63575DBA3F55784;
        }
    }

    class JY(ulong val) : JX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6F8BB5F095156CC;
        }
    }

    class JZ(ulong val) : JY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7066B78F2C1DCF6;
        }
    }

    class KA(ulong val) : JZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x43065B322BC31D3;
        }
    }

    class KB(ulong val) : KA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BA57E647245CA3;
        }
    }

    class KC(ulong val) : KB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17384948B5A8259;
        }
    }

    class KD(ulong val) : KC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x304DEF1C864E270;
        }
    }

    class KE(ulong val) : KD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5ED29D107B7DB76;
        }
    }

    class KF(ulong val) : KE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1556346C7761910;
        }
    }

    class KG(ulong val) : KF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93162D1A2DCCC90;
        }
    }

    class KH(ulong val) : KG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x531BCC6FD0C5866;
        }
    }

    class KI(ulong val) : KH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3398E1F5C85CFFD;
        }
    }

    class KJ(ulong val) : KI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2803D7E42C9DC4A;
        }
    }

    class KK(ulong val) : KJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4CB7B284216C2BE;
        }
    }

    class KL(ulong val) : KK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2D994DF05C7649B;
        }
    }

    class KM(ulong val) : KL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x27A6BE21C2C8C89;
        }
    }

    class KN(ulong val) : KM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3ACE3D89D739688;
        }
    }

    class KO(ulong val) : KN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55F8BC4B72AA77D;
        }
    }

    class KP(ulong val) : KO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x64070DFC6F98D9D;
        }
    }

    class KQ(ulong val) : KP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4CDE9F4334F7384;
        }
    }

    class KR(ulong val) : KQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x411295BEBAF95B4;
        }
    }

    class KS(ulong val) : KR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x404852CA6189992;
        }
    }

    class KT(ulong val) : KS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x352A52E3844EEDC;
        }
    }

    class KU(ulong val) : KT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x28613F601EB6900;
        }
    }

    class KV(ulong val) : KU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54DC068ACCADD93;
        }
    }

    class KW(ulong val) : KV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FDF126683D42B7;
        }
    }

    class KX(ulong val) : KW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x758C12A54B3029A;
        }
    }

    class KY(ulong val) : KX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19F34F333DAA72B;
        }
    }

    class KZ(ulong val) : KY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8EA589A62A6A298;
        }
    }

    class LA(ulong val) : KZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D63827488012B6;
        }
    }

    class LB(ulong val) : LA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D1D016658EA04B;
        }
    }

    class LC(ulong val) : LB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B9C95BCF376F36;
        }
    }

    class LD(ulong val) : LC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x524604B57399300;
        }
    }

    class LE(ulong val) : LD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x878D933DBB241D1;
        }
    }

    class LF(ulong val) : LE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C44FF2C3F8D172;
        }
    }

    class LG(ulong val) : LF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x38E5DAED1C8FCB3;
        }
    }

    class LH(ulong val) : LG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42396BAA4575166;
        }
    }

    class LI(ulong val) : LH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x46D575F3DC8E0D9;
        }
    }

    class LJ(ulong val) : LI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4023C3AB7C132AD;
        }
    }

    class LK(ulong val) : LJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x843AE6EBDA6AEC2;
        }
    }

    class LL(ulong val) : LK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DD7DB11380F6B9;
        }
    }

    class LM(ulong val) : LL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x90DA3415A6CC8D9;
        }
    }

    class LN(ulong val) : LM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x625798D1880AAAF;
        }
    }

    class LO(ulong val) : LN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x13AF2E6307DC334;
        }
    }

    class LP(ulong val) : LO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4583A29FBE70F2F;
        }
    }

    class LQ(ulong val) : LP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x776405351D2D9C1;
        }
    }

    class LR(ulong val) : LQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x843508FE6C17598;
        }
    }

    class LS(ulong val) : LR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x658914D60B31595;
        }
    }

    class LT(ulong val) : LS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B8C537AF4A8588;
        }
    }

    class LU(ulong val) : LT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8EBF466ACB8D503;
        }
    }

    class LV(ulong val) : LU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86D7AD3BA7F84C3;
        }
    }

    class LW(ulong val) : LV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x35794F81E69A2B5;
        }
    }

    class LX(ulong val) : LW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3E4AC460EB9A873;
        }
    }

    class LY(ulong val) : LX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4889A22184C05BE;
        }
    }

    class LZ(ulong val) : LY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x68F6BAD8BB70FB4;
        }
    }

    class MA(ulong val) : LZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x558E18AE1027110;
        }
    }

    class MB(ulong val) : MA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D44C7052096BA2;
        }
    }

    class MC(ulong val) : MB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5375D773107924E;
        }
    }

    class MD(ulong val) : MC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5930118FB630D9D;
        }
    }

    class ME(ulong val) : MD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x37447EB5FBA470D;
        }
    }

    class MF(ulong val) : ME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D2285176F748C5;
        }
    }

    class MG(ulong val) : MF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x533847C2FE75D70;
        }
    }

    class MH(ulong val) : MG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x613FD8D57AA8A88;
        }
    }

    class MI(ulong val) : MH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x25F48B899F802C0;
        }
    }

    class MJ(ulong val) : MI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5343D68B1E68A42;
        }
    }

    class MK(ulong val) : MJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12B590916F93739;
        }
    }

    class ML(ulong val) : MK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x775EE3270313088;
        }
    }

    class MM(ulong val) : ML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E8257FA2F7B4C9;
        }
    }

    class MN(ulong val) : MM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8E3ECC447D1B11B;
        }
    }

    class MO(ulong val) : MN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2759074C1DDB5ED;
        }
    }

    class MP(ulong val) : MO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x834FFC89EE855F1;
        }
    }

    class MQ(ulong val) : MP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A1BAA8732ECDD3;
        }
    }

    class MR(ulong val) : MQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x692A9A02300A779;
        }
    }

    class MS(ulong val) : MR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4B2C5F55F28E57C;
        }
    }

    class MT(ulong val) : MS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6F35989281C21B3;
        }
    }

    class MU(ulong val) : MT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B825D5B0D1630F;
        }
    }

    class MV(ulong val) : MU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7287227A111453F;
        }
    }

    class MW(ulong val) : MV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8889936DBF1E7F9;
        }
    }

    class MX(ulong val) : MW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x167FD9677865643;
        }
    }

    class MY(ulong val) : MX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3378AD6DD111973;
        }
    }

    class MZ(ulong val) : MY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x14E2B5FB46D3BAA;
        }
    }

    class NA(ulong val) : MZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48F5FB01075D590;
        }
    }

    class NB(ulong val) : NA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3C922B7E789D767;
        }
    }

    class NC(ulong val) : NB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x89C407B4A89B1FB;
        }
    }

    class ND(ulong val) : NC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A318F57D704935;
        }
    }

    class NE(ulong val) : ND(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34EDF5050309DA3;
        }
    }

    class NF(ulong val) : NE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D49EEA08FE5753;
        }
    }

    class NG(ulong val) : NF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6F5AFF309918602;
        }
    }

    class NH(ulong val) : NG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3E5DDE10E58331F;
        }
    }

    class NI(ulong val) : NH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x14642363E9B7E33;
        }
    }

    class NJ(ulong val) : NI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50AAF22D8A91FE1;
        }
    }

    class NK(ulong val) : NJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x883BB6AF32CE1D0;
        }
    }

    class NL(ulong val) : NK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E74FB0994EC46C;
        }
    }

    class NM(ulong val) : NL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70C88945407866B;
        }
    }

    class NN(ulong val) : NM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C0559583AF8E76;
        }
    }

    class NO(ulong val) : NN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x242FD5336AA5AD3;
        }
    }

    class NP(ulong val) : NO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x760EDEAA1F4A34D;
        }
    }

    class NQ(ulong val) : NP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x89491934028B0D9;
        }
    }

    class NR(ulong val) : NQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x52DB3ED290AB4E2;
        }
    }

    class NS(ulong val) : NR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7B5ACC2588E105D;
        }
    }

    class NT(ulong val) : NS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48FEA2AFA87981D;
        }
    }

    class NU(ulong val) : NT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x895DAE7E9421F5C;
        }
    }

    class NV(ulong val) : NU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55F934F406563CE;
        }
    }

    class NW(ulong val) : NV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x10AAD28EDFFBC92;
        }
    }

    class NX(ulong val) : NW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x298B6EF8400A3AA;
        }
    }

    class NY(ulong val) : NX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E580039F112D37;
        }
    }

    class NZ(ulong val) : NY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73C4635A496962C;
        }
    }

    class OA(ulong val) : NZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BFDD5B9C53682D;
        }
    }

    class OB(ulong val) : OA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x67EDDC985B85BB6;
        }
    }

    class OC(ulong val) : OB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39932CCE86C34F4;
        }
    }

    class OD(ulong val) : OC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x76516D1E2FCD7F1;
        }
    }

    class OE(ulong val) : OD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x165DCED262955CD;
        }
    }

    class OF(ulong val) : OE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A11769FFD42090;
        }
    }

    class OG(ulong val) : OF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7628922B81DD7F4;
        }
    }

    class OH(ulong val) : OG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x532B9E883CE730F;
        }
    }

    class OI(ulong val) : OH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D4D6CF4B7BC30D;
        }
    }

    class OJ(ulong val) : OI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6FF1DC0774E499A;
        }
    }

    class OK(ulong val) : OJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8201F01DE693723;
        }
    }

    class OL(ulong val) : OK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4099A0AA510BDA9;
        }
    }

    class OM(ulong val) : OL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x677862840A0BBD7;
        }
    }

    class ON(ulong val) : OM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82184E509B26CD6;
        }
    }

    class OO(ulong val) : ON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49DC968669E44EA;
        }
    }

    class OP(ulong val) : OO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x31ED0B7CE07B425;
        }
    }

    class OQ(ulong val) : OP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8A46F2E5D24CFB3;
        }
    }

    class OR(ulong val) : OQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94409116B595126;
        }
    }

    class OS(ulong val) : OR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x118E83C3AE04095;
        }
    }

    class OT(ulong val) : OS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45F0D708E038B54;
        }
    }

    class OU(ulong val) : OT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2CDDC3D4A577022;
        }
    }

    class OV(ulong val) : OU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3B78F731E0B6E4E;
        }
    }

    class OW(ulong val) : OV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x827C6E453C07F9B;
        }
    }

    class OX(ulong val) : OW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7EC52944770F7E9;
        }
    }

    class OY(ulong val) : OX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70908AE7AE79BBE;
        }
    }

    class OZ(ulong val) : OY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F39AA91691A56B;
        }
    }

    class PA(ulong val) : OZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4676779F2EF05D7;
        }
    }

    class PB(ulong val) : PA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F9EEED613E95E5;
        }
    }

    class PC(ulong val) : PB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1AAEB9DFE7D1215;
        }
    }

    class PD(ulong val) : PC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3231BE150125268;
        }
    }

    class PE(ulong val) : PD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8FFEA50286B77AE;
        }
    }

    class PF(ulong val) : PE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6F33888C6077CEA;
        }
    }

    class PG(ulong val) : PF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95249B2F5B85E04;
        }
    }

    class PH(ulong val) : PG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x937F8D790C90C8D;
        }
    }

    class PI(ulong val) : PH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3DE8B98ED71F43C;
        }
    }

    class PJ(ulong val) : PI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C2E5359DB39401;
        }
    }

    class PK(ulong val) : PJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x84A02D915D85544;
        }
    }

    class PL(ulong val) : PK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1ABA0D6E8D7249A;
        }
    }

    class PM(ulong val) : PL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D0BDFAAA0A76F7;
        }
    }

    class PN(ulong val) : PM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79B0722EBC55713;
        }
    }

    class PO(ulong val) : PN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3BE8F9E86102C2C;
        }
    }

    class PP(ulong val) : PO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x533E3793517C471;
        }
    }

    class PQ(ulong val) : PP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93A473494267107;
        }
    }

    class PR(ulong val) : PQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3971CD962BBBF7B;
        }
    }

    class PS(ulong val) : PR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x481418FF3DD2C70;
        }
    }

    class PT(ulong val) : PS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A847701BE97D19;
        }
    }

    class PU(ulong val) : PT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3835FD42263E339;
        }
    }

    class PV(ulong val) : PU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8C40E5515A6DCB2;
        }
    }

    class PW(ulong val) : PV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24F35C703363D6B;
        }
    }

    class PX(ulong val) : PW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1ADA16F101BE581;
        }
    }

    class PY(ulong val) : PX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7FA2B237AA4487C;
        }
    }

    class PZ(ulong val) : PY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x294DB735BE4D9FC;
        }
    }

    class QA(ulong val) : PZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x450B02533C6E465;
        }
    }

    class QB(ulong val) : QA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x753F3FED484890C;
        }
    }

    class QC(ulong val) : QB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x416B44421CB3BA2;
        }
    }

    class QD(ulong val) : QC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86482EBB90586BA;
        }
    }

    class QE(ulong val) : QD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3D5D7F1E685B76C;
        }
    }

    class QF(ulong val) : QE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28B2E3B5A8D0328;
        }
    }

    class QG(ulong val) : QF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A12CAEDECF8C4E;
        }
    }

    class QH(ulong val) : QG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C44802D3F14FE6;
        }
    }

    class QI(ulong val) : QH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x343B982E622FC77;
        }
    }

    class QJ(ulong val) : QI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x89F8061E15443BC;
        }
    }

    class QK(ulong val) : QJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A92E9A4C3B57AB;
        }
    }

    class QL(ulong val) : QK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58EDFB9E334E012;
        }
    }

    class QM(ulong val) : QL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D8CA6C3D31AA23;
        }
    }

    class QN(ulong val) : QM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x478A42EACB16BE4;
        }
    }

    class QO(ulong val) : QN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x75B3FB84F1701FB;
        }
    }

    class QP(ulong val) : QO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4ED6CABEDC2B9C8;
        }
    }

    class QQ(ulong val) : QP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x412F0E67747FDF4;
        }
    }

    class QR(ulong val) : QQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x826BC0A7F51EF53;
        }
    }

    class QS(ulong val) : QR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C99A418D2EE85F;
        }
    }

    class QT(ulong val) : QS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x27771608774B2D0;
        }
    }

    class QU(ulong val) : QT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A9E11094912AF0;
        }
    }

    class QV(ulong val) : QU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x515E36800344660;
        }
    }

    class QW(ulong val) : QV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D41C7E31BB3C11;
        }
    }

    class QX(ulong val) : QW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6131855ED5D50F3;
        }
    }

    class QY(ulong val) : QX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x130245E92B4FFAD;
        }
    }

    class QZ(ulong val) : QY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F2B097B915097F;
        }
    }

    class RA(ulong val) : QZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3145D6D866E5336;
        }
    }

    class RB(ulong val) : RA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x90135A58B176146;
        }
    }

    class RC(ulong val) : RB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4101F155E84D7F2;
        }
    }

    class RD(ulong val) : RC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E3162F7683EDE7;
        }
    }

    class RE(ulong val) : RD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89D38372672F74A;
        }
    }

    class RF(ulong val) : RE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x384F9D45EE7BC9B;
        }
    }

    class RG(ulong val) : RF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95CD7E968F9878D;
        }
    }

    class RH(ulong val) : RG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7171596AC17460A;
        }
    }

    class RI(ulong val) : RH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x38E05F1C58F31A3;
        }
    }

    class RJ(ulong val) : RI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F18A8B83069B3F;
        }
    }

    class RK(ulong val) : RJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8648B1208357824;
        }
    }

    class RL(ulong val) : RK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x463F547A6C7F80F;
        }
    }

    class RM(ulong val) : RL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x329E3A93F8E841E;
        }
    }

    class RN(ulong val) : RM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3A1E2935751CB7C;
        }
    }

    class RO(ulong val) : RN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79294D39B7DCF50;
        }
    }

    class RP(ulong val) : RO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D654F5E8F15B69;
        }
    }

    class RQ(ulong val) : RP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C26E4305559301;
        }
    }

    class RR(ulong val) : RQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D605989BD4BD14;
        }
    }

    class RS(ulong val) : RR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8DD8A05D464D46C;
        }
    }

    class RT(ulong val) : RS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D478ECAFDB2589;
        }
    }

    class RU(ulong val) : RT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x92E1C0EB04D8B95;
        }
    }

    class RV(ulong val) : RU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8713FAA2375245E;
        }
    }

    class RW(ulong val) : RV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x73D02ECE24CABCA;
        }
    }

    class RX(ulong val) : RW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5327E91E5DC4DF8;
        }
    }

    class RY(ulong val) : RX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D73F5EC8F8EC2E;
        }
    }

    class RZ(ulong val) : RY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x64D5DB04EB62488;
        }
    }

    class SA(ulong val) : RZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2D177483AE365FF;
        }
    }

    class SB(ulong val) : SA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x69E6ACBF55AC51A;
        }
    }

    class SC(ulong val) : SB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2C436B761A6976B;
        }
    }

    class SD(ulong val) : SC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CDDC47E3034599;
        }
    }

    class SE(ulong val) : SD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x915FCEA9A8AAD0A;
        }
    }

    class SF(ulong val) : SE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C21CE80F5B8B22;
        }
    }

    class SG(ulong val) : SF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74E66807508B521;
        }
    }

    class SH(ulong val) : SG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x956FD1693A1208C;
        }
    }

    class SI(ulong val) : SH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1353A332CE8C5C9;
        }
    }

    class SJ(ulong val) : SI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5232142E211C231;
        }
    }

    class SK(ulong val) : SJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7893ADDD6AE0D53;
        }
    }

    class SL(ulong val) : SK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9068213017153A6;
        }
    }

    class SM(ulong val) : SL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x182709AA9215276;
        }
    }

    class SN(ulong val) : SM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20C567E287B375B;
        }
    }

    class SO(ulong val) : SN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36BCF564D7A2BFB;
        }
    }

    class SP(ulong val) : SO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31E5F90D7AD1685;
        }
    }

    class SQ(ulong val) : SP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x156CA03489DB435;
        }
    }

    class SR(ulong val) : SQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8445E7F7E7614DF;
        }
    }

    class SS(ulong val) : SR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E4B40CC99DA659;
        }
    }

    class ST(ulong val) : SS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x559EE6832363032;
        }
    }

    class SU(ulong val) : ST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5880FA2F47EC45E;
        }
    }

    class SV(ulong val) : SU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79ABF9EF37C6846;
        }
    }

    class SW(ulong val) : SV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E0BF60453C9C59;
        }
    }

    class SX(ulong val) : SW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6050D319018B7E5;
        }
    }

    class SY(ulong val) : SX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x123C65797403857;
        }
    }

    class SZ(ulong val) : SY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x40A7980DD1F785D;
        }
    }

    class TA(ulong val) : SZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50EC61AD7468954;
        }
    }

    class TB(ulong val) : TA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x787848BCE99C3E5;
        }
    }

    class TC(ulong val) : TB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9842DE6DC89CC38;
        }
    }

    class TD(ulong val) : TC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x725081BBB764AF6;
        }
    }

    class TE(ulong val) : TD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81655F410D574C8;
        }
    }

    class TF(ulong val) : TE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34E28B3104F7B42;
        }
    }

    class TG(ulong val) : TF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x82E2559B7598A2B;
        }
    }

    class TH(ulong val) : TG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53E9932DEF7977C;
        }
    }

    class TI(ulong val) : TH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E73A157B4A82DF;
        }
    }

    class TJ(ulong val) : TI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x938D995E43D1F72;
        }
    }

    class TK(ulong val) : TJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C91D207F0E5B8E;
        }
    }

    class TL(ulong val) : TK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4DBFBF98FC881F7;
        }
    }

    class TM(ulong val) : TL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20325A01E76525C;
        }
    }

    class TN(ulong val) : TM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9623E90D7DED726;
        }
    }

    class TO(ulong val) : TN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15D9843E753BD4B;
        }
    }

    class TP(ulong val) : TO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7CA3C5A3AA175B5;
        }
    }

    class TQ(ulong val) : TP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x73B5C7CD5934589;
        }
    }

    class TR(ulong val) : TQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23E4D478A44E20D;
        }
    }

    class TS(ulong val) : TR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A66C4F38D2D58C;
        }
    }

    class TT(ulong val) : TS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E14046E629BE65;
        }
    }

    class TU(ulong val) : TT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C61C39B7EF1693;
        }
    }

    class TV(ulong val) : TU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2BFCF4395E2CE74;
        }
    }

    class TW(ulong val) : TV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43A854BBE5E24D1;
        }
    }

    class TX(ulong val) : TW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6B9DCB6FC12A87D;
        }
    }

    class TY(ulong val) : TX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B26B6C377AE81C;
        }
    }

    class TZ(ulong val) : TY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x959916DAFBC052C;
        }
    }

    class UA(ulong val) : TZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48B933B32397FA1;
        }
    }

    class UB(ulong val) : UA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x570A962B844DD5F;
        }
    }

    class UC(ulong val) : UB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x534D53731877E41;
        }
    }

    class UD(ulong val) : UC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x75ED0B0AC779F77;
        }
    }

    class UE(ulong val) : UD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7964F33F3F87225;
        }
    }

    class UF(ulong val) : UE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x166C834F06224C4;
        }
    }

    class UG(ulong val) : UF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x905EAD579E6AF0F;
        }
    }

    class UH(ulong val) : UG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x661A68A66626F6A;
        }
    }

    class UI(ulong val) : UH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27380C866BA08B8;
        }
    }

    class UJ(ulong val) : UI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A993CC51985D49;
        }
    }

    class UK(ulong val) : UJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x561892B8EED0A80;
        }
    }

    class UL(ulong val) : UK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x177071A6623DF8B;
        }
    }

    class UM(ulong val) : UL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B42AB94EA0347A;
        }
    }

    class UN(ulong val) : UM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x38C73F02E59B76B;
        }
    }

    class UO(ulong val) : UN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E3D08A893650AA;
        }
    }

    class UP(ulong val) : UO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8A98030B9F7CF53;
        }
    }

    class UQ(ulong val) : UP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x34BD18BC938E1DA;
        }
    }

    class UR(ulong val) : UQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91448D6CB577132;
        }
    }

    class US(ulong val) : UR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28BD2F14C41B343;
        }
    }

    class UT(ulong val) : US(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3CC0C5FA7DB41AC;
        }
    }

    class UU(ulong val) : UT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5B2E9863807B210;
        }
    }

    class UV(ulong val) : UU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6DE03D336D0C63E;
        }
    }

    class UW(ulong val) : UV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x686F8CCC68CCA18;
        }
    }

    class UX(ulong val) : UW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95E5BDFCD4069CE;
        }
    }

    class UY(ulong val) : UX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x284A90BBF87D8A6;
        }
    }

    class UZ(ulong val) : UY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x445103BCDF41657;
        }
    }

    class VA(ulong val) : UZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x522DE9F0AC34A26;
        }
    }

    class VB(ulong val) : VA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1102FF6A769D0ED;
        }
    }

    class VC(ulong val) : VB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A19B021D8A1ECF;
        }
    }

    class VD(ulong val) : VC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x869078D694C351B;
        }
    }

    class VE(ulong val) : VD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1FC8C0CDE584C1D;
        }
    }

    class VF(ulong val) : VE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46CB1545106EDEE;
        }
    }

    class VG(ulong val) : VF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x796CD832DFE5C0E;
        }
    }

    class VH(ulong val) : VG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A977F73DE24FF9;
        }
    }

    class VI(ulong val) : VH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26D3308581D9BEA;
        }
    }

    class VJ(ulong val) : VI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56BAFE61ACFFC39;
        }
    }

    class VK(ulong val) : VJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5141A57EDA55B67;
        }
    }

    class VL(ulong val) : VK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7C1A2413426E34A;
        }
    }

    class VM(ulong val) : VL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4144C62C821E755;
        }
    }

    class VN(ulong val) : VM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7EAF221E61B273B;
        }
    }

    class VO(ulong val) : VN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x54D9A3BD3BA20BF;
        }
    }

    class VP(ulong val) : VO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B6EBE4207EA42F;
        }
    }

    class VQ(ulong val) : VP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x131DDE8DEC59C57;
        }
    }

    class VR(ulong val) : VQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x44301AF6A460466;
        }
    }

    class VS(ulong val) : VR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E70D7C148DC210;
        }
    }

    class VT(ulong val) : VS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11F218AA7F673B9;
        }
    }

    class VU(ulong val) : VT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x772EE906614352D;
        }
    }

    class VV(ulong val) : VU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A5BCCF9E8AA427;
        }
    }

    class VW(ulong val) : VV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x975DA78EE9230CD;
        }
    }

    class VX(ulong val) : VW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x42B4D405E122749;
        }
    }

    class VY(ulong val) : VX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x909D1366F1B3F4C;
        }
    }

    class VZ(ulong val) : VY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8530CF297A9C804;
        }
    }

    class WA(ulong val) : VZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8806614B876FB10;
        }
    }

    class WB(ulong val) : WA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x561BD0D1014392F;
        }
    }

    class WC(ulong val) : WB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15904620770DDE8;
        }
    }

    class WD(ulong val) : WC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x370FEDEFFCBC657;
        }
    }

    class WE(ulong val) : WD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49898A2E1D22D25;
        }
    }

    class WF(ulong val) : WE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x522D62C8FD373F4;
        }
    }

    class WG(ulong val) : WF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B0EE0A7A2AE2AF;
        }
    }

    class WH(ulong val) : WG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1116AC53B034F4B;
        }
    }

    class WI(ulong val) : WH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x700D4CE67166AAC;
        }
    }

    class WJ(ulong val) : WI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x818D31B0A88EE25;
        }
    }

    class WK(ulong val) : WJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x73FD33E11616E03;
        }
    }

    class WL(ulong val) : WK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x420401834FCA1E3;
        }
    }

    class WM(ulong val) : WL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x693B54612372D62;
        }
    }

    class WN(ulong val) : WM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8D501AB0C5AF670;
        }
    }

    class WO(ulong val) : WN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x616E83686E86463;
        }
    }

    class WP(ulong val) : WO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x608FAAD76707377;
        }
    }

    class WQ(ulong val) : WP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3536CED2D6C631A;
        }
    }

    class WR(ulong val) : WQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x810D1DC6C3F59F8;
        }
    }

    class WS(ulong val) : WR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3F56650A1C2C1AB;
        }
    }

    class WT(ulong val) : WS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x639A877FB3315C3;
        }
    }

    class WU(ulong val) : WT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x685A372B651852F;
        }
    }

    class WV(ulong val) : WU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C3FDC687E172C1;
        }
    }

    class WW(ulong val) : WV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1954EFAD45AF506;
        }
    }

    class WX(ulong val) : WW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x397D21F8BE519F8;
        }
    }

    class WY(ulong val) : WX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x516DB02E1626302;
        }
    }

    class WZ(ulong val) : WY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A04C97D48B9CF1;
        }
    }

    class XA(ulong val) : WZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D1A659F4EF05E4;
        }
    }

    class XB(ulong val) : XA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x610C8D43E291C06;
        }
    }

    class XC(ulong val) : XB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2C659C65C8E1789;
        }
    }

    class XD(ulong val) : XC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x564D0457283EFCB;
        }
    }

    class XE(ulong val) : XD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x60C5AB392FCC133;
        }
    }

    class XF(ulong val) : XE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A8E976F4D607B4;
        }
    }

    class XG(ulong val) : XF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x764EA5DF7741B2F;
        }
    }

    class XH(ulong val) : XG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4570BC8A9237858;
        }
    }

    class XI(ulong val) : XH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E00C3A4C2732E2;
        }
    }

    class XJ(ulong val) : XI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A768640CE8868B;
        }
    }

    class XK(ulong val) : XJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6F1539F9E8E11B6;
        }
    }

    class XL(ulong val) : XK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39DB50B529F8D39;
        }
    }

    class XM(ulong val) : XL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x82472F8E99BB403;
        }
    }

    class XN(ulong val) : XM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27E9B885593C7EE;
        }
    }

    class XO(ulong val) : XN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36431848EC35077;
        }
    }

    class XP(ulong val) : XO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4DC154F0BDE9A60;
        }
    }

    class XQ(ulong val) : XP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6771F6AD56BB6EC;
        }
    }

    class XR(ulong val) : XQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5E3BC5742130A05;
        }
    }

    class XS(ulong val) : XR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79B74BD9B9B2DCB;
        }
    }

    class XT(ulong val) : XS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1549BE658874E9C;
        }
    }

    class XU(ulong val) : XT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56C4034FB99CB12;
        }
    }

    class XV(ulong val) : XU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AEDC339C1AF75A;
        }
    }

    class XW(ulong val) : XV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2B787431C582B79;
        }
    }

    class XX(ulong val) : XW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3ED2980567B6A2B;
        }
    }

    class XY(ulong val) : XX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BE8791915E0FAE;
        }
    }

    class XZ(ulong val) : XY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x33865397FA96519;
        }
    }

    class YA(ulong val) : XZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x538C78F8E223350;
        }
    }

    class YB(ulong val) : YA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3CCEF8CE8C3FBFD;
        }
    }

    class YC(ulong val) : YB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F908F195E453F8;
        }
    }

    class YD(ulong val) : YC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2975046E13DD824;
        }
    }

    class YE(ulong val) : YD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x244665D0DA9D32B;
        }
    }

    class YF(ulong val) : YE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6CD6919E924E10B;
        }
    }

    class YG(ulong val) : YF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x983DD4AE2A83FFD;
        }
    }

    class YH(ulong val) : YG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73FD00F4841FEBB;
        }
    }

    class YI(ulong val) : YH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x561443BECA7DFA8;
        }
    }

    class YJ(ulong val) : YI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20FB4D357B6B4C8;
        }
    }

    class YK(ulong val) : YJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x830F6537C0FEA3F;
        }
    }

    class YL(ulong val) : YK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2DD29A730D87831;
        }
    }

    class YM(ulong val) : YL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47E0F694EE5516B;
        }
    }

    class YN(ulong val) : YM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x706FA71B352C4D6;
        }
    }

    class YO(ulong val) : YN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26632CF48EAE133;
        }
    }

    class YP(ulong val) : YO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x900B0AB8D0467D3;
        }
    }

    class YQ(ulong val) : YP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4EED93D4FEF9BD5;
        }
    }

    class YR(ulong val) : YQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93B3453549A49D4;
        }
    }

    class YS(ulong val) : YR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19E52DDFE789029;
        }
    }

    class YT(ulong val) : YS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x386EAD77194E707;
        }
    }

    class YU(ulong val) : YT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D38DC0902FE0CA;
        }
    }

    class YV(ulong val) : YU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91884F31695D867;
        }
    }

    class YW(ulong val) : YV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B9EF979A95F844;
        }
    }

    class YX(ulong val) : YW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CE3877E824263C;
        }
    }

    class YY(ulong val) : YX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x749B6460A7709B4;
        }
    }

    class YZ(ulong val) : YY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C464DDD130D6F0;
        }
    }

    class ZA(ulong val) : YZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x62AB338D8431778;
        }
    }

    class ZB(ulong val) : ZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x773BE145B802191;
        }
    }

    class ZC(ulong val) : ZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x416B3605A6DB1A7;
        }
    }

    class ZD(ulong val) : ZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4EBCA5051CE4414;
        }
    }

    class ZE(ulong val) : ZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1DB2CCAB005620A;
        }
    }

    class ZF(ulong val) : ZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3FE52F4A13D8B03;
        }
    }

    class ZG(ulong val) : ZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6216CF7536B763A;
        }
    }

    class ZH(ulong val) : ZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1124DE3B0A2AE9D;
        }
    }

    class ZI(ulong val) : ZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9673AB2B2AD239C;
        }
    }

    class ZJ(ulong val) : ZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D657EC3964E374;
        }
    }

    class ZK(ulong val) : ZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3ED3DF149496954;
        }
    }

    class ZL(ulong val) : ZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77A972D30BD0959;
        }
    }

    class ZM(ulong val) : ZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1EF176444CDC60D;
        }
    }

    class ZN(ulong val) : ZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7311865B10772E7;
        }
    }

    class ZO(ulong val) : ZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1994F57CC02BAB3;
        }
    }

    class ZP(ulong val) : ZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x51828A012425CB0;
        }
    }

    class ZQ(ulong val) : ZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x200E51CF783AF5F;
        }
    }

    class ZR(ulong val) : ZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67015ECCE4CADF5;
        }
    }

    class ZS(ulong val) : ZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64B89FB074353D5;
        }
    }

    class ZT(ulong val) : ZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B36FBD11C0C268;
        }
    }

    class ZU(ulong val) : ZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E5658360CFF000;
        }
    }

    class ZV(ulong val) : ZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x191FCF33407E8B7;
        }
    }

    class ZW(ulong val) : ZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A935CA55E2E2B3;
        }
    }

    class ZX(ulong val) : ZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x263B5326886E875;
        }
    }

    class ZY(ulong val) : ZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x959F899546DABF0;
        }
    }

    class ZZ(ulong val) : ZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7797B4253C350DB;
        }
    }

    class AAA(ulong val) : ZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x14AD1B8E5DEED5C;
        }
    }

    class AAB(ulong val) : AAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73195D0CB15A4A6;
        }
    }

    class AAC(ulong val) : AAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26F97E94AAAA46E;
        }
    }

    class AAD(ulong val) : AAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36D907D455A48E2;
        }
    }

    class AAE(ulong val) : AAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x356472464D15BB5;
        }
    }

    class AAF(ulong val) : AAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5D5F38D31B05E3B;
        }
    }

    class AAG(ulong val) : AAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C6A4387F36B6E9;
        }
    }

    class AAH(ulong val) : AAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x69FA31429F84721;
        }
    }

    class AAI(ulong val) : AAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7277D99053A9F40;
        }
    }

    class AAJ(ulong val) : AAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x84BC819183290E6;
        }
    }

    class AAK(ulong val) : AAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x55F5672A5D64D25;
        }
    }

    class AAL(ulong val) : AAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x24FBF6828CAC567;
        }
    }

    class AAM(ulong val) : AAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x95FEE8A00C5791C;
        }
    }

    class AAN(ulong val) : AAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x19D28647A09BFB0;
        }
    }

    class AAO(ulong val) : AAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x525F83D9DAF33CC;
        }
    }

    class AAP(ulong val) : AAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4C6CAFA452B0ABE;
        }
    }

    class AAQ(ulong val) : AAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A53813FF4ADF6F;
        }
    }

    class AAR(ulong val) : AAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x66831AE6D4EDFA7;
        }
    }

    class AAS(ulong val) : AAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63C5E7DDB686D2B;
        }
    }

    class AAT(ulong val) : AAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x46713A226D8DAC4;
        }
    }

    class AAU(ulong val) : AAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1954537185085BA;
        }
    }

    class AAV(ulong val) : AAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4FCAE72A805E066;
        }
    }

    class AAW(ulong val) : AAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16026C192910723;
        }
    }

    class AAX(ulong val) : AAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F876824E90402B;
        }
    }

    class AAY(ulong val) : AAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25075948797230E;
        }
    }

    class AAZ(ulong val) : AAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x426550F83344609;
        }
    }

    class ABA(ulong val) : AAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5FE02D8FEECE2B8;
        }
    }

    class ABB(ulong val) : ABA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20C7D566E32CFE9;
        }
    }

    class ABC(ulong val) : ABB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7ADD6EB212D71F8;
        }
    }

    class ABD(ulong val) : ABC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5B4CCA2D05241BC;
        }
    }

    class ABE(ulong val) : ABD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3467960C61D15BA;
        }
    }

    class ABF(ulong val) : ABE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1DC8CDEBDD5F7E4;
        }
    }

    class ABG(ulong val) : ABF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2214650A174111B;
        }
    }

    class ABH(ulong val) : ABG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DB1AA179EDFAB5;
        }
    }

    class ABI(ulong val) : ABH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A9F5E62EE42DCF;
        }
    }

    class ABJ(ulong val) : ABI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E29F31372112D1;
        }
    }

    class ABK(ulong val) : ABJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42C2E10FFD14EAD;
        }
    }

    class ABL(ulong val) : ABK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18ED7AFA278176D;
        }
    }

    class ABM(ulong val) : ABL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46900AEF5F52A51;
        }
    }

    class ABN(ulong val) : ABM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54FD98E3C25453B;
        }
    }

    class ABO(ulong val) : ABN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1697A320077F097;
        }
    }

    class ABP(ulong val) : ABO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60032031CD9B7C0;
        }
    }

    class ABQ(ulong val) : ABP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x956F6607758380C;
        }
    }

    class ABR(ulong val) : ABQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89B56DE7ACF1F94;
        }
    }

    class ABS(ulong val) : ABR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6BDD45CAA804CD9;
        }
    }

    class ABT(ulong val) : ABS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x568D7FDF822378F;
        }
    }

    class ABU(ulong val) : ABT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72B9B195FF516CB;
        }
    }

    class ABV(ulong val) : ABU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D84385B0125E21;
        }
    }

    class ABW(ulong val) : ABV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x440603446125BD4;
        }
    }

    class ABX(ulong val) : ABW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x37AAA2E25035340;
        }
    }

    class ABY(ulong val) : ABX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x75F73052460682D;
        }
    }

    class ABZ(ulong val) : ABY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3407957A1FFACE4;
        }
    }

    class ACA(ulong val) : ABZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5F903A9EF9F56C3;
        }
    }

    class ACB(ulong val) : ACA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4584B4C3D88C65D;
        }
    }

    class ACC(ulong val) : ACB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87229647A383BE1;
        }
    }

    class ACD(ulong val) : ACC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7678F70A29C724B;
        }
    }

    class ACE(ulong val) : ACD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x58D70A76820F53F;
        }
    }

    class ACF(ulong val) : ACE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55BC16BD1F51469;
        }
    }

    class ACG(ulong val) : ACF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54628294C408BAD;
        }
    }

    class ACH(ulong val) : ACG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D89F434155DB45;
        }
    }

    class ACI(ulong val) : ACH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x32A648DFC4AC377;
        }
    }

    class ACJ(ulong val) : ACI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8A43EE0D809BE3D;
        }
    }

    class ACK(ulong val) : ACJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1807A3D25B60CC8;
        }
    }

    class ACL(ulong val) : ACK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3660D97FB4D5C19;
        }
    }

    class ACM(ulong val) : ACL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E4E141A14AD0AC;
        }
    }

    class ACN(ulong val) : ACM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x26B1D510E958ADF;
        }
    }

    class ACO(ulong val) : ACN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3DFBC2C2E6708D7;
        }
    }

    class ACP(ulong val) : ACO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C480E66852DC66;
        }
    }

    class ACQ(ulong val) : ACP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78D1604AB02376F;
        }
    }

    class ACR(ulong val) : ACQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FDB4CE17CA49DB;
        }
    }

    class ACS(ulong val) : ACR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x15CA4279D8AEA0B;
        }
    }

    class ACT(ulong val) : ACS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57AF1F276280909;
        }
    }

    class ACU(ulong val) : ACT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x66E9B14D3DE5071;
        }
    }

    class ACV(ulong val) : ACU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x519F03282A12CD0;
        }
    }

    class ACW(ulong val) : ACV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7FED9A0A79CAE7B;
        }
    }

    class ACX(ulong val) : ACW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C53DBADF1CD013;
        }
    }

    class ACY(ulong val) : ACX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E363708BFE84C9;
        }
    }

    class ACZ(ulong val) : ACY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5D2406B0AC31086;
        }
    }

    class ADA(ulong val) : ACZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5D6BC5057F374DB;
        }
    }

    class ADB(ulong val) : ADA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FB4A29D72DFE94;
        }
    }

    class ADC(ulong val) : ADB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x22096DF2E360F92;
        }
    }

    class ADD(ulong val) : ADC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x652967752B7BB4A;
        }
    }

    class ADE(ulong val) : ADD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x13C853298E2A653;
        }
    }

    class ADF(ulong val) : ADE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54FB9E70B2DB269;
        }
    }

    class ADG(ulong val) : ADF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x89C8DD4F6C25643;
        }
    }

    class ADH(ulong val) : ADG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x76D9C068E512E07;
        }
    }

    class ADI(ulong val) : ADH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8629D911E95D903;
        }
    }

    class ADJ(ulong val) : ADI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x14608B10619FEC3;
        }
    }

    class ADK(ulong val) : ADJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71428B051DD938E;
        }
    }

    class ADL(ulong val) : ADK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x280772E49C04D24;
        }
    }

    class ADM(ulong val) : ADL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x37C752BA1ED7990;
        }
    }

    class ADN(ulong val) : ADM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56DA1AB8570FF3F;
        }
    }

    class ADO(ulong val) : ADN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x75CDC5C651759A7;
        }
    }

    class ADP(ulong val) : ADO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A941692D8875BA;
        }
    }

    class ADQ(ulong val) : ADP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D6349E6DD4455C;
        }
    }

    class ADR(ulong val) : ADQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4CB9CE523116196;
        }
    }

    class ADS(ulong val) : ADR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27872DBB5D528BE;
        }
    }

    class ADT(ulong val) : ADS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x77077D509096A2F;
        }
    }

    class ADU(ulong val) : ADT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x726B063D8F81445;
        }
    }

    class ADV(ulong val) : ADU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x43CAB67CCB8F85B;
        }
    }

    class ADW(ulong val) : ADV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x76E647DBD6EE79F;
        }
    }

    class ADX(ulong val) : ADW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17C399B2B3E4837;
        }
    }

    class ADY(ulong val) : ADX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x986637F784AF3E9;
        }
    }

    class ADZ(ulong val) : ADY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x770FE20DBE611CA;
        }
    }

    class AEA(ulong val) : ADZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x148C2664C4F95D8;
        }
    }

    class AEB(ulong val) : AEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x79F9A49A26559EF;
        }
    }

    class AEC(ulong val) : AEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7CDBF668BAFFC77;
        }
    }

    class AED(ulong val) : AEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x781C1A99D9B9F11;
        }
    }

    class AEE(ulong val) : AED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71CF600CB0F9DB5;
        }
    }

    class AEF(ulong val) : AEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E36EFEC96092D8;
        }
    }

    class AEG(ulong val) : AEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x232E7B08035E19A;
        }
    }

    class AEH(ulong val) : AEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x84C174F4761FCCC;
        }
    }

    class AEI(ulong val) : AEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x146CF922B557C22;
        }
    }

    class AEJ(ulong val) : AEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F14F308E15E7A5;
        }
    }

    class AEK(ulong val) : AEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91EE1CF7AD190E0;
        }
    }

    class AEL(ulong val) : AEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x240691F5B958DF8;
        }
    }

    class AEM(ulong val) : AEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5952BACC1E3EE74;
        }
    }

    class AEN(ulong val) : AEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x10AC7E317B1F005;
        }
    }

    class AEO(ulong val) : AEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4DFE1B0764D70A0;
        }
    }

    class AEP(ulong val) : AEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x14222CB8620CD25;
        }
    }

    class AEQ(ulong val) : AEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5D98493380967D0;
        }
    }

    class AER(ulong val) : AEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x423117819834E6A;
        }
    }

    class AES(ulong val) : AER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x397E5C4242103FE;
        }
    }

    class AET(ulong val) : AES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B104BD52DFC966;
        }
    }

    class AEU(ulong val) : AET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58801B2675F4E4E;
        }
    }

    class AEV(ulong val) : AEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1E94E1E435BBC9F;
        }
    }

    class AEW(ulong val) : AEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x51CBF0FC2248F2B;
        }
    }

    class AEX(ulong val) : AEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21EFEC4DC02721A;
        }
    }

    class AEY(ulong val) : AEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x312C35003DCE0A7;
        }
    }

    class AEZ(ulong val) : AEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x47D9AA1370CE999;
        }
    }

    class AFA(ulong val) : AEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2D7BE9666E3FFDE;
        }
    }

    class AFB(ulong val) : AFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x65424C870EA189F;
        }
    }

    class AFC(ulong val) : AFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E86FD01F9DEC84;
        }
    }

    class AFD(ulong val) : AFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A6CD4E03F628D5;
        }
    }

    class AFE(ulong val) : AFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F078C8EFD0ABD4;
        }
    }

    class AFF(ulong val) : AFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B7AEC3A4CB57E5;
        }
    }

    class AFG(ulong val) : AFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x561E4295D23A656;
        }
    }

    class AFH(ulong val) : AFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E1C6D75F049DB5;
        }
    }

    class AFI(ulong val) : AFH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7CDADFCBBE0782E;
        }
    }

    class AFJ(ulong val) : AFI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x10A70046EE6FF2D;
        }
    }

    class AFK(ulong val) : AFJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x47359DE64A6152E;
        }
    }

    class AFL(ulong val) : AFK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85F597878243ADD;
        }
    }

    class AFM(ulong val) : AFL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F8F34381F37E40;
        }
    }

    class AFN(ulong val) : AFM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BD6DE19EDB5CEC;
        }
    }

    class AFO(ulong val) : AFN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F737C108719AFA;
        }
    }

    class AFP(ulong val) : AFO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x358EE4504240A86;
        }
    }

    class AFQ(ulong val) : AFP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77F68760D00F923;
        }
    }

    class AFR(ulong val) : AFQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7BFBC10788F5D75;
        }
    }

    class AFS(ulong val) : AFR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D1472A717A749E;
        }
    }

    class AFT(ulong val) : AFS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5AEB6AE29012C0F;
        }
    }

    class AFU(ulong val) : AFT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3428A5B7D3AB2FB;
        }
    }

    class AFV(ulong val) : AFU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x21DCE92DA415FD0;
        }
    }

    class AFW(ulong val) : AFV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x735D675875AD4B1;
        }
    }

    class AFX(ulong val) : AFW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E00C793DA55DDB;
        }
    }

    class AFY(ulong val) : AFX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8621AD07E6DD4A4;
        }
    }

    class AFZ(ulong val) : AFY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x72D382535BA1B62;
        }
    }

    class AGA(ulong val) : AFZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x58FA5290A5A912C;
        }
    }

    class AGB(ulong val) : AGA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1EEBF95F6436DBC;
        }
    }

    class AGC(ulong val) : AGB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4710FF53AA6DC2E;
        }
    }

    class AGD(ulong val) : AGC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x465B3839AA12C22;
        }
    }

    class AGE(ulong val) : AGD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x185A2926F41BE5D;
        }
    }

    class AGF(ulong val) : AGE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x97B03F88C6CD43A;
        }
    }

    class AGG(ulong val) : AGF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57CB0F1B189C576;
        }
    }

    class AGH(ulong val) : AGG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42205E2C43DEEDC;
        }
    }

    class AGI(ulong val) : AGH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x661D39B0CCF7810;
        }
    }

    class AGJ(ulong val) : AGI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6061944A10EE3CE;
        }
    }

    class AGK(ulong val) : AGJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55A23F46F3F5A42;
        }
    }

    class AGL(ulong val) : AGK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x711C92ED5A6C333;
        }
    }

    class AGM(ulong val) : AGL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x611FF3BB3854D54;
        }
    }

    class AGN(ulong val) : AGM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A0894E48D49E36;
        }
    }

    class AGO(ulong val) : AGN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2886866955D3E6A;
        }
    }

    class AGP(ulong val) : AGO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8238711A2B65132;
        }
    }

    class AGQ(ulong val) : AGP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91661F78D88043B;
        }
    }

    class AGR(ulong val) : AGQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2859CF25CC4548D;
        }
    }

    class AGS(ulong val) : AGR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F00BC9DB4BC3F0;
        }
    }

    class AGT(ulong val) : AGS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3B95E551BD1E5D8;
        }
    }

    class AGU(ulong val) : AGT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23DE83A2AC1AE1B;
        }
    }

    class AGV(ulong val) : AGU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x573F09195902CC8;
        }
    }

    class AGW(ulong val) : AGV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E06EDE51E50C37;
        }
    }

    class AGX(ulong val) : AGW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48273DF473F2670;
        }
    }

    class AGY(ulong val) : AGX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3EF06B9FEA15542;
        }
    }

    class AGZ(ulong val) : AGY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7396624719C6E13;
        }
    }

    class AHA(ulong val) : AGZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x90AB6187DEBF005;
        }
    }

    class AHB(ulong val) : AHA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C69236A890B8DC;
        }
    }

    class AHC(ulong val) : AHB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4034E2F5AA83771;
        }
    }

    class AHD(ulong val) : AHC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6F942791908CEE8;
        }
    }

    class AHE(ulong val) : AHD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x44973E37DE87748;
        }
    }

    class AHF(ulong val) : AHE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7AD3655A77B8B18;
        }
    }

    class AHG(ulong val) : AHF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A6EEE87381667A;
        }
    }

    class AHH(ulong val) : AHG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x411D79238C707A4;
        }
    }

    class AHI(ulong val) : AHH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5C27E7625188EC0;
        }
    }

    class AHJ(ulong val) : AHI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x387384936C70F95;
        }
    }

    class AHK(ulong val) : AHJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x69C4DE838BCCA4F;
        }
    }

    class AHL(ulong val) : AHK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C4FC5E37A95880;
        }
    }

    class AHM(ulong val) : AHL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A5CD8E536A4AD4;
        }
    }

    class AHN(ulong val) : AHM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1E19E6B5D79DCF7;
        }
    }

    class AHO(ulong val) : AHN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x19F1BE3152CEB1B;
        }
    }

    class AHP(ulong val) : AHO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5F7064A4274D99A;
        }
    }

    class AHQ(ulong val) : AHP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F38E77F8010DB6;
        }
    }

    class AHR(ulong val) : AHQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4FDC535722EA219;
        }
    }

    class AHS(ulong val) : AHR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C7F38B5F047B4E;
        }
    }

    class AHT(ulong val) : AHS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7887B2E2A57E902;
        }
    }

    class AHU(ulong val) : AHT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C83B83B948302C;
        }
    }

    class AHV(ulong val) : AHU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94FA70770D1BFB6;
        }
    }

    class AHW(ulong val) : AHV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x796C74F25A54A03;
        }
    }

    class AHX(ulong val) : AHW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1D0E81091F34CC0;
        }
    }

    class AHY(ulong val) : AHX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80577E1A1AC53C3;
        }
    }

    class AHZ(ulong val) : AHY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x945FDF955231015;
        }
    }

    class AIA(ulong val) : AHZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B024DAA28BEEBF;
        }
    }

    class AIB(ulong val) : AIA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x104577E3EB90165;
        }
    }

    class AIC(ulong val) : AIB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x213DE96FEC66873;
        }
    }

    class AID(ulong val) : AIC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CB0ED33D0BC48E;
        }
    }

    class AIE(ulong val) : AID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CB1B56C7052BE5;
        }
    }

    class AIF(ulong val) : AIE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31446CE7F70D074;
        }
    }

    class AIG(ulong val) : AIF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A44BC80B870AA4;
        }
    }

    class AIH(ulong val) : AIG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4D4115E61CA741E;
        }
    }

    class AII(ulong val) : AIH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x65B08EEF1799875;
        }
    }

    class AIJ(ulong val) : AII(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x925D969131C97CF;
        }
    }

    class AIK(ulong val) : AIJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E769FDC1967EEC;
        }
    }

    class AIL(ulong val) : AIK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x105C1AF7EE2F903;
        }
    }

    class AIM(ulong val) : AIL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x466C0D88EEDE902;
        }
    }

    class AIN(ulong val) : AIM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16A5BFCFE9D8CCD;
        }
    }

    class AIO(ulong val) : AIN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x102C8DB9BD5F8D7;
        }
    }

    class AIP(ulong val) : AIO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D997969CF93FF2;
        }
    }

    class AIQ(ulong val) : AIP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8FAA448F407008C;
        }
    }

    class AIR(ulong val) : AIQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E7E241EB640A81;
        }
    }

    class AIS(ulong val) : AIR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16E917784E64B07;
        }
    }

    class AIT(ulong val) : AIS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8EF5FB7B92B8122;
        }
    }

    class AIU(ulong val) : AIT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x267BB8F87C1470F;
        }
    }

    class AIV(ulong val) : AIU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C910C166886D8C;
        }
    }

    class AIW(ulong val) : AIV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x42450E98C367EF0;
        }
    }

    class AIX(ulong val) : AIW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x52D3CBCC437F7DC;
        }
    }

    class AIY(ulong val) : AIX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FE7290C3B57B06;
        }
    }

    class AIZ(ulong val) : AIY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5743916A0E8BE80;
        }
    }

    class AJA(ulong val) : AIZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x37DDE19F2940EE9;
        }
    }

    class AJB(ulong val) : AJA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2B57509FD9FC6A5;
        }
    }

    class AJC(ulong val) : AJB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x38C78066C60A34C;
        }
    }

    class AJD(ulong val) : AJC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x40DCB2C516980B7;
        }
    }

    class AJE(ulong val) : AJD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9754378F551FEB2;
        }
    }

    class AJF(ulong val) : AJE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1432132A10280CC;
        }
    }

    class AJG(ulong val) : AJF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4586239ADDA6DC5;
        }
    }

    class AJH(ulong val) : AJG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3816D8F7667A17D;
        }
    }

    class AJI(ulong val) : AJH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23EE92E1A2BFFF5;
        }
    }

    class AJJ(ulong val) : AJI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x955FEF0707D54CC;
        }
    }

    class AJK(ulong val) : AJJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C1F2371AC6EAAF;
        }
    }

    class AJL(ulong val) : AJK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8B868A8FCAB2393;
        }
    }

    class AJM(ulong val) : AJL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D88A66D2B7768D;
        }
    }

    class AJN(ulong val) : AJM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x348F40D8076EED3;
        }
    }

    class AJO(ulong val) : AJN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CBFB16F467EF78;
        }
    }

    class AJP(ulong val) : AJO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2CF4419C9A3BDE4;
        }
    }

    class AJQ(ulong val) : AJP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5C9DC4A7E02A76A;
        }
    }

    class AJR(ulong val) : AJQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x693DFD4969A9D09;
        }
    }

    class AJS(ulong val) : AJR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C2F75BBC329603;
        }
    }

    class AJT(ulong val) : AJS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4FE93FFC6CFB25D;
        }
    }

    class AJU(ulong val) : AJT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F9DB028B9C372A;
        }
    }

    class AJV(ulong val) : AJU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x88E2261222A8B1F;
        }
    }

    class AJW(ulong val) : AJV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E7CBAF80F94400;
        }
    }

    class AJX(ulong val) : AJW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x51EDABAF1175CA9;
        }
    }

    class AJY(ulong val) : AJX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x364DB588FB4CBA9;
        }
    }

    class AJZ(ulong val) : AJY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x279659024A415E5;
        }
    }

    class AKA(ulong val) : AJZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6024E263E1F191D;
        }
    }

    class AKB(ulong val) : AKA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8207AACB8158046;
        }
    }

    class AKC(ulong val) : AKB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A494553630C9C3;
        }
    }

    class AKD(ulong val) : AKC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50B548D04289A94;
        }
    }

    class AKE(ulong val) : AKD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x488D969B6C52C89;
        }
    }

    class AKF(ulong val) : AKE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x85158E49D29D968;
        }
    }

    class AKG(ulong val) : AKF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x563891F48BDF041;
        }
    }

    class AKH(ulong val) : AKG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E579D2ACF67777;
        }
    }

    class AKI(ulong val) : AKH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27C48CD05F34640;
        }
    }

    class AKJ(ulong val) : AKI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3304610C3E83CF3;
        }
    }

    class AKK(ulong val) : AKJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70F846FFBDC2FA3;
        }
    }

    class AKL(ulong val) : AKK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2CF68DFFDC15DE9;
        }
    }

    class AKM(ulong val) : AKL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7FEEB7E9FAD27EA;
        }
    }

    class AKN(ulong val) : AKM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x37F65607D5303AE;
        }
    }

    class AKO(ulong val) : AKN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C280912851F312;
        }
    }

    class AKP(ulong val) : AKO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3F1F780733501A3;
        }
    }

    class AKQ(ulong val) : AKP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AE0A62B50FB7DB;
        }
    }

    class AKR(ulong val) : AKQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6185FF19E32CD6A;
        }
    }

    class AKS(ulong val) : AKR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D4FFB82476AADB;
        }
    }

    class AKT(ulong val) : AKS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A3C99B6C7BB88F;
        }
    }

    class AKU(ulong val) : AKT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4E4A08325C3F94D;
        }
    }

    class AKV(ulong val) : AKU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88EE3ABF96418EE;
        }
    }

    class AKW(ulong val) : AKV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1704EEE208C45F8;
        }
    }

    class AKX(ulong val) : AKW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3E26915BEB40175;
        }
    }

    class AKY(ulong val) : AKX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5DB3621D83E1596;
        }
    }

    class AKZ(ulong val) : AKY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x236B6F0F9CE2B50;
        }
    }

    class ALA(ulong val) : AKZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92C37447839E049;
        }
    }

    class ALB(ulong val) : ALA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F3B38D549038F8;
        }
    }

    class ALC(ulong val) : ALB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93B2242E80AB53C;
        }
    }

    class ALD(ulong val) : ALC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5817748A73311D0;
        }
    }

    class ALE(ulong val) : ALD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x71DF373B8E674B1;
        }
    }

    class ALF(ulong val) : ALE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80843B7BB80B4A5;
        }
    }

    class ALG(ulong val) : ALF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2FCD4EBF2473CFC;
        }
    }

    class ALH(ulong val) : ALG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A40C9DBED2A6EE;
        }
    }

    class ALI(ulong val) : ALH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5525F060EA063C6;
        }
    }

    class ALJ(ulong val) : ALI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x76392AFB506B29B;
        }
    }

    class ALK(ulong val) : ALJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x309696F539186D6;
        }
    }

    class ALL(ulong val) : ALK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C0DC24C1D79C30;
        }
    }

    class ALM(ulong val) : ALL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x30D54CD60168479;
        }
    }

    class ALN(ulong val) : ALM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x13583FC5FF0CE25;
        }
    }

    class ALO(ulong val) : ALN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3FC810AD4713942;
        }
    }

    class ALP(ulong val) : ALO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x59ABAA09002F4F0;
        }
    }

    class ALQ(ulong val) : ALP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x47222D17B2372D8;
        }
    }

    class ALR(ulong val) : ALQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3287FA0A23DCDE8;
        }
    }

    class ALS(ulong val) : ALR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CDC1E5C3E9EEAD;
        }
    }

    class ALT(ulong val) : ALS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4307960F3D0E854;
        }
    }

    class ALU(ulong val) : ALT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47A11282A533628;
        }
    }

    class ALV(ulong val) : ALU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E88F5B5B418B48;
        }
    }

    class ALW(ulong val) : ALV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5163D47ADB602A5;
        }
    }

    class ALX(ulong val) : ALW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1220D318A97BA9C;
        }
    }

    class ALY(ulong val) : ALX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x479FE055977A67E;
        }
    }

    class ALZ(ulong val) : ALY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77C92693D34F4F8;
        }
    }

    class AMA(ulong val) : ALZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87B99084A74335F;
        }
    }

    class AMB(ulong val) : AMA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17E4403BF63652A;
        }
    }

    class AMC(ulong val) : AMB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25D7FFF443AC98C;
        }
    }

    class AMD(ulong val) : AMC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7F30F02244E4C73;
        }
    }

    class AME(ulong val) : AMD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48DCC5EF7B20224;
        }
    }

    class AMF(ulong val) : AME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E39CBBE13BA0C0;
        }
    }

    class AMG(ulong val) : AMF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C3FF84C0525864;
        }
    }

    class AMH(ulong val) : AMG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x27D9F66E15DF93B;
        }
    }

    class AMI(ulong val) : AMH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11A7A0E245F7117;
        }
    }

    class AMJ(ulong val) : AMI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x703001D0B5A0C07;
        }
    }

    class AMK(ulong val) : AMJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6B13931CA7DD3E7;
        }
    }

    class AML(ulong val) : AMK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1557A6832265CAC;
        }
    }

    class AMM(ulong val) : AML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1852A5FAFD3F1F6;
        }
    }

    class AMN(ulong val) : AMM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B318F235A38677;
        }
    }

    class AMO(ulong val) : AMN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78A173E04D76C8B;
        }
    }

    class AMP(ulong val) : AMO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x479F5E091A6186C;
        }
    }

    class AMQ(ulong val) : AMP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54A6916E6B81CA2;
        }
    }

    class AMR(ulong val) : AMQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16DA4A73679EB35;
        }
    }

    class AMS(ulong val) : AMR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1452CD747D541C6;
        }
    }

    class AMT(ulong val) : AMS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x956FA16DFFACAC3;
        }
    }

    class AMU(ulong val) : AMT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96DE8EE4DEA1470;
        }
    }

    class AMV(ulong val) : AMU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E0780DE43155FC;
        }
    }

    class AMW(ulong val) : AMV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53FF0F0F12406D9;
        }
    }

    class AMX(ulong val) : AMW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3845A7BF9B72FA0;
        }
    }

    class AMY(ulong val) : AMX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3705AFFD54AC2FC;
        }
    }

    class AMZ(ulong val) : AMY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80D0E5D2E1B1DCF;
        }
    }

    class ANA(ulong val) : AMZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3BD60907405C040;
        }
    }

    class ANB(ulong val) : ANA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x771A8CBEB1A2A51;
        }
    }

    class ANC(ulong val) : ANB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8029B87E85729F6;
        }
    }

    class AND(ulong val) : ANC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72F643290846639;
        }
    }

    class ANE(ulong val) : AND(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x957FB6E040A782A;
        }
    }

    class ANF(ulong val) : ANE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7FF71A407D5EEE3;
        }
    }

    class ANG(ulong val) : ANF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7EE7A2EAD02B66A;
        }
    }

    class ANH(ulong val) : ANG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91E4B32214D93B8;
        }
    }

    class ANI(ulong val) : ANH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39664EA230B991E;
        }
    }

    class ANJ(ulong val) : ANI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DD6607F4894F3C;
        }
    }

    class ANK(ulong val) : ANJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8DEEAA8ED42335A;
        }
    }

    class ANL(ulong val) : ANK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x983EE93648C5346;
        }
    }

    class ANM(ulong val) : ANL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x99563B8B92FEDC2;
        }
    }

    class ANN(ulong val) : ANM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48B34B4139CB2D2;
        }
    }

    class ANO(ulong val) : ANN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4DFD4FC39D0E3E2;
        }
    }

    class ANP(ulong val) : ANO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62922E4F10D2A5A;
        }
    }

    class ANQ(ulong val) : ANP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D8A1916B16F283;
        }
    }

    class ANR(ulong val) : ANQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x133B08A670F2C15;
        }
    }

    class ANS(ulong val) : ANR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1AD950158A0FB0D;
        }
    }

    class ANT(ulong val) : ANS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x740F4BD4F2226DB;
        }
    }

    class ANU(ulong val) : ANT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36FAFD90A9AE463;
        }
    }

    class ANV(ulong val) : ANU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FF97A39D76CBFD;
        }
    }

    class ANW(ulong val) : ANV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8EE248483D88322;
        }
    }

    class ANX(ulong val) : ANW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3BF9DD6DAEBC4E7;
        }
    }

    class ANY(ulong val) : ANX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A487697E97BE53;
        }
    }

    class ANZ(ulong val) : ANY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88D6DEAE8D6C99E;
        }
    }

    class AOA(ulong val) : ANZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4752AF20875D535;
        }
    }

    class AOB(ulong val) : AOA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8CED3DCB8B9D150;
        }
    }

    class AOC(ulong val) : AOB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8E47846157A3FA0;
        }
    }

    class AOD(ulong val) : AOC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x110D4681DC723DD;
        }
    }

    class AOE(ulong val) : AOD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B834B2AD408F26;
        }
    }

    class AOF(ulong val) : AOE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x41CDAC906C3DC19;
        }
    }

    class AOG(ulong val) : AOF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x24A799325D9E45A;
        }
    }

    class AOH(ulong val) : AOG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x854A533EE977D19;
        }
    }

    class AOI(ulong val) : AOH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18F9CD89B784945;
        }
    }

    class AOJ(ulong val) : AOI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86A3A5DEB6087FE;
        }
    }

    class AOK(ulong val) : AOJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x172AD546624BE6A;
        }
    }

    class AOL(ulong val) : AOK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x766C5D51D251FDE;
        }
    }

    class AOM(ulong val) : AOL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72744D93EED9675;
        }
    }

    class AON(ulong val) : AOM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FF2B7E3292DB7A;
        }
    }

    class AOO(ulong val) : AON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8E786A3C9415BAE;
        }
    }

    class AOP(ulong val) : AOO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x220610354FCD30D;
        }
    }

    class AOQ(ulong val) : AOP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x10A585DA6EA6DBE;
        }
    }

    class AOR(ulong val) : AOQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x13E3BD8AE88311C;
        }
    }

    class AOS(ulong val) : AOR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x110D78E0A8370FF;
        }
    }

    class AOT(ulong val) : AOS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DFA5FA29105924;
        }
    }

    class AOU(ulong val) : AOT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x30B90D436C0E02C;
        }
    }

    class AOV(ulong val) : AOU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x26D5CD3BD3E25FF;
        }
    }

    class AOW(ulong val) : AOV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A97CBA53736C23;
        }
    }

    class AOX(ulong val) : AOW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D49A6D60C584B0;
        }
    }

    class AOY(ulong val) : AOX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4EF1A8C1CB81386;
        }
    }

    class AOZ(ulong val) : AOY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x60674F6B70BD2BD;
        }
    }

    class APA(ulong val) : AOZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B89A7EDB9DCE5B;
        }
    }

    class APB(ulong val) : APA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A7A2342CB47833;
        }
    }

    class APC(ulong val) : APB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x972E65E362D8EC5;
        }
    }

    class APD(ulong val) : APC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2EBF638407C3F27;
        }
    }

    class APE(ulong val) : APD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3211AECD65F59E7;
        }
    }

    class APF(ulong val) : APE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48A56B21CDFE923;
        }
    }

    class APG(ulong val) : APF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50848274BDCC3C7;
        }
    }

    class APH(ulong val) : APG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x181813B5726D92F;
        }
    }

    class API(ulong val) : APH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E7FF18541F417E;
        }
    }

    class APJ(ulong val) : API(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x474841D7987E957;
        }
    }

    class APK(ulong val) : APJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9775C189EE32552;
        }
    }

    class APL(ulong val) : APK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7ED04BD3CFA48E7;
        }
    }

    class APM(ulong val) : APL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x987821C1215333F;
        }
    }

    class APN(ulong val) : APM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x311434F80FCC71A;
        }
    }

    class APO(ulong val) : APN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85C1EB17169A267;
        }
    }

    class APP(ulong val) : APO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x19C254BECC83047;
        }
    }

    class APQ(ulong val) : APP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92A320D61A31F2B;
        }
    }

    class APR(ulong val) : APQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x320437DE2220792;
        }
    }

    class APS(ulong val) : APR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x41EE9D3E63AE98D;
        }
    }

    class APT(ulong val) : APS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96BFEA7BB0BE605;
        }
    }

    class APU(ulong val) : APT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x80D2BB5D8B6B9B2;
        }
    }

    class APV(ulong val) : APU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x236E161626523B1;
        }
    }

    class APW(ulong val) : APV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x317E6B461D59720;
        }
    }

    class APX(ulong val) : APW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x34D1115837B5041;
        }
    }

    class APY(ulong val) : APX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2B564D0532B1118;
        }
    }

    class APZ(ulong val) : APY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x36B0D068576DA3B;
        }
    }

    class AQA(ulong val) : APZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1AA26896F4670A0;
        }
    }

    class AQB(ulong val) : AQA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4123CF1AA6F8676;
        }
    }

    class AQC(ulong val) : AQB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C9B21B24F28167;
        }
    }

    class AQD(ulong val) : AQC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x985A829D81EE908;
        }
    }

    class AQE(ulong val) : AQD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x62493B3B1A1B6E1;
        }
    }

    class AQF(ulong val) : AQE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22BEA57441045EF;
        }
    }

    class AQG(ulong val) : AQF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6CFEB356C7FC907;
        }
    }

    class AQH(ulong val) : AQG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x666500150672052;
        }
    }

    class AQI(ulong val) : AQH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82F643B0D910239;
        }
    }

    class AQJ(ulong val) : AQI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5D8B76DFED63577;
        }
    }

    class AQK(ulong val) : AQJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x83C739D0B552837;
        }
    }

    class AQL(ulong val) : AQK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x736824537DF689B;
        }
    }

    class AQM(ulong val) : AQL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CCEF1B63FC8B54;
        }
    }

    class AQN(ulong val) : AQM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x792D8A96BFB4CB5;
        }
    }

    class AQO(ulong val) : AQN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5E69298F8069E82;
        }
    }

    class AQP(ulong val) : AQO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x281B04082ACEBDD;
        }
    }

    class AQQ(ulong val) : AQP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B5BE1A522708D9;
        }
    }

    class AQR(ulong val) : AQQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x925E22A5D9C4043;
        }
    }

    class AQS(ulong val) : AQR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x252262CF47590CC;
        }
    }

    class AQT(ulong val) : AQS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1650A65AFA1CEAB;
        }
    }

    class AQU(ulong val) : AQT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x810553E1272A9DD;
        }
    }

    class AQV(ulong val) : AQU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x743EC505D7B245C;
        }
    }

    class AQW(ulong val) : AQV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x25ABC01B83EFED0;
        }
    }

    class AQX(ulong val) : AQW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7381F9F84EC00BB;
        }
    }

    class AQY(ulong val) : AQX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5C302B3C6CA6E9F;
        }
    }

    class AQZ(ulong val) : AQY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BB6C1AF01EC241;
        }
    }

    class ARA(ulong val) : AQZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x30A8E3C7F3F4658;
        }
    }

    class ARB(ulong val) : ARA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x34F4D3B2A7E4684;
        }
    }

    class ARC(ulong val) : ARB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1287B891053591F;
        }
    }

    class ARD(ulong val) : ARC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7FB15D4EDE898B4;
        }
    }

    class ARE(ulong val) : ARD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x18C41640AF94634;
        }
    }

    class ARF(ulong val) : ARE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8550A8A888A7E35;
        }
    }

    class ARG(ulong val) : ARF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x24088CDE8BFE3BC;
        }
    }

    class ARH(ulong val) : ARG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x327430A8E1676E1;
        }
    }

    class ARI(ulong val) : ARH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x86614836ED4DBBF;
        }
    }

    class ARJ(ulong val) : ARI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x75617ED0435C79B;
        }
    }

    class ARK(ulong val) : ARJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D5E6416156E3EA;
        }
    }

    class ARL(ulong val) : ARK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x568707E6DBCD7AA;
        }
    }

    class ARM(ulong val) : ARL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3356A15600F36B6;
        }
    }

    class ARN(ulong val) : ARM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x85A1F420103F11A;
        }
    }

    class ARO(ulong val) : ARN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1EC93F136C57F3E;
        }
    }

    class ARP(ulong val) : ARO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34FD681C067A043;
        }
    }

    class ARQ(ulong val) : ARP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x670385E85416ABA;
        }
    }

    class ARR(ulong val) : ARQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D3A651FE6FC3D0;
        }
    }

    class ARS(ulong val) : ARR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x88C011D308075F7;
        }
    }

    class ART(ulong val) : ARS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x370E8434B023596;
        }
    }

    class ARU(ulong val) : ART(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3DEAF427E58BB27;
        }
    }

    class ARV(ulong val) : ARU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42F4E3C264CBF15;
        }
    }

    class ARW(ulong val) : ARV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F38698A36710D8;
        }
    }

    class ARX(ulong val) : ARW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3CA1D62E2A03978;
        }
    }

    class ARY(ulong val) : ARX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x816962220751C37;
        }
    }

    class ARZ(ulong val) : ARY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x800EB782648BCF5;
        }
    }

    class ASA(ulong val) : ARZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88704A560A9BE18;
        }
    }

    class ASB(ulong val) : ASA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x10753F9A08C6FC3;
        }
    }

    class ASC(ulong val) : ASB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x87BEAC5069CC736;
        }
    }

    class ASD(ulong val) : ASC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4CCF1C83BC0EC13;
        }
    }

    class ASE(ulong val) : ASD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3827EA04C8D60BC;
        }
    }

    class ASF(ulong val) : ASE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29AEC39AFEA0504;
        }
    }

    class ASG(ulong val) : ASF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25D05EF8B56AB47;
        }
    }

    class ASH(ulong val) : ASG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x29F703C04F965A1;
        }
    }

    class ASI(ulong val) : ASH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CE18E7FF79F73E;
        }
    }

    class ASJ(ulong val) : ASI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x848E9E13ECD4AC0;
        }
    }

    class ASK(ulong val) : ASJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77CC82FEB783FA8;
        }
    }

    class ASL(ulong val) : ASK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x468AA615DCB561D;
        }
    }

    class ASM(ulong val) : ASL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56DBA4239915642;
        }
    }

    class ASN(ulong val) : ASM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F48C66000FA871;
        }
    }

    class ASO(ulong val) : ASN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6ADF5898F30DE5D;
        }
    }

    class ASP(ulong val) : ASO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E123E69E3D0D37;
        }
    }

    class ASQ(ulong val) : ASP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x214466E8E0699F9;
        }
    }

    class ASR(ulong val) : ASQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9856612D72D9AF2;
        }
    }

    class ASS(ulong val) : ASR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x860669C124D4C03;
        }
    }

    class AST(ulong val) : ASS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x336D5EF1AE1172F;
        }
    }

    class ASU(ulong val) : AST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x641E15441D7FC6A;
        }
    }

    class ASV(ulong val) : ASU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58B9BF43E2E4D40;
        }
    }

    class ASW(ulong val) : ASV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x75C79AD35721AF4;
        }
    }

    class ASX(ulong val) : ASW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89230571D85021B;
        }
    }

    class ASY(ulong val) : ASX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E6D43D4E1C0EE3;
        }
    }

    class ASZ(ulong val) : ASY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AE0F8960D33DF3;
        }
    }

    class ATA(ulong val) : ASZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18B129498232A76;
        }
    }

    class ATB(ulong val) : ATA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11C37D886F3F384;
        }
    }

    class ATC(ulong val) : ATB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89A49EA6BE2751E;
        }
    }

    class ATD(ulong val) : ATC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49AB1CFF5CA664A;
        }
    }

    class ATE(ulong val) : ATD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E7E8318921B7C9;
        }
    }

    class ATF(ulong val) : ATE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7039B76A34C53BB;
        }
    }

    class ATG(ulong val) : ATF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6DBA61AAFEAC2AA;
        }
    }

    class ATH(ulong val) : ATG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A4B5B313276BF7;
        }
    }

    class ATI(ulong val) : ATH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A1AB46352DB6D4;
        }
    }

    class ATJ(ulong val) : ATI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x231AF0F24E2FBA0;
        }
    }

    class ATK(ulong val) : ATJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C56DACB4558098;
        }
    }

    class ATL(ulong val) : ATK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x39B342FA2428F91;
        }
    }

    class ATM(ulong val) : ATL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x256A44483F9A6BF;
        }
    }

    class ATN(ulong val) : ATM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87F4DB4BA1C01CE;
        }
    }

    class ATO(ulong val) : ATN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79C421D01CEF8A0;
        }
    }

    class ATP(ulong val) : ATO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A0913AFE4CEDA5;
        }
    }

    class ATQ(ulong val) : ATP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x64D14483AB5D728;
        }
    }

    class ATR(ulong val) : ATQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6EA4712A2674BFE;
        }
    }

    class ATS(ulong val) : ATR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x317F5EB85F2ADAE;
        }
    }

    class ATT(ulong val) : ATS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x247DA01D542CA17;
        }
    }

    class ATU(ulong val) : ATT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x135C74F6C766AB0;
        }
    }

    class ATV(ulong val) : ATU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8FC9C0BDADD7A0D;
        }
    }

    class ATW(ulong val) : ATV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AEBC6DF6707FB3;
        }
    }

    class ATX(ulong val) : ATW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25E13548515960C;
        }
    }

    class ATY(ulong val) : ATX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45B8F434A2274B8;
        }
    }

    class ATZ(ulong val) : ATY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x232CA7DF13DD743;
        }
    }

    class AUA(ulong val) : ATZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E9D206FAFCD73C;
        }
    }

    class AUB(ulong val) : AUA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x242B7F4171574C7;
        }
    }

    class AUC(ulong val) : AUB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x22F4DFEE0B5CDE5;
        }
    }

    class AUD(ulong val) : AUC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26BA820F1FD1612;
        }
    }

    class AUE(ulong val) : AUD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1ED18DB72C86F5E;
        }
    }

    class AUF(ulong val) : AUE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x36FB7114B91CB78;
        }
    }

    class AUG(ulong val) : AUF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8175EE9A40F0CE7;
        }
    }

    class AUH(ulong val) : AUG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D40EF7E276E005;
        }
    }

    class AUI(ulong val) : AUH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DB97A8ED065363;
        }
    }

    class AUJ(ulong val) : AUI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5043EFB23D61BE4;
        }
    }

    class AUK(ulong val) : AUJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70C79E408535583;
        }
    }

    class AUL(ulong val) : AUK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x816BCA658F1DEE6;
        }
    }

    class AUM(ulong val) : AUL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x359A41CDC3219B5;
        }
    }

    class AUN(ulong val) : AUM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55509BA6115761D;
        }
    }

    class AUO(ulong val) : AUN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E30512B00D04CF;
        }
    }

    class AUP(ulong val) : AUO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3AA36D0B22FCFC6;
        }
    }

    class AUQ(ulong val) : AUP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A2B9BCE4CD6CA3;
        }
    }

    class AUR(ulong val) : AUQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6118206D1603717;
        }
    }

    class AUS(ulong val) : AUR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x534F89C7654F206;
        }
    }

    class AUT(ulong val) : AUS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AA8674D6750516;
        }
    }

    class AUU(ulong val) : AUT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x861CB4D8339F2E8;
        }
    }

    class AUV(ulong val) : AUU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x726FB211704BD71;
        }
    }

    class AUW(ulong val) : AUV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x753A40A75A16BD2;
        }
    }

    class AUX(ulong val) : AUW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72B607735ED3FF8;
        }
    }

    class AUY(ulong val) : AUX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x22251EB9595149E;
        }
    }

    class AUZ(ulong val) : AUY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x97E039D94E38975;
        }
    }

    class AVA(ulong val) : AUZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8CC67441A4348D9;
        }
    }

    class AVB(ulong val) : AVA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21DF41E95EE0C4D;
        }
    }

    class AVC(ulong val) : AVB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A33838F8B11775;
        }
    }

    class AVD(ulong val) : AVC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F96CC2494ED70C;
        }
    }

    class AVE(ulong val) : AVD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7B34023425B1BE8;
        }
    }

    class AVF(ulong val) : AVE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47C7A50180D8D97;
        }
    }

    class AVG(ulong val) : AVF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8635A22A32F5B5A;
        }
    }

    class AVH(ulong val) : AVG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4DC429670D3CD6E;
        }
    }

    class AVI(ulong val) : AVH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D0A3BBCC92EAB0;
        }
    }

    class AVJ(ulong val) : AVI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x449FC31B621BFE5;
        }
    }

    class AVK(ulong val) : AVJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F0A82639E4F270;
        }
    }

    class AVL(ulong val) : AVK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D57A6CE3B48921;
        }
    }

    class AVM(ulong val) : AVL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3AD3CFA0B6FE2C7;
        }
    }

    class AVN(ulong val) : AVM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6262C85782EECE1;
        }
    }

    class AVO(ulong val) : AVN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x60CFAF68D65E830;
        }
    }

    class AVP(ulong val) : AVO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A96F1D39BD8CFF;
        }
    }

    class AVQ(ulong val) : AVP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1380DD3F770C885;
        }
    }

    class AVR(ulong val) : AVQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A858B0AAF0EDFF;
        }
    }

    class AVS(ulong val) : AVR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E997CBB3CC4D1C;
        }
    }

    class AVT(ulong val) : AVS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5B11624C0B79DE4;
        }
    }

    class AVU(ulong val) : AVT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x577BCBAE60A9A10;
        }
    }

    class AVV(ulong val) : AVU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C3A6E952907AF6;
        }
    }

    class AVW(ulong val) : AVV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C001E92CCDBBA8;
        }
    }

    class AVX(ulong val) : AVW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A378DCAA85CADE;
        }
    }

    class AVY(ulong val) : AVX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x161FD85321AAE9F;
        }
    }

    class AVZ(ulong val) : AVY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x694C5BD258F6A8C;
        }
    }

    class AWA(ulong val) : AVZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4560E5B1C928B68;
        }
    }

    class AWB(ulong val) : AWA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A76C108C334059;
        }
    }

    class AWC(ulong val) : AWB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34CF068B5DAF039;
        }
    }

    class AWD(ulong val) : AWC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x814B68BB4F46068;
        }
    }

    class AWE(ulong val) : AWD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x528D2113D4AF3B3;
        }
    }

    class AWF(ulong val) : AWE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1739E19FC628249;
        }
    }

    class AWG(ulong val) : AWF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22B8B76A9073137;
        }
    }

    class AWH(ulong val) : AWG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x457F587738983AD;
        }
    }

    class AWI(ulong val) : AWH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x39962022C5C3ED4;
        }
    }

    class AWJ(ulong val) : AWI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B0477EA44164D6;
        }
    }

    class AWK(ulong val) : AWJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2553297908B8C8E;
        }
    }

    class AWL(ulong val) : AWK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x33FD5701E5E4309;
        }
    }

    class AWM(ulong val) : AWL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7770915A898254B;
        }
    }

    class AWN(ulong val) : AWM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1EDD90E539D5B87;
        }
    }

    class AWO(ulong val) : AWN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x850D8B4731C81CE;
        }
    }

    class AWP(ulong val) : AWO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D4E2085EE97F24;
        }
    }

    class AWQ(ulong val) : AWP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x752A92CE974C188;
        }
    }

    class AWR(ulong val) : AWQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x90806CBD7DBCD5B;
        }
    }

    class AWS(ulong val) : AWR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x487234E1711A2DC;
        }
    }

    class AWT(ulong val) : AWS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x968D17DB8CAE925;
        }
    }

    class AWU(ulong val) : AWT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x66FCC97244AD8F2;
        }
    }

    class AWV(ulong val) : AWU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3D49CBDD4F2FC71;
        }
    }

    class AWW(ulong val) : AWV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x979F9B940906675;
        }
    }

    class AWX(ulong val) : AWW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x334DAFE80D7C268;
        }
    }

    class AWY(ulong val) : AWX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8666D83654B345B;
        }
    }

    class AWZ(ulong val) : AWY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85A9890666E1B9A;
        }
    }

    class AXA(ulong val) : AWZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53AFF15F2D28A6D;
        }
    }

    class AXB(ulong val) : AXA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87E8210FA1E0A9D;
        }
    }

    class AXC(ulong val) : AXB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5FE3D9D10759812;
        }
    }

    class AXD(ulong val) : AXC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3BD1215404E9504;
        }
    }

    class AXE(ulong val) : AXD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x876FA83D3155A37;
        }
    }

    class AXF(ulong val) : AXE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x708BFB39F70AC39;
        }
    }

    class AXG(ulong val) : AXF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87F27FFEBBE3C35;
        }
    }

    class AXH(ulong val) : AXG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4BEA8B31800BD6B;
        }
    }

    class AXI(ulong val) : AXH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3CE241121A4DA96;
        }
    }

    class AXJ(ulong val) : AXI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x77D9769AF128197;
        }
    }

    class AXK(ulong val) : AXJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16B1A2D223170A8;
        }
    }

    class AXL(ulong val) : AXK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6353626CF950E80;
        }
    }

    class AXM(ulong val) : AXL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x49AF981D26E3073;
        }
    }

    class AXN(ulong val) : AXM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3AFEA7768BA5B8C;
        }
    }

    class AXO(ulong val) : AXN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x60623D5F37FDCE5;
        }
    }

    class AXP(ulong val) : AXO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x790B7D8DB5B43F2;
        }
    }

    class AXQ(ulong val) : AXP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x93FD2E55F2566A8;
        }
    }

    class AXR(ulong val) : AXQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x28AEC23C8431263;
        }
    }

    class AXS(ulong val) : AXR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x10ABA5716C64AF5;
        }
    }

    class AXT(ulong val) : AXS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8524ED358BAA32D;
        }
    }

    class AXU(ulong val) : AXT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23C52FC1D44BD5D;
        }
    }

    class AXV(ulong val) : AXU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21DA9E690908259;
        }
    }

    class AXW(ulong val) : AXV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x33D47AEAB919978;
        }
    }

    class AXX(ulong val) : AXW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6458CDEAA766B7C;
        }
    }

    class AXY(ulong val) : AXX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26DB4C800EDF36E;
        }
    }

    class AXZ(ulong val) : AXY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3643C5DFBFC6045;
        }
    }

    class AYA(ulong val) : AXZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E21F1EB98B081C;
        }
    }

    class AYB(ulong val) : AYA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x308E104E0EA5A5B;
        }
    }

    class AYC(ulong val) : AYB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x839FB55AFCD6D28;
        }
    }

    class AYD(ulong val) : AYC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1064EAA3A904585;
        }
    }

    class AYE(ulong val) : AYD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1844835C17532EE;
        }
    }

    class AYF(ulong val) : AYE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39A5A4246C07AFE;
        }
    }

    class AYG(ulong val) : AYF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2421F33DC3013D9;
        }
    }

    class AYH(ulong val) : AYG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4424D60F263B110;
        }
    }

    class AYI(ulong val) : AYH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3609D21B1360B28;
        }
    }

    class AYJ(ulong val) : AYI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9486F7D79955F05;
        }
    }

    class AYK(ulong val) : AYJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34C570AF66F13EE;
        }
    }

    class AYL(ulong val) : AYK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x61456A6B6505297;
        }
    }

    class AYM(ulong val) : AYL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9623ED0B91EE0AD;
        }
    }

    class AYN(ulong val) : AYM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x47642876EC7FBFC;
        }
    }

    class AYO(ulong val) : AYN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8EE8ADABA5C01C7;
        }
    }

    class AYP(ulong val) : AYO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x10C373A4D8DF982;
        }
    }

    class AYQ(ulong val) : AYP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x93DF791ED862CDC;
        }
    }

    class AYR(ulong val) : AYQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x38394532F456319;
        }
    }

    class AYS(ulong val) : AYR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x81378BFAAF99BA6;
        }
    }

    class AYT(ulong val) : AYS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B56380C3E149DA;
        }
    }

    class AYU(ulong val) : AYT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55DDDA8C8D188AD;
        }
    }

    class AYV(ulong val) : AYU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2641660112ED093;
        }
    }

    class AYW(ulong val) : AYV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AB667D8C26B424;
        }
    }

    class AYX(ulong val) : AYW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A726A98FFF045C;
        }
    }

    class AYY(ulong val) : AYX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3D41EAF6E4CF7C8;
        }
    }

    class AYZ(ulong val) : AYY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D1B54A188CC45F;
        }
    }

    class AZA(ulong val) : AYZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8A722329335E8FD;
        }
    }

    class AZB(ulong val) : AZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A6BA78C3510749;
        }
    }

    class AZC(ulong val) : AZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6CA5DE599F80E10;
        }
    }

    class AZD(ulong val) : AZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CF08C18E9F60EB;
        }
    }

    class AZE(ulong val) : AZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x956F8DA2027E886;
        }
    }

    class AZF(ulong val) : AZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5EA7BDC4C3A5EFC;
        }
    }

    class AZG(ulong val) : AZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x580CDD6DE85C58B;
        }
    }

    class AZH(ulong val) : AZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x37807AEA68A399E;
        }
    }

    class AZI(ulong val) : AZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43F1701D32623BB;
        }
    }

    class AZJ(ulong val) : AZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4FD62A44FDBD1C4;
        }
    }

    class AZK(ulong val) : AZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x69F4DA351781941;
        }
    }

    class AZL(ulong val) : AZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x32D9DE474CEBC11;
        }
    }

    class AZM(ulong val) : AZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78EBA1460C43525;
        }
    }

    class AZN(ulong val) : AZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31CEEF7B6991F23;
        }
    }

    class AZO(ulong val) : AZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24672A153B888B4;
        }
    }

    class AZP(ulong val) : AZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7FCC934F06031BF;
        }
    }

    class AZQ(ulong val) : AZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29F75EED5850758;
        }
    }

    class AZR(ulong val) : AZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x541778243394CE9;
        }
    }

    class AZS(ulong val) : AZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x91BAA0A99FE659A;
        }
    }

    class AZT(ulong val) : AZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C70E2C2A46BA08;
        }
    }

    class AZU(ulong val) : AZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8E0A0CD047B7A17;
        }
    }

    class AZV(ulong val) : AZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x455DFB248C88C45;
        }
    }

    class AZW(ulong val) : AZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19949E4D6F95BDC;
        }
    }

    class AZX(ulong val) : AZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x97882E496B974B4;
        }
    }

    class AZY(ulong val) : AZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x273B35CA03A5CAC;
        }
    }

    class AZZ(ulong val) : AZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x112AC9FB5119D59;
        }
    }

    class BAA(ulong val) : AZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D433C218637150;
        }
    }

    class BAB(ulong val) : BAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x536047232F006CC;
        }
    }

    class BAC(ulong val) : BAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x746C2E5BD349500;
        }
    }

    class BAD(ulong val) : BAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A33E8905C016F5;
        }
    }

    class BAE(ulong val) : BAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3F9225D5C4DE39C;
        }
    }

    class BAF(ulong val) : BAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x228EB05A68DBC08;
        }
    }

    class BAG(ulong val) : BAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2372E73B57EB81B;
        }
    }

    class BAH(ulong val) : BAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x834E36015510A4C;
        }
    }

    class BAI(ulong val) : BAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18F0C00E4EBCAAB;
        }
    }

    class BAJ(ulong val) : BAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5944D53D09EE4B7;
        }
    }

    class BAK(ulong val) : BAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F173E5A87AAF2D;
        }
    }

    class BAL(ulong val) : BAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72F97F3ECB4ED8E;
        }
    }

    class BAM(ulong val) : BAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3FBDD9B85BF7099;
        }
    }

    class BAN(ulong val) : BAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DD03873E7A1DA8;
        }
    }

    class BAO(ulong val) : BAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x35DDDD0803137BC;
        }
    }

    class BAP(ulong val) : BAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FAAE74359888C4;
        }
    }

    class BAQ(ulong val) : BAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x71F769704BB5DA6;
        }
    }

    class BAR(ulong val) : BAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x419EC4F356F47E5;
        }
    }

    class BAS(ulong val) : BAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8BAAD05F8AC03EC;
        }
    }

    class BAT(ulong val) : BAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4DC518CF4EC8E41;
        }
    }

    class BAU(ulong val) : BAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7CF8C7E0DDA5597;
        }
    }

    class BAV(ulong val) : BAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2FB9961A13B541A;
        }
    }

    class BAW(ulong val) : BAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45FAF702D3B038E;
        }
    }

    class BAX(ulong val) : BAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16F1BEA785892B9;
        }
    }

    class BAY(ulong val) : BAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3DC72506CD10B88;
        }
    }

    class BAZ(ulong val) : BAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x126EFDDFB9B926A;
        }
    }

    class BBA(ulong val) : BAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E66F3D0A8E7E40;
        }
    }

    class BBB(ulong val) : BBA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F92CB1A13055BF;
        }
    }

    class BBC(ulong val) : BBB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x29BC59D3A9186E6;
        }
    }

    class BBD(ulong val) : BBC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8EFDE83CDDD7C54;
        }
    }

    class BBE(ulong val) : BBD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x331BEB2E7747DAD;
        }
    }

    class BBF(ulong val) : BBE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E7D5F2CB12DF30;
        }
    }

    class BBG(ulong val) : BBF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B2D9097A5E3DBF;
        }
    }

    class BBH(ulong val) : BBG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C638421DFDB461;
        }
    }

    class BBI(ulong val) : BBH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x77D1E9F7C405E43;
        }
    }

    class BBJ(ulong val) : BBI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53BA593F6FB9B66;
        }
    }

    class BBK(ulong val) : BBJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1775906D7F7A259;
        }
    }

    class BBL(ulong val) : BBK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D5041364C4D2B0;
        }
    }

    class BBM(ulong val) : BBL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C5626750847E60;
        }
    }

    class BBN(ulong val) : BBM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7EC37755154A37C;
        }
    }

    class BBO(ulong val) : BBN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8833D74DAB04FA2;
        }
    }

    class BBP(ulong val) : BBO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39FCEFD70EF601F;
        }
    }

    class BBQ(ulong val) : BBP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27D865214E44556;
        }
    }

    class BBR(ulong val) : BBQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x340E38CDC0DC4E5;
        }
    }

    class BBS(ulong val) : BBR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E5510FC2DFBA26;
        }
    }

    class BBT(ulong val) : BBS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2793F0C083D4024;
        }
    }

    class BBU(ulong val) : BBT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x42A4E338A3DD8FA;
        }
    }

    class BBV(ulong val) : BBU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x300718FF9ADCCFA;
        }
    }

    class BBW(ulong val) : BBV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x219EC300E50A6A8;
        }
    }

    class BBX(ulong val) : BBW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x32D031EC1E354D1;
        }
    }

    class BBY(ulong val) : BBX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7142273156C43DA;
        }
    }

    class BBZ(ulong val) : BBY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FD3D54E465B1D7;
        }
    }

    class BCA(ulong val) : BBZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29150D51E94EB74;
        }
    }

    class BCB(ulong val) : BCA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E5EF14FE6A17C3;
        }
    }

    class BCC(ulong val) : BCB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9801CEE0BABDDFB;
        }
    }

    class BCD(ulong val) : BCC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29CF04EC960CAF0;
        }
    }

    class BCE(ulong val) : BCD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A48759383D980A;
        }
    }

    class BCF(ulong val) : BCE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62A35DAD39492A2;
        }
    }

    class BCG(ulong val) : BCF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91A3A2FEA4B7112;
        }
    }

    class BCH(ulong val) : BCG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3301318FAAB8162;
        }
    }

    class BCI(ulong val) : BCH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E0271576650ADE;
        }
    }

    class BCJ(ulong val) : BCI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1944C2434C8225D;
        }
    }

    class BCK(ulong val) : BCJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55B80C03179AFC0;
        }
    }

    class BCL(ulong val) : BCK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E18B853E76D03A;
        }
    }

    class BCM(ulong val) : BCL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x495B139C3E5CB36;
        }
    }

    class BCN(ulong val) : BCM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F1FCD6B95215A7;
        }
    }

    class BCO(ulong val) : BCN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3482C22BB125BDA;
        }
    }

    class BCP(ulong val) : BCO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x692CCEB9763557C;
        }
    }

    class BCQ(ulong val) : BCP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x59CE081E1D6C3C3;
        }
    }

    class BCR(ulong val) : BCQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x90D09785DE5FDCA;
        }
    }

    class BCS(ulong val) : BCR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8ECB1262B36C029;
        }
    }

    class BCT(ulong val) : BCS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F8B82F27BBB2F9;
        }
    }

    class BCU(ulong val) : BCT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53988E6BF54CABD;
        }
    }

    class BCV(ulong val) : BCU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50C78AB593E7864;
        }
    }

    class BCW(ulong val) : BCV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E22D3A26C5D6BB;
        }
    }

    class BCX(ulong val) : BCW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x261FD00151658BF;
        }
    }

    class BCY(ulong val) : BCX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x488BFE1765A8315;
        }
    }

    class BCZ(ulong val) : BCY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1BDF0029D924E5E;
        }
    }

    class BDA(ulong val) : BCZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x944B360507D0990;
        }
    }

    class BDB(ulong val) : BDA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x735BDC390E44B30;
        }
    }

    class BDC(ulong val) : BDB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x899C3AA06F70C23;
        }
    }

    class BDD(ulong val) : BDC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x81EA1A87541D25F;
        }
    }

    class BDE(ulong val) : BDD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8A1826333C51DCD;
        }
    }

    class BDF(ulong val) : BDE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x307AB104A58E84A;
        }
    }

    class BDG(ulong val) : BDF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7D932516D4E2B0F;
        }
    }

    class BDH(ulong val) : BDG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x885F0A2049E62E7;
        }
    }

    class BDI(ulong val) : BDH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35566C8FDBEC34D;
        }
    }

    class BDJ(ulong val) : BDI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x264946E8E1CE60D;
        }
    }

    class BDK(ulong val) : BDJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x70471DFB27F12C5;
        }
    }

    class BDL(ulong val) : BDK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x38BF38867A1A8C4;
        }
    }

    class BDM(ulong val) : BDL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C0259AD4882083;
        }
    }

    class BDN(ulong val) : BDM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3EA6A47DB114A08;
        }
    }

    class BDO(ulong val) : BDN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C7DC349EE3DBEA;
        }
    }

    class BDP(ulong val) : BDO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x182E0AAFFEE2E48;
        }
    }

    class BDQ(ulong val) : BDP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x66A706621449837;
        }
    }

    class BDR(ulong val) : BDQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6DE2A5D2DD56521;
        }
    }

    class BDS(ulong val) : BDR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x601C9B23DE5DEE0;
        }
    }

    class BDT(ulong val) : BDS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x207A0EFC809A1D2;
        }
    }

    class BDU(ulong val) : BDT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FBB397416BECDA;
        }
    }

    class BDV(ulong val) : BDU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x372D0072551EDA8;
        }
    }

    class BDW(ulong val) : BDV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96DF7719ADD71D6;
        }
    }

    class BDX(ulong val) : BDW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4495930692642A8;
        }
    }

    class BDY(ulong val) : BDX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2682FD01999F847;
        }
    }

    class BDZ(ulong val) : BDY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x921F6BA69128327;
        }
    }

    class BEA(ulong val) : BDZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x89A4FE7010D4A8C;
        }
    }

    class BEB(ulong val) : BEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x900A4389F1BB1FD;
        }
    }

    class BEC(ulong val) : BEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79663B17435BE48;
        }
    }

    class BED(ulong val) : BEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16ECB9B33AFFC90;
        }
    }

    class BEE(ulong val) : BED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B6EA63FF226AFD;
        }
    }

    class BEF(ulong val) : BEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x520DE12A5633A2D;
        }
    }

    class BEG(ulong val) : BEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E07B1C1FDA8739;
        }
    }

    class BEH(ulong val) : BEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x984DA36686CB9DA;
        }
    }

    class BEI(ulong val) : BEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x82138C426E4F845;
        }
    }

    class BEJ(ulong val) : BEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x133FC62E17D9899;
        }
    }

    class BEK(ulong val) : BEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6CA0B524AA14907;
        }
    }

    class BEL(ulong val) : BEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8414A7EA2C08CF9;
        }
    }

    class BEM(ulong val) : BEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82F980A09DCF89A;
        }
    }

    class BEN(ulong val) : BEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3215FAF59A12098;
        }
    }

    class BEO(ulong val) : BEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9341E03275D5BD2;
        }
    }

    class BEP(ulong val) : BEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x795E388B6F16B09;
        }
    }

    class BEQ(ulong val) : BEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49E2081CE157319;
        }
    }

    class BER(ulong val) : BEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D89573D7AB12B8;
        }
    }

    class BES(ulong val) : BER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79C193DD31D8562;
        }
    }

    class BET(ulong val) : BES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6312FAC20808AD5;
        }
    }

    class BEU(ulong val) : BET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7B93D46004A9696;
        }
    }

    class BEV(ulong val) : BEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70A0947BB175253;
        }
    }

    class BEW(ulong val) : BEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FABAB30D7F63F5;
        }
    }

    class BEX(ulong val) : BEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x786B484AC28E32D;
        }
    }

    class BEY(ulong val) : BEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82AFC7E2631BAE7;
        }
    }

    class BEZ(ulong val) : BEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1F0E7ECF0D68915;
        }
    }

    class BFA(ulong val) : BEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70F4A6ED4D16FA7;
        }
    }

    class BFB(ulong val) : BFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6AB92CCA7E62F7C;
        }
    }

    class BFC(ulong val) : BFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D74D96C344D0A3;
        }
    }

    class BFD(ulong val) : BFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49EBF76F550AF5F;
        }
    }

    class BFE(ulong val) : BFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x86D1C363A26AC03;
        }
    }

    class BFF(ulong val) : BFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4ECD32455F6F441;
        }
    }

    class BFG(ulong val) : BFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x395F5CA03C94021;
        }
    }

    class BFH(ulong val) : BFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3EA76D1E701B7D0;
        }
    }

    class BFI(ulong val) : BFH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x70EEF0607216F49;
        }
    }

    class BFJ(ulong val) : BFI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x817BC9B07BF2FFA;
        }
    }

    class BFK(ulong val) : BFJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A597B45E881C0B;
        }
    }

    class BFL(ulong val) : BFK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x382955668149090;
        }
    }

    class BFM(ulong val) : BFL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9942FD1AB0EC032;
        }
    }

    class BFN(ulong val) : BFM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48739BE5246AAF6;
        }
    }

    class BFO(ulong val) : BFN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x274C8C1DBD4731A;
        }
    }

    class BFP(ulong val) : BFO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BD79230B37C85C;
        }
    }

    class BFQ(ulong val) : BFP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3261B5F49C74E8D;
        }
    }

    class BFR(ulong val) : BFQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x330D751287BD0F2;
        }
    }

    class BFS(ulong val) : BFR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C1B3DCA3290ACF;
        }
    }

    class BFT(ulong val) : BFS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A528CD0C617A6B;
        }
    }

    class BFU(ulong val) : BFT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4443D5A18946618;
        }
    }

    class BFV(ulong val) : BFU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x726149151CEA785;
        }
    }

    class BFW(ulong val) : BFV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B69689C2CF1AAB;
        }
    }

    class BFX(ulong val) : BFW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12E19FB4CDAC68C;
        }
    }

    class BFY(ulong val) : BFX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x38C75D5C5DCE225;
        }
    }

    class BFZ(ulong val) : BFY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A22DAD1057B918;
        }
    }

    class BGA(ulong val) : BFZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74C6D5C4A3CF08B;
        }
    }

    class BGB(ulong val) : BGA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81CEBFD2D494CFE;
        }
    }

    class BGC(ulong val) : BGB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3EFD69CB052B093;
        }
    }

    class BGD(ulong val) : BGC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x990793361C7D8B0;
        }
    }

    class BGE(ulong val) : BGD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55F3A2EDCFDD014;
        }
    }

    class BGF(ulong val) : BGE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55C32C964F4416C;
        }
    }

    class BGG(ulong val) : BGF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D4C5C5D92F180E;
        }
    }

    class BGH(ulong val) : BGG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x287A36D2D085790;
        }
    }

    class BGI(ulong val) : BGH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1CEAE731196FF6B;
        }
    }

    class BGJ(ulong val) : BGI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A3C2592D3E02CF;
        }
    }

    class BGK(ulong val) : BGJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x209F8E0FB4721AF;
        }
    }

    class BGL(ulong val) : BGK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C9F599895A8F00;
        }
    }

    class BGM(ulong val) : BGL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D20032C9285FE6;
        }
    }

    class BGN(ulong val) : BGM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4B8D453FA8452E3;
        }
    }

    class BGO(ulong val) : BGN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92FDB9B744E97CB;
        }
    }

    class BGP(ulong val) : BGO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24F302FD518D4DC;
        }
    }

    class BGQ(ulong val) : BGP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x59009E94E77075F;
        }
    }

    class BGR(ulong val) : BGQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x585C35426E61341;
        }
    }

    class BGS(ulong val) : BGR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5D3FA0F428DB236;
        }
    }

    class BGT(ulong val) : BGS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x411206E39C31B05;
        }
    }

    class BGU(ulong val) : BGT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x27467532553B08D;
        }
    }

    class BGV(ulong val) : BGU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3AEB9A4DF86C33F;
        }
    }

    class BGW(ulong val) : BGV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x65D181A3620FD57;
        }
    }

    class BGX(ulong val) : BGW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7D0D53266FC38B6;
        }
    }

    class BGY(ulong val) : BGX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x75405B9B2374307;
        }
    }

    class BGZ(ulong val) : BGY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6593CED3707BB63;
        }
    }

    class BHA(ulong val) : BGZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x38ACF98575061EB;
        }
    }

    class BHB(ulong val) : BHA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1073DBACF805444;
        }
    }

    class BHC(ulong val) : BHB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5FA8BC3A5D2B1DF;
        }
    }

    class BHD(ulong val) : BHC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x404596A7676990B;
        }
    }

    class BHE(ulong val) : BHD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D910C9CD9E4C3C;
        }
    }

    class BHF(ulong val) : BHE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3CAE8E9BD1B27EB;
        }
    }

    class BHG(ulong val) : BHF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3922ABB40916DF8;
        }
    }

    class BHH(ulong val) : BHG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x18D67B40F4AC350;
        }
    }

    class BHI(ulong val) : BHH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x514E30F5074279B;
        }
    }

    class BHJ(ulong val) : BHI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5F04E7A39D8E715;
        }
    }

    class BHK(ulong val) : BHJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87EF915F139162C;
        }
    }

    class BHL(ulong val) : BHK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x223D4C1CCF0CC99;
        }
    }

    class BHM(ulong val) : BHL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2CB1475B31267A9;
        }
    }

    class BHN(ulong val) : BHM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F0F27434DA6370;
        }
    }

    class BHO(ulong val) : BHN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78201E735C23EB6;
        }
    }

    class BHP(ulong val) : BHO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x775D3927EB5526F;
        }
    }

    class BHQ(ulong val) : BHP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20D05113A3259C5;
        }
    }

    class BHR(ulong val) : BHQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4554774CF3C21CC;
        }
    }

    class BHS(ulong val) : BHR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D908DAE384FA8A;
        }
    }

    class BHT(ulong val) : BHS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x161E7115F23B986;
        }
    }

    class BHU(ulong val) : BHT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77A38206F7E7FF8;
        }
    }

    class BHV(ulong val) : BHU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A71593D5F86228;
        }
    }

    class BHW(ulong val) : BHV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4597DDFD1BF1918;
        }
    }

    class BHX(ulong val) : BHW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5375B1204CD6D64;
        }
    }

    class BHY(ulong val) : BHX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B9C428811853A5;
        }
    }

    class BHZ(ulong val) : BHY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x208971E793637D7;
        }
    }

    class BIA(ulong val) : BHZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x69BA0716D97B0B4;
        }
    }

    class BIB(ulong val) : BIA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2F89FF4D04A6FAB;
        }
    }

    class BIC(ulong val) : BIB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4CAA1FC88215117;
        }
    }

    class BID(ulong val) : BIC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9972B245E04804E;
        }
    }

    class BIE(ulong val) : BID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26B11BBD58DD7FF;
        }
    }

    class BIF(ulong val) : BIE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x401F8F2F658AE13;
        }
    }

    class BIG(ulong val) : BIF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x295FBC001881631;
        }
    }

    class BIH(ulong val) : BIG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x756935CE7F774CA;
        }
    }

    class BII(ulong val) : BIH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39FDEBBFC4E0AC2;
        }
    }

    class BIJ(ulong val) : BII(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85EB41FEC71BD80;
        }
    }

    class BIK(ulong val) : BIJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A22741D677036A;
        }
    }

    class BIL(ulong val) : BIK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x68ED6CF5E991EC4;
        }
    }

    class BIM(ulong val) : BIL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x987BB2617B7FDAA;
        }
    }

    class BIN(ulong val) : BIM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E6D460C12FBA43;
        }
    }

    class BIO(ulong val) : BIN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54625506ACB2D03;
        }
    }

    class BIP(ulong val) : BIO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3DFBDEBC7D03A4D;
        }
    }

    class BIQ(ulong val) : BIP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8C276ED39B91A6A;
        }
    }

    class BIR(ulong val) : BIQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x12408353D2D2834;
        }
    }

    class BIS(ulong val) : BIR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1BC4E824E1D221C;
        }
    }

    class BIT(ulong val) : BIS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53160D9837A93B0;
        }
    }

    class BIU(ulong val) : BIT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53B373035F65694;
        }
    }

    class BIV(ulong val) : BIU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x88169C08AA6A91A;
        }
    }

    class BIW(ulong val) : BIV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70BEA8A3CE4C7F7;
        }
    }

    class BIX(ulong val) : BIW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4FE42418D84540B;
        }
    }

    class BIY(ulong val) : BIX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x697CD567ABB6580;
        }
    }

    class BIZ(ulong val) : BIY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67E33CC9DDBC9BF;
        }
    }

    class BJA(ulong val) : BIZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1B48C17D4C15693;
        }
    }

    class BJB(ulong val) : BJA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x12CAF2659E96956;
        }
    }

    class BJC(ulong val) : BJB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A4330615E27880;
        }
    }

    class BJD(ulong val) : BJC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8339569CCFDAA88;
        }
    }

    class BJE(ulong val) : BJD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6628F0060CC131A;
        }
    }

    class BJF(ulong val) : BJE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4A279875879B688;
        }
    }

    class BJG(ulong val) : BJF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x356F8C447C96E90;
        }
    }

    class BJH(ulong val) : BJG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B68C5F249AA009;
        }
    }

    class BJI(ulong val) : BJH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x91A601759D2AE7D;
        }
    }

    class BJJ(ulong val) : BJI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11277F21F79214F;
        }
    }

    class BJK(ulong val) : BJJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8DE31BAF8366917;
        }
    }

    class BJL(ulong val) : BJK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2592650D6FF390C;
        }
    }

    class BJM(ulong val) : BJL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F7C78B6FDC1D4C;
        }
    }

    class BJN(ulong val) : BJM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63BC84A44ADF55C;
        }
    }

    class BJO(ulong val) : BJN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E2901CC966A7CB;
        }
    }

    class BJP(ulong val) : BJO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x847553F4D0DE7DE;
        }
    }

    class BJQ(ulong val) : BJP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6ED00CC80A3F883;
        }
    }

    class BJR(ulong val) : BJQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17FE930850FDCE7;
        }
    }

    class BJS(ulong val) : BJR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7150D7F77AF1CCB;
        }
    }

    class BJT(ulong val) : BJS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C03438BAE8BDF1;
        }
    }

    class BJU(ulong val) : BJT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x713CAE36D21D531;
        }
    }

    class BJV(ulong val) : BJU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F13D4CBDE3EDF4;
        }
    }

    class BJW(ulong val) : BJV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9372985A6F2B067;
        }
    }

    class BJX(ulong val) : BJW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98C8A8435EBF42D;
        }
    }

    class BJY(ulong val) : BJX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FACCA4F17733B6;
        }
    }

    class BJZ(ulong val) : BJY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1F799DC4C9936E1;
        }
    }

    class BKA(ulong val) : BJZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2CE146A7154C52B;
        }
    }

    class BKB(ulong val) : BKA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x43CFB9F64F00365;
        }
    }

    class BKC(ulong val) : BKB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CFB80FF26CB176;
        }
    }

    class BKD(ulong val) : BKC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C6FB0717D7B8C4;
        }
    }

    class BKE(ulong val) : BKD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7FEB49FF122B8E3;
        }
    }

    class BKF(ulong val) : BKE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x40A030E577029EA;
        }
    }

    class BKG(ulong val) : BKF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3BB51FAB2D2C6FE;
        }
    }

    class BKH(ulong val) : BKG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5D77888221B05D4;
        }
    }

    class BKI(ulong val) : BKH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7AD0B400A48EDEB;
        }
    }

    class BKJ(ulong val) : BKI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x340BC4A4149EF7C;
        }
    }

    class BKK(ulong val) : BKJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45A6B2E72155816;
        }
    }

    class BKL(ulong val) : BKK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96E145B64FC5630;
        }
    }

    class BKM(ulong val) : BKL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5FE095F3F5C5F19;
        }
    }

    class BKN(ulong val) : BKM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B1209CD4F3E6F4;
        }
    }

    class BKO(ulong val) : BKN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x440296D6DA91865;
        }
    }

    class BKP(ulong val) : BKO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FDDA9771534BDE;
        }
    }

    class BKQ(ulong val) : BKP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E646CB64B56CAF;
        }
    }

    class BKR(ulong val) : BKQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BEBF14129F2A3C;
        }
    }

    class BKS(ulong val) : BKR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x13BFF13FF230952;
        }
    }

    class BKT(ulong val) : BKS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2CA711B04B0A691;
        }
    }

    class BKU(ulong val) : BKT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8C531A27011459F;
        }
    }

    class BKV(ulong val) : BKU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1409CB5768D4015;
        }
    }

    class BKW(ulong val) : BKV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8BD405B5BFB6200;
        }
    }

    class BKX(ulong val) : BKW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x350EAD6D49D5B5B;
        }
    }

    class BKY(ulong val) : BKX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3B53AFB903E04AB;
        }
    }

    class BKZ(ulong val) : BKY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x84AA91BC144C8BA;
        }
    }

    class BLA(ulong val) : BKZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x186C9F5B4FEBE63;
        }
    }

    class BLB(ulong val) : BLA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x33A307A471847BB;
        }
    }

    class BLC(ulong val) : BLB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x262BE8DBC468DC4;
        }
    }

    class BLD(ulong val) : BLC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x22EF9BBC4318EA8;
        }
    }

    class BLE(ulong val) : BLD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5BC1163B2779396;
        }
    }

    class BLF(ulong val) : BLE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x95E3C077C7EF4E8;
        }
    }

    class BLG(ulong val) : BLF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E6E9900A8D8429;
        }
    }

    class BLH(ulong val) : BLG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3099F7DBF77D98F;
        }
    }

    class BLI(ulong val) : BLH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C235E128F2E6B9;
        }
    }

    class BLJ(ulong val) : BLI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x83D0D99CD05EC48;
        }
    }

    class BLK(ulong val) : BLJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F63D7BDC3DADF5;
        }
    }

    class BLL(ulong val) : BLK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7090F3BD4222F49;
        }
    }

    class BLM(ulong val) : BLL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x33588A30B4E5EC1;
        }
    }

    class BLN(ulong val) : BLM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6A649831FE74343;
        }
    }

    class BLO(ulong val) : BLN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x831AB21D63458E4;
        }
    }

    class BLP(ulong val) : BLO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2211C03A414BE1E;
        }
    }

    class BLQ(ulong val) : BLP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79B412D3C26A6B3;
        }
    }

    class BLR(ulong val) : BLQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4DE836A91CD0AE7;
        }
    }

    class BLS(ulong val) : BLR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2113FAD5B08F181;
        }
    }

    class BLT(ulong val) : BLS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5DCD877E7E93150;
        }
    }

    class BLU(ulong val) : BLT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8353150F25D56E1;
        }
    }

    class BLV(ulong val) : BLU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50C7238A618C846;
        }
    }

    class BLW(ulong val) : BLV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x462DB47C036999C;
        }
    }

    class BLX(ulong val) : BLW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8AE6DC642DD8896;
        }
    }

    class BLY(ulong val) : BLX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x185E2D4FC934340;
        }
    }

    class BLZ(ulong val) : BLY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x125A79ACB68C992;
        }
    }

    class BMA(ulong val) : BLZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x683A81A65578BF1;
        }
    }

    class BMB(ulong val) : BMA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CEE792E784567C;
        }
    }

    class BMC(ulong val) : BMB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x99249EDB74D43A3;
        }
    }

    class BMD(ulong val) : BMC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4EAF74BBA7A7A2B;
        }
    }

    class BME(ulong val) : BMD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x960E6D00DC7CDAD;
        }
    }

    class BMF(ulong val) : BME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9227A1CEAC8C41D;
        }
    }

    class BMG(ulong val) : BMF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4ACBED42D557503;
        }
    }

    class BMH(ulong val) : BMG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5D44AE40AAC80D2;
        }
    }

    class BMI(ulong val) : BMH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x33205D50D232B20;
        }
    }

    class BMJ(ulong val) : BMI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57C1FCA9270CA18;
        }
    }

    class BMK(ulong val) : BMJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5D3844AAECBC80E;
        }
    }

    class BML(ulong val) : BMK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A117BB14C361B5;
        }
    }

    class BMM(ulong val) : BML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x98A312E3EA53B4D;
        }
    }

    class BMN(ulong val) : BMM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DAB09EDC36481E;
        }
    }

    class BMO(ulong val) : BMN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x171924892224162;
        }
    }

    class BMP(ulong val) : BMO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x220DB55FF78DB3E;
        }
    }

    class BMQ(ulong val) : BMP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x66101C74E4C11FA;
        }
    }

    class BMR(ulong val) : BMQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2C139FF160FAB5F;
        }
    }

    class BMS(ulong val) : BMR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x728B2931ECE39B1;
        }
    }

    class BMT(ulong val) : BMS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1217CD775E18E97;
        }
    }

    class BMU(ulong val) : BMT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5BDA889EC9A7EE0;
        }
    }

    class BMV(ulong val) : BMU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C54D46A2A941C0;
        }
    }

    class BMW(ulong val) : BMV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7BD9B166F9F7FB8;
        }
    }

    class BMX(ulong val) : BMW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53E990C4539E17A;
        }
    }

    class BMY(ulong val) : BMX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6B38C9D547F9E0C;
        }
    }

    class BMZ(ulong val) : BMY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11D5A5303CDD4CC;
        }
    }

    class BNA(ulong val) : BMZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x455AFB8F1134F1B;
        }
    }

    class BNB(ulong val) : BNA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9626F9ECE877B19;
        }
    }

    class BNC(ulong val) : BNB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8A4B7C56582AD66;
        }
    }

    class BND(ulong val) : BNC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x190789ABD36767F;
        }
    }

    class BNE(ulong val) : BND(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C894CB7D16626C;
        }
    }

    class BNF(ulong val) : BNE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20FE040339D7F88;
        }
    }

    class BNG(ulong val) : BNF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x29C2633EE3D4793;
        }
    }

    class BNH(ulong val) : BNG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6932B7DB63633F5;
        }
    }

    class BNI(ulong val) : BNH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x97B5596A57FA75E;
        }
    }

    class BNJ(ulong val) : BNI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x152AFCD3FFFF5B3;
        }
    }

    class BNK(ulong val) : BNJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E761E2565B98B3;
        }
    }

    class BNL(ulong val) : BNK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2FC6443640653C0;
        }
    }

    class BNM(ulong val) : BNL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4BCC6B3AC8FB5E5;
        }
    }

    class BNN(ulong val) : BNM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E4E6B3CC544FB7;
        }
    }

    class BNO(ulong val) : BNN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x424EBC484A4215F;
        }
    }

    class BNP(ulong val) : BNO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C9FDDBABF3178F;
        }
    }

    class BNQ(ulong val) : BNP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x98B67DF07265522;
        }
    }

    class BNR(ulong val) : BNQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55D6043B17D9C0F;
        }
    }

    class BNS(ulong val) : BNR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x75F0FA9B0F2D76D;
        }
    }

    class BNT(ulong val) : BNS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x591F8F7007E8B0A;
        }
    }

    class BNU(ulong val) : BNT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39378072A45CA5F;
        }
    }

    class BNV(ulong val) : BNU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5DED03B25630AB9;
        }
    }

    class BNW(ulong val) : BNV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x91A8EB0220195C6;
        }
    }

    class BNX(ulong val) : BNW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56352D17AE20603;
        }
    }

    class BNY(ulong val) : BNX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C2DA0FFDB8D938;
        }
    }

    class BNZ(ulong val) : BNY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D8828EF9C4B66E;
        }
    }

    class BOA(ulong val) : BNZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x672261E90A0EF22;
        }
    }

    class BOB(ulong val) : BOA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A52DACE8EB15BA;
        }
    }

    class BOC(ulong val) : BOB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x713262C59ECD58F;
        }
    }

    class BOD(ulong val) : BOC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x902691267FBD30E;
        }
    }

    class BOE(ulong val) : BOD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x98078D48714C8E5;
        }
    }

    class BOF(ulong val) : BOE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48EBBB17CA06AFE;
        }
    }

    class BOG(ulong val) : BOF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79660B9712D264D;
        }
    }

    class BOH(ulong val) : BOG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x41FD5AD15481C61;
        }
    }

    class BOI(ulong val) : BOH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x317EBF930C844FF;
        }
    }

    class BOJ(ulong val) : BOI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A153C5DF6539C4;
        }
    }

    class BOK(ulong val) : BOJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x640D077B9606AD7;
        }
    }

    class BOL(ulong val) : BOK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x171CF366DF7DF5D;
        }
    }

    class BOM(ulong val) : BOL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FE037FB5B5A925;
        }
    }

    class BON(ulong val) : BOM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8CC65271BB3F33D;
        }
    }

    class BOO(ulong val) : BON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x98C4029A73B10CB;
        }
    }

    class BOP(ulong val) : BOO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1598040D812A4B5;
        }
    }

    class BOQ(ulong val) : BOP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46C6F136762F7C9;
        }
    }

    class BOR(ulong val) : BOQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54DF8E37DB685DA;
        }
    }

    class BOS(ulong val) : BOR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C6F8931969A86C;
        }
    }

    class BOT(ulong val) : BOS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D7327CC5135122;
        }
    }

    class BOU(ulong val) : BOT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x44F3C0C896494C5;
        }
    }

    class BOV(ulong val) : BOU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94186CA916FA711;
        }
    }

    class BOW(ulong val) : BOV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x771EAF249E1B6D1;
        }
    }

    class BOX(ulong val) : BOW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16F38CBB840C8DC;
        }
    }

    class BOY(ulong val) : BOX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x75B4F87A708EFFA;
        }
    }

    class BOZ(ulong val) : BOY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8F6D2ADE713E5FE;
        }
    }

    class BPA(ulong val) : BOZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48DD64109463665;
        }
    }

    class BPB(ulong val) : BPA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2643DD09C3F4891;
        }
    }

    class BPC(ulong val) : BPB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2581DFDD063CC8B;
        }
    }

    class BPD(ulong val) : BPC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x32A300E60DDB6BC;
        }
    }

    class BPE(ulong val) : BPD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x67E3B1D94A128E7;
        }
    }

    class BPF(ulong val) : BPE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3417B625F958E82;
        }
    }

    class BPG(ulong val) : BPF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E918C4538273D0;
        }
    }

    class BPH(ulong val) : BPG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3E17DBFA19CA35E;
        }
    }

    class BPI(ulong val) : BPH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82A4F86B11EA777;
        }
    }

    class BPJ(ulong val) : BPI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8E9E55C58FECE57;
        }
    }

    class BPK(ulong val) : BPJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20DBE6A61D96DE1;
        }
    }

    class BPL(ulong val) : BPK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x459AE31E3165CA2;
        }
    }

    class BPM(ulong val) : BPL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2131A087554C311;
        }
    }

    class BPN(ulong val) : BPM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6DBE41F3D3BF700;
        }
    }

    class BPO(ulong val) : BPN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C3B514D9CF2D30;
        }
    }

    class BPP(ulong val) : BPO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x548AEF0B92002F5;
        }
    }

    class BPQ(ulong val) : BPP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x846187F46333267;
        }
    }

    class BPR(ulong val) : BPQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54F7ADDC174B6A3;
        }
    }

    class BPS(ulong val) : BPR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9354F82C1C2FB0F;
        }
    }

    class BPT(ulong val) : BPS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2359453C879F02C;
        }
    }

    class BPU(ulong val) : BPT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x41085DE59CB1CFB;
        }
    }

    class BPV(ulong val) : BPU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FB5F3E07127AAB;
        }
    }

    class BPW(ulong val) : BPV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D4760A6A5D2BF9;
        }
    }

    class BPX(ulong val) : BPW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DA311FB79BE4C8;
        }
    }

    class BPY(ulong val) : BPX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1F8A956D5D83536;
        }
    }

    class BPZ(ulong val) : BPY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3AD5553B906AD84;
        }
    }

    class BQA(ulong val) : BPZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x334EE52DD5D62DD;
        }
    }

    class BQB(ulong val) : BQA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D833EB2AA4F50F;
        }
    }

    class BQC(ulong val) : BQB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19EAA8AB414A6A8;
        }
    }

    class BQD(ulong val) : BQC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x39ED31842D3ED50;
        }
    }

    class BQE(ulong val) : BQD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28C27C1E3FE80DA;
        }
    }

    class BQF(ulong val) : BQE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BDB43525740506;
        }
    }

    class BQG(ulong val) : BQF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A612CEF95E489A;
        }
    }

    class BQH(ulong val) : BQG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B53F458FC0DEED;
        }
    }

    class BQI(ulong val) : BQH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x507850EB47BDB89;
        }
    }

    class BQJ(ulong val) : BQI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E03E55BC4169A3;
        }
    }

    class BQK(ulong val) : BQJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1769A49CE081B61;
        }
    }

    class BQL(ulong val) : BQK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8859E70F393565E;
        }
    }

    class BQM(ulong val) : BQL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FE9C93BC33FB06;
        }
    }

    class BQN(ulong val) : BQM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6953604331B8432;
        }
    }

    class BQO(ulong val) : BQN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x266743FBB66ACF3;
        }
    }

    class BQP(ulong val) : BQO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85E4C426EC6CBDB;
        }
    }

    class BQQ(ulong val) : BQP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x13C0596A2831CFF;
        }
    }

    class BQR(ulong val) : BQQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E9594E16FDAFC6;
        }
    }

    class BQS(ulong val) : BQR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x87690F041C74A84;
        }
    }

    class BQT(ulong val) : BQS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1CDC9F85AEB43EC;
        }
    }

    class BQU(ulong val) : BQT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E160C839C29F2A;
        }
    }

    class BQV(ulong val) : BQU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4376865AE491C50;
        }
    }

    class BQW(ulong val) : BQV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88F2FE8CD747457;
        }
    }

    class BQX(ulong val) : BQW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x30867E788BC0BBA;
        }
    }

    class BQY(ulong val) : BQX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45CB380DC027109;
        }
    }

    class BQZ(ulong val) : BQY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80E5FDF10B07035;
        }
    }

    class BRA(ulong val) : BQZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F834DFD59FAAC2;
        }
    }

    class BRB(ulong val) : BRA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3611AB4BBA29DB7;
        }
    }

    class BRC(ulong val) : BRB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x233A88B194876BF;
        }
    }

    class BRD(ulong val) : BRC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FBA818C952B3AF;
        }
    }

    class BRE(ulong val) : BRD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x95140B0C8F2A610;
        }
    }

    class BRF(ulong val) : BRE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x751C2CD25702816;
        }
    }

    class BRG(ulong val) : BRF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50065B4BFD6F12D;
        }
    }

    class BRH(ulong val) : BRG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x21FAF77DFBEC20E;
        }
    }

    class BRI(ulong val) : BRH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F96D4115C28F9C;
        }
    }

    class BRJ(ulong val) : BRI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A9E4E99D0F8483;
        }
    }

    class BRK(ulong val) : BRJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3754917BA14F940;
        }
    }

    class BRL(ulong val) : BRK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7FBFDD42426A485;
        }
    }

    class BRM(ulong val) : BRL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9981424C7FEE638;
        }
    }

    class BRN(ulong val) : BRM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x794B021F625225B;
        }
    }

    class BRO(ulong val) : BRN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5D24FF4E9C86151;
        }
    }

    class BRP(ulong val) : BRO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4862F718D52EBC8;
        }
    }

    class BRQ(ulong val) : BRP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x65E96D16B85DC31;
        }
    }

    class BRR(ulong val) : BRQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x84BFCA74D0449D0;
        }
    }

    class BRS(ulong val) : BRR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x262AB0F86A4DF65;
        }
    }

    class BRT(ulong val) : BRS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F4B16B0A499A02;
        }
    }

    class BRU(ulong val) : BRT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64691F825EDAA44;
        }
    }

    class BRV(ulong val) : BRU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4624FE867612D78;
        }
    }

    class BRW(ulong val) : BRV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A807A27535F590;
        }
    }

    class BRX(ulong val) : BRW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x107988E3C595227;
        }
    }

    class BRY(ulong val) : BRX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F5D412CBF0E2FF;
        }
    }

    class BRZ(ulong val) : BRY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x76EAADD73AA2E62;
        }
    }

    class BSA(ulong val) : BRZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x272A40E51F37214;
        }
    }

    class BSB(ulong val) : BSA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x78483B4F577FED7;
        }
    }

    class BSC(ulong val) : BSB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6577553A757CFF2;
        }
    }

    class BSD(ulong val) : BSC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3C809B9E0D24614;
        }
    }

    class BSE(ulong val) : BSD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FA0005F3FED7CB;
        }
    }

    class BSF(ulong val) : BSE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x617DC59F73DDFA9;
        }
    }

    class BSG(ulong val) : BSF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7EDE912BD5BBB76;
        }
    }

    class BSH(ulong val) : BSG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5501E5AB38686FF;
        }
    }

    class BSI(ulong val) : BSH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x660CD01A1551F93;
        }
    }

    class BSJ(ulong val) : BSI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11191E6A54961E0;
        }
    }

    class BSK(ulong val) : BSJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x526578AD601ECC5;
        }
    }

    class BSL(ulong val) : BSK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x20936A0281EF3B3;
        }
    }

    class BSM(ulong val) : BSL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57C942E540FB2A7;
        }
    }

    class BSN(ulong val) : BSM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x690253B75E43210;
        }
    }

    class BSO(ulong val) : BSN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1512613281ACB00;
        }
    }

    class BSP(ulong val) : BSO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x59DA2FA9E5B9919;
        }
    }

    class BSQ(ulong val) : BSP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x66E053D584D1C94;
        }
    }

    class BSR(ulong val) : BSQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1B72B63206661F7;
        }
    }

    class BSS(ulong val) : BSR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A274CECB48BC38;
        }
    }

    class BST(ulong val) : BSS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x83862CE61F9093D;
        }
    }

    class BSU(ulong val) : BST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5825CB0702323BF;
        }
    }

    class BSV(ulong val) : BSU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3715F9BE44A39AE;
        }
    }

    class BSW(ulong val) : BSV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x32F6455A4E5F641;
        }
    }

    class BSX(ulong val) : BSW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x341A07B14AADCED;
        }
    }

    class BSY(ulong val) : BSX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B6210E498F7A51;
        }
    }

    class BSZ(ulong val) : BSY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FC2C6C7A1FAD2D;
        }
    }

    class BTA(ulong val) : BSZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x76DEE2BFFB23C5F;
        }
    }

    class BTB(ulong val) : BTA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7404A7BB19334CE;
        }
    }

    class BTC(ulong val) : BTB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25873B3186F3A27;
        }
    }

    class BTD(ulong val) : BTC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x219D4FA2387AD43;
        }
    }

    class BTE(ulong val) : BTD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5DD53249EBFC694;
        }
    }

    class BTF(ulong val) : BTE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A8ECD61948CF6A;
        }
    }

    class BTG(ulong val) : BTF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7B2119D0357CFE0;
        }
    }

    class BTH(ulong val) : BTG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A6EB4BBBB49C83;
        }
    }

    class BTI(ulong val) : BTH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B5670382FB366B;
        }
    }

    class BTJ(ulong val) : BTI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x81B08BA285AD838;
        }
    }

    class BTK(ulong val) : BTJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6689D63AA151EA3;
        }
    }

    class BTL(ulong val) : BTK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x657E5A4959D0DBA;
        }
    }

    class BTM(ulong val) : BTL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x33A9962E9E20124;
        }
    }

    class BTN(ulong val) : BTM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x210619512014277;
        }
    }

    class BTO(ulong val) : BTN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x69BBAD5B1C0B302;
        }
    }

    class BTP(ulong val) : BTO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4DCEDD04C4D6DB5;
        }
    }

    class BTQ(ulong val) : BTP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1652920ABB33ED1;
        }
    }

    class BTR(ulong val) : BTQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x855DD76DAC302E0;
        }
    }

    class BTS(ulong val) : BTR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C5474B6AA4F3CF;
        }
    }

    class BTT(ulong val) : BTS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BCC4624F2B190C;
        }
    }

    class BTU(ulong val) : BTT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x63E6CFFAE796640;
        }
    }

    class BTV(ulong val) : BTU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D8CC874B4027A9;
        }
    }

    class BTW(ulong val) : BTV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7C2C0CEC8F4DC27;
        }
    }

    class BTX(ulong val) : BTW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1577FADE47D5D86;
        }
    }

    class BTY(ulong val) : BTX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BC990FB23621F0;
        }
    }

    class BTZ(ulong val) : BTY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x51E1FA07AB3073E;
        }
    }

    class BUA(ulong val) : BTZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95678A356756344;
        }
    }

    class BUB(ulong val) : BUA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x33A08CAC6FC15E9;
        }
    }

    class BUC(ulong val) : BUB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A7DB481AE23383;
        }
    }

    class BUD(ulong val) : BUC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CEC97D51388595;
        }
    }

    class BUE(ulong val) : BUD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91F8735420834D7;
        }
    }

    class BUF(ulong val) : BUE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11E6108F7755255;
        }
    }

    class BUG(ulong val) : BUF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x650C72C875817C5;
        }
    }

    class BUH(ulong val) : BUG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87BE01E9D4322C8;
        }
    }

    class BUI(ulong val) : BUH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x537C6ADEDCAAC01;
        }
    }

    class BUJ(ulong val) : BUI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C2A73BE82CC546;
        }
    }

    class BUK(ulong val) : BUJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x32E7E61C50E7737;
        }
    }

    class BUL(ulong val) : BUK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x936BB4FD65093DC;
        }
    }

    class BUM(ulong val) : BUL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96E9DDE1DBC9573;
        }
    }

    class BUN(ulong val) : BUM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x90AC4347957F0DA;
        }
    }

    class BUO(ulong val) : BUN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x90C60CDC16DD5E2;
        }
    }

    class BUP(ulong val) : BUO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B738326DF01A10;
        }
    }

    class BUQ(ulong val) : BUP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A4E0A43705FE85;
        }
    }

    class BUR(ulong val) : BUQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x137326623D867A8;
        }
    }

    class BUS(ulong val) : BUR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1056B4E0AD32F0D;
        }
    }

    class BUT(ulong val) : BUS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1810CD89312E4D5;
        }
    }

    class BUU(ulong val) : BUT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E556C4F94E0E74;
        }
    }

    class BUV(ulong val) : BUU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x47F7676ED0E9068;
        }
    }

    class BUW(ulong val) : BUV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x356B7132C7075D6;
        }
    }

    class BUX(ulong val) : BUW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87B8B76D32C66BC;
        }
    }

    class BUY(ulong val) : BUX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x784117B7F2B178B;
        }
    }

    class BUZ(ulong val) : BUY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x44BCEA777C850EE;
        }
    }

    class BVA(ulong val) : BUZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2EEE8D660D0958D;
        }
    }

    class BVB(ulong val) : BVA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x21BAC82C95BAD4C;
        }
    }

    class BVC(ulong val) : BVB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x84444C90CE297D1;
        }
    }

    class BVD(ulong val) : BVC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x87323F5C7A4F48E;
        }
    }

    class BVE(ulong val) : BVD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B217002E24F3D3;
        }
    }

    class BVF(ulong val) : BVE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x421091B49E8C713;
        }
    }

    class BVG(ulong val) : BVF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78C4007D6758917;
        }
    }

    class BVH(ulong val) : BVG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5B3212579796153;
        }
    }

    class BVI(ulong val) : BVH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x692DFC97E42C20C;
        }
    }

    class BVJ(ulong val) : BVI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A42975365E16D1;
        }
    }

    class BVK(ulong val) : BVJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74A910C62161E71;
        }
    }

    class BVL(ulong val) : BVK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27E4113C7C61979;
        }
    }

    class BVM(ulong val) : BVL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7FAA33E9C5E8A3A;
        }
    }

    class BVN(ulong val) : BVM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x877C2533C5DD204;
        }
    }

    class BVO(ulong val) : BVN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1C0C5817F89A75E;
        }
    }

    class BVP(ulong val) : BVO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x180E7D5EF84276C;
        }
    }

    class BVQ(ulong val) : BVP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2D4E627B087A3F5;
        }
    }

    class BVR(ulong val) : BVQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A6D1ECC797A1F2;
        }
    }

    class BVS(ulong val) : BVR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6BD8CCD4BF0FD9B;
        }
    }

    class BVT(ulong val) : BVS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x480358A324F026B;
        }
    }

    class BVU(ulong val) : BVT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A3D3D0E208336E;
        }
    }

    class BVV(ulong val) : BVU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x90F8C0FD67C76AC;
        }
    }

    class BVW(ulong val) : BVV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49C42561EA4D6F4;
        }
    }

    class BVX(ulong val) : BVW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3699BA87B77FE1B;
        }
    }

    class BVY(ulong val) : BVX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23896865A11450E;
        }
    }

    class BVZ(ulong val) : BVY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FF0DC45F1F00FC;
        }
    }

    class BWA(ulong val) : BVZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72BC19B366D90DE;
        }
    }

    class BWB(ulong val) : BWA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x987C10CA8AD357B;
        }
    }

    class BWC(ulong val) : BWB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7F8B52E8E184075;
        }
    }

    class BWD(ulong val) : BWC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x766ECE21CE70EDC;
        }
    }

    class BWE(ulong val) : BWD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x412396C9DE1F5E6;
        }
    }

    class BWF(ulong val) : BWE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1357507082AB10C;
        }
    }

    class BWG(ulong val) : BWF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82B877E9515A9A9;
        }
    }

    class BWH(ulong val) : BWG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5D5F180E621164A;
        }
    }

    class BWI(ulong val) : BWH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6388A8DA4DAA476;
        }
    }

    class BWJ(ulong val) : BWI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5ED23A3E017E7EC;
        }
    }

    class BWK(ulong val) : BWJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x104BF7D3E789D4C;
        }
    }

    class BWL(ulong val) : BWK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D8C64A7CA9E556;
        }
    }

    class BWM(ulong val) : BWL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x95130850EC8AB5F;
        }
    }

    class BWN(ulong val) : BWM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36E6209377D2EEE;
        }
    }

    class BWO(ulong val) : BWN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x886833F16E4CC13;
        }
    }

    class BWP(ulong val) : BWO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E9395F38D4A948;
        }
    }

    class BWQ(ulong val) : BWP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x505B49B6DF39AE7;
        }
    }

    class BWR(ulong val) : BWQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9714BEF2164BCBA;
        }
    }

    class BWS(ulong val) : BWR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50DC16230F995D6;
        }
    }

    class BWT(ulong val) : BWS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E7B5507FFC7554;
        }
    }

    class BWU(ulong val) : BWT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4EEE7FD46EFD704;
        }
    }

    class BWV(ulong val) : BWU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x653E9B4181FF776;
        }
    }

    class BWW(ulong val) : BWV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8700FB2DF274EAC;
        }
    }

    class BWX(ulong val) : BWW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39DF802B1772ADB;
        }
    }

    class BWY(ulong val) : BWX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B8F232DDA16860;
        }
    }

    class BWZ(ulong val) : BWY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87D26049B209C0F;
        }
    }

    class BXA(ulong val) : BWZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D6AD4357120008;
        }
    }

    class BXB(ulong val) : BXA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2EE6379D057000A;
        }
    }

    class BXC(ulong val) : BXB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x202D60726D8812E;
        }
    }

    class BXD(ulong val) : BXC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D58E9C22000EC6;
        }
    }

    class BXE(ulong val) : BXD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C9B856EF14C372;
        }
    }

    class BXF(ulong val) : BXE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82F324B2448A19B;
        }
    }

    class BXG(ulong val) : BXF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x567D70376A2AA09;
        }
    }

    class BXH(ulong val) : BXG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x538C3FFCF804562;
        }
    }

    class BXI(ulong val) : BXH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E8FEB37320F8F0;
        }
    }

    class BXJ(ulong val) : BXI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9974D585BEEF378;
        }
    }

    class BXK(ulong val) : BXJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B0490210913A26;
        }
    }

    class BXL(ulong val) : BXK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x50562165F983790;
        }
    }

    class BXM(ulong val) : BXL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1547084CBF6AD99;
        }
    }

    class BXN(ulong val) : BXM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11B76C09114757E;
        }
    }

    class BXO(ulong val) : BXN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x37BAE5B402630F7;
        }
    }

    class BXP(ulong val) : BXO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BAA232EAFD8A10;
        }
    }

    class BXQ(ulong val) : BXP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x50F978B583B5FED;
        }
    }

    class BXR(ulong val) : BXQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B0A5E7CFED9716;
        }
    }

    class BXS(ulong val) : BXR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68AEFA5F2D603C1;
        }
    }

    class BXT(ulong val) : BXS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20F6D4B919D60F2;
        }
    }

    class BXU(ulong val) : BXT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2CC953A9BF58E05;
        }
    }

    class BXV(ulong val) : BXU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E3B503CE986F92;
        }
    }

    class BXW(ulong val) : BXV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x813AB7A69953CE2;
        }
    }

    class BXX(ulong val) : BXW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25991516E1BA631;
        }
    }

    class BXY(ulong val) : BXX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8BACB8705173FBC;
        }
    }

    class BXZ(ulong val) : BXY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9712813E5E2836E;
        }
    }

    class BYA(ulong val) : BXZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1ADAA1F37193A01;
        }
    }

    class BYB(ulong val) : BYA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C574567AE60636;
        }
    }

    class BYC(ulong val) : BYB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3EBAC4E447708FB;
        }
    }

    class BYD(ulong val) : BYC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9657AF19DAFC74D;
        }
    }

    class BYE(ulong val) : BYD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x539948C52C3F7E6;
        }
    }

    class BYF(ulong val) : BYE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1DB7323EA17F6B1;
        }
    }

    class BYG(ulong val) : BYF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2D8AFA6A357585A;
        }
    }

    class BYH(ulong val) : BYG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x443F2ADC7F60408;
        }
    }

    class BYI(ulong val) : BYH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61B72D64BBA5B3F;
        }
    }

    class BYJ(ulong val) : BYI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AFFD025263F004;
        }
    }

    class BYK(ulong val) : BYJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x26E31C8CF457AA6;
        }
    }

    class BYL(ulong val) : BYK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x930B0D119D950DE;
        }
    }

    class BYM(ulong val) : BYL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15D5EE045AADB0B;
        }
    }

    class BYN(ulong val) : BYM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4BBCF114A4CD60A;
        }
    }

    class BYO(ulong val) : BYN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B003306E438A4F;
        }
    }

    class BYP(ulong val) : BYO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x71FD25A8E741C45;
        }
    }

    class BYQ(ulong val) : BYP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x237D0D48A6195E5;
        }
    }

    class BYR(ulong val) : BYQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x62B2433271A846E;
        }
    }

    class BYS(ulong val) : BYR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3DA8570F5BBFBCE;
        }
    }

    class BYT(ulong val) : BYS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3447EB0D5E98E07;
        }
    }

    class BYU(ulong val) : BYT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x748F34FE035D222;
        }
    }

    class BYV(ulong val) : BYU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DA28E4C752D291;
        }
    }

    class BYW(ulong val) : BYV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7AF3A910D84017E;
        }
    }

    class BYX(ulong val) : BYW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7638A1E64106961;
        }
    }

    class BYY(ulong val) : BYX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x90BD373B3ABE08D;
        }
    }

    class BYZ(ulong val) : BYY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x78F3E21A8A3C50B;
        }
    }

    class BZA(ulong val) : BYZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A703ABC6DCDD9A;
        }
    }

    class BZB(ulong val) : BZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B7F286BF100098;
        }
    }

    class BZC(ulong val) : BZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16329349C52E230;
        }
    }

    class BZD(ulong val) : BZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C138DAD402416A;
        }
    }

    class BZE(ulong val) : BZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x104F9EBCEC7AA2F;
        }
    }

    class BZF(ulong val) : BZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x401871975FD4548;
        }
    }

    class BZG(ulong val) : BZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x40EDC81E2C63BD1;
        }
    }

    class BZH(ulong val) : BZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x303942C39AF1640;
        }
    }

    class BZI(ulong val) : BZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2CE5DA794F82DD3;
        }
    }

    class BZJ(ulong val) : BZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x196BC7B5426E1F5;
        }
    }

    class BZK(ulong val) : BZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D349932B0B1F75;
        }
    }

    class BZL(ulong val) : BZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x669DDB988CED46D;
        }
    }

    class BZM(ulong val) : BZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6632E34728B33E1;
        }
    }

    class BZN(ulong val) : BZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x13713F68126B3F2;
        }
    }

    class BZO(ulong val) : BZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x20070A3D92A8CC4;
        }
    }

    class BZP(ulong val) : BZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79F5D43B65BA93F;
        }
    }

    class BZQ(ulong val) : BZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79C5543F5AFBDC3;
        }
    }

    class BZR(ulong val) : BZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x903FEFE0F013DB0;
        }
    }

    class BZS(ulong val) : BZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56FD31B68AF84A2;
        }
    }

    class BZT(ulong val) : BZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48B59A492F11586;
        }
    }

    class BZU(ulong val) : BZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4BB0023691893B0;
        }
    }

    class BZV(ulong val) : BZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63143C0EE7A2553;
        }
    }

    class BZW(ulong val) : BZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x10F7BAB2C67E335;
        }
    }

    class BZX(ulong val) : BZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1169B695735583A;
        }
    }

    class BZY(ulong val) : BZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5CFACADC1FC651A;
        }
    }

    class BZZ(ulong val) : BZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1244ADFC3603778;
        }
    }

    class CAA(ulong val) : BZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x669BE75605A85EE;
        }
    }

    class CAB(ulong val) : CAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15BDF786A05D383;
        }
    }

    class CAC(ulong val) : CAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80D0151B6DFD346;
        }
    }

    class CAD(ulong val) : CAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6C409ACC1769108;
        }
    }

    class CAE(ulong val) : CAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43D6F5DA14870FF;
        }
    }

    class CAF(ulong val) : CAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BEA9668F75271B;
        }
    }

    class CAG(ulong val) : CAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x238DD686A599A3C;
        }
    }

    class CAH(ulong val) : CAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x750E7D2159AA529;
        }
    }

    class CAI(ulong val) : CAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x294F4EAB455287F;
        }
    }

    class CAJ(ulong val) : CAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D48DD20EAC38A1;
        }
    }

    class CAK(ulong val) : CAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67C897943DA1D73;
        }
    }

    class CAL(ulong val) : CAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E3E300CB05B89C;
        }
    }

    class CAM(ulong val) : CAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x860B6FEDB4300C8;
        }
    }

    class CAN(ulong val) : CAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x92776AA3EB9C473;
        }
    }

    class CAO(ulong val) : CAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x560CE030463ABA1;
        }
    }

    class CAP(ulong val) : CAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E33C3C77419AB3;
        }
    }

    class CAQ(ulong val) : CAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72F1C75C33BDA65;
        }
    }

    class CAR(ulong val) : CAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1809F3F709E1211;
        }
    }

    class CAS(ulong val) : CAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7D6A8BBE1708C95;
        }
    }

    class CAT(ulong val) : CAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22B4D0127FF26A9;
        }
    }

    class CAU(ulong val) : CAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2304DDAF9A95EFB;
        }
    }

    class CAV(ulong val) : CAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C6E13EA10EAE68;
        }
    }

    class CAW(ulong val) : CAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x66C5110ADFB06DB;
        }
    }

    class CAX(ulong val) : CAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7E805E092A69F58;
        }
    }

    class CAY(ulong val) : CAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2381985A01A3605;
        }
    }

    class CAZ(ulong val) : CAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x975BED985BFF06D;
        }
    }

    class CBA(ulong val) : CAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x449B00953769D25;
        }
    }

    class CBB(ulong val) : CBA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x38FD8A8B64D7A9A;
        }
    }

    class CBC(ulong val) : CBB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11A94A22BC84B80;
        }
    }

    class CBD(ulong val) : CBC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x580B21BEC3D85B4;
        }
    }

    class CBE(ulong val) : CBD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x376C10528167C25;
        }
    }

    class CBF(ulong val) : CBE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D520DF54AC52B5;
        }
    }

    class CBG(ulong val) : CBF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x322D83A976BA0CC;
        }
    }

    class CBH(ulong val) : CBG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C24883C334A6ED;
        }
    }

    class CBI(ulong val) : CBH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E13C394BA79052;
        }
    }

    class CBJ(ulong val) : CBI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x410B5FAE4A7BEAA;
        }
    }

    class CBK(ulong val) : CBJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5681BB9C1AF7990;
        }
    }

    class CBL(ulong val) : CBK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23E45AFE987B73B;
        }
    }

    class CBM(ulong val) : CBL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7EF7F9299FBA4B3;
        }
    }

    class CBN(ulong val) : CBM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61B95BF6DC81D4B;
        }
    }

    class CBO(ulong val) : CBN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x868123CB4346707;
        }
    }

    class CBP(ulong val) : CBO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9790C15E21C2DB1;
        }
    }

    class CBQ(ulong val) : CBP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3363505BF9ECA53;
        }
    }

    class CBR(ulong val) : CBQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7C7F9ACD96F76DE;
        }
    }

    class CBS(ulong val) : CBR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FF41E44DC049A0;
        }
    }

    class CBT(ulong val) : CBS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CDC8B10EA7BAC5;
        }
    }

    class CBU(ulong val) : CBT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x41FABF00258FCB2;
        }
    }

    class CBV(ulong val) : CBU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BBC6D49564DF4D;
        }
    }

    class CBW(ulong val) : CBV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4D0712DE1DF6BF0;
        }
    }

    class CBX(ulong val) : CBW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F91A8879BF68F1;
        }
    }

    class CBY(ulong val) : CBX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78D359CF79C5476;
        }
    }

    class CBZ(ulong val) : CBY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x555E96DD3EC16D7;
        }
    }

    class CCA(ulong val) : CBZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88921D97FAD70A8;
        }
    }

    class CCB(ulong val) : CCA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x75E98583E7C5754;
        }
    }

    class CCC(ulong val) : CCB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F4E88F688F4580;
        }
    }

    class CCD(ulong val) : CCC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x37B53A620368EC3;
        }
    }

    class CCE(ulong val) : CCD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98F1F7162C01C15;
        }
    }

    class CCF(ulong val) : CCE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x105F59451828532;
        }
    }

    class CCG(ulong val) : CCF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2151E097F7AE27F;
        }
    }

    class CCH(ulong val) : CCG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DD8DE11DC041B4;
        }
    }

    class CCI(ulong val) : CCH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6F3C66BC6BB7414;
        }
    }

    class CCJ(ulong val) : CCI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4AF9444C1207F9E;
        }
    }

    class CCK(ulong val) : CCJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x654C4BB89C6E3EE;
        }
    }

    class CCL(ulong val) : CCK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x44B776DD1AF3C67;
        }
    }

    class CCM(ulong val) : CCL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8E178A092C474B6;
        }
    }

    class CCN(ulong val) : CCM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7152FBA0DCBF701;
        }
    }

    class CCO(ulong val) : CCN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x829E844824259FB;
        }
    }

    class CCP(ulong val) : CCO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x180ABA78E34550E;
        }
    }

    class CCQ(ulong val) : CCP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x499E7FBA7EA490C;
        }
    }

    class CCR(ulong val) : CCQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60212DA3C4634F7;
        }
    }

    class CCS(ulong val) : CCR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x904CD65B4874C24;
        }
    }

    class CCT(ulong val) : CCS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5DFD7502FDF4254;
        }
    }

    class CCU(ulong val) : CCT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16232DC165E22C7;
        }
    }

    class CCV(ulong val) : CCU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x330FD703E411EC1;
        }
    }

    class CCW(ulong val) : CCV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4FED985B9161824;
        }
    }

    class CCX(ulong val) : CCW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E942FFB26DC459;
        }
    }

    class CCY(ulong val) : CCX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x820DA8C802201BA;
        }
    }

    class CCZ(ulong val) : CCY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74021D1534E5B23;
        }
    }

    class CDA(ulong val) : CCZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6EBF98805B81E92;
        }
    }

    class CDB(ulong val) : CDA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8603E5447ABDB40;
        }
    }

    class CDC(ulong val) : CDB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x345D2186CC23C68;
        }
    }

    class CDD(ulong val) : CDC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A14AEA2728AA45;
        }
    }

    class CDE(ulong val) : CDD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C559ED5A846526;
        }
    }

    class CDF(ulong val) : CDE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x248ABD0177F2007;
        }
    }

    class CDG(ulong val) : CDF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4915B26EF8B1A2C;
        }
    }

    class CDH(ulong val) : CDG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7942BA25FA91523;
        }
    }

    class CDI(ulong val) : CDH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F3CE2DB59F8FBB;
        }
    }

    class CDJ(ulong val) : CDI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x65459A7434E1425;
        }
    }

    class CDK(ulong val) : CDJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x33107F54AE9E014;
        }
    }

    class CDL(ulong val) : CDK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95FA44C82A1FE5E;
        }
    }

    class CDM(ulong val) : CDL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x29E831E15D70E0E;
        }
    }

    class CDN(ulong val) : CDM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4516B0BC53FEF41;
        }
    }

    class CDO(ulong val) : CDN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FEDECECFDFDA29;
        }
    }

    class CDP(ulong val) : CDO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8941789ED520D33;
        }
    }

    class CDQ(ulong val) : CDP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C1DE285948E627;
        }
    }

    class CDR(ulong val) : CDQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D1662BCA4D27B3;
        }
    }

    class CDS(ulong val) : CDR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62799D196F8A1E1;
        }
    }

    class CDT(ulong val) : CDS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x90DA7A91A479AE3;
        }
    }

    class CDU(ulong val) : CDT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6029BD3357BDD37;
        }
    }

    class CDV(ulong val) : CDU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17B67C25F822D11;
        }
    }

    class CDW(ulong val) : CDV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67C8804B262F982;
        }
    }

    class CDX(ulong val) : CDW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x705B0AA52973A78;
        }
    }

    class CDY(ulong val) : CDX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D24FC06B450BA4;
        }
    }

    class CDZ(ulong val) : CDY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x76C3C61BA9418DF;
        }
    }

    class CEA(ulong val) : CDZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x873E3EBBAACA24F;
        }
    }

    class CEB(ulong val) : CEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x929FFF56F841D7A;
        }
    }

    class CEC(ulong val) : CEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6129BDD8712F98C;
        }
    }

    class CED(ulong val) : CEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7AD09DB180D35DD;
        }
    }

    class CEE(ulong val) : CED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7F7AC0C4D0686E3;
        }
    }

    class CEF(ulong val) : CEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8CECEC847F0AA22;
        }
    }

    class CEG(ulong val) : CEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87C297660C91D92;
        }
    }

    class CEH(ulong val) : CEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2EB9731AE39B904;
        }
    }

    class CEI(ulong val) : CEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7061945EB34ADD4;
        }
    }

    class CEJ(ulong val) : CEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x25E086792A8B574;
        }
    }

    class CEK(ulong val) : CEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4021EFF250978FA;
        }
    }

    class CEL(ulong val) : CEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F419388AE4495C;
        }
    }

    class CEM(ulong val) : CEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3593D1C579A24FE;
        }
    }

    class CEN(ulong val) : CEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2DEED5B7D6ED083;
        }
    }

    class CEO(ulong val) : CEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x19107CBE1834ACE;
        }
    }

    class CEP(ulong val) : CEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70616BB091B9B2B;
        }
    }

    class CEQ(ulong val) : CEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FF79C93E66A91F;
        }
    }

    class CER(ulong val) : CEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1257D50B1B97DFF;
        }
    }

    class CES(ulong val) : CER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x62AC6E197C5E5D3;
        }
    }

    class CET(ulong val) : CES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x983FA865A324011;
        }
    }

    class CEU(ulong val) : CET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x175ABAA6A1BC5C1;
        }
    }

    class CEV(ulong val) : CEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86832C90B19DC61;
        }
    }

    class CEW(ulong val) : CEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96FCA190DBC67C6;
        }
    }

    class CEX(ulong val) : CEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87B6394379AEADB;
        }
    }

    class CEY(ulong val) : CEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1BE0815823DAFD9;
        }
    }

    class CEZ(ulong val) : CEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x277B2EFFB0E2A93;
        }
    }

    class CFA(ulong val) : CEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6738710E4528968;
        }
    }

    class CFB(ulong val) : CFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E982684F13CCB4;
        }
    }

    class CFC(ulong val) : CFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4781FB2F8AE98E2;
        }
    }

    class CFD(ulong val) : CFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x33CC6C6E5A14F90;
        }
    }

    class CFE(ulong val) : CFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D7DDF5EEA29C98;
        }
    }

    class CFF(ulong val) : CFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D492F0CF3249DE;
        }
    }

    class CFG(ulong val) : CFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A0264BCC5BA746;
        }
    }

    class CFH(ulong val) : CFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DAA988E1F4870B;
        }
    }

    class CFI(ulong val) : CFH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x71F4AA0672CBBAC;
        }
    }

    class CFJ(ulong val) : CFI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9329408BF8F10A3;
        }
    }

    class CFK(ulong val) : CFJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9965A52D1854292;
        }
    }

    class CFL(ulong val) : CFK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85E2D40369256B5;
        }
    }

    class CFM(ulong val) : CFL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F5D1E21AF04088;
        }
    }

    class CFN(ulong val) : CFM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5FA285346B1CC47;
        }
    }

    class CFO(ulong val) : CFN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7233F00479C89CD;
        }
    }

    class CFP(ulong val) : CFO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DD06016B9BF517;
        }
    }

    class CFQ(ulong val) : CFP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DD695BD2742EC6;
        }
    }

    class CFR(ulong val) : CFQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68A3CD7EDD2007D;
        }
    }

    class CFS(ulong val) : CFR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91DB1E686ACECF0;
        }
    }

    class CFT(ulong val) : CFS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5DEA6B2CB0FD8FF;
        }
    }

    class CFU(ulong val) : CFT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1ADDC8DF23AFD9A;
        }
    }

    class CFV(ulong val) : CFU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C592796F5BD5C2;
        }
    }

    class CFW(ulong val) : CFV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D9B974B98C28E4;
        }
    }

    class CFX(ulong val) : CFW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x344D520B40FFDFC;
        }
    }

    class CFY(ulong val) : CFX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1546F14487BEA12;
        }
    }

    class CFZ(ulong val) : CFY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9402571F7255DF3;
        }
    }

    class CGA(ulong val) : CFZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61C915E7B11D6CA;
        }
    }

    class CGB(ulong val) : CGA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x258C6D240F049EE;
        }
    }

    class CGC(ulong val) : CGB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x43DB15728A3FE71;
        }
    }

    class CGD(ulong val) : CGC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8CFE1647C1AAB62;
        }
    }

    class CGE(ulong val) : CGD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x555E8B18BE5DA6F;
        }
    }

    class CGF(ulong val) : CGE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x238BD37892272E0;
        }
    }

    class CGG(ulong val) : CGF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67BACCFFA6DDF5F;
        }
    }

    class CGH(ulong val) : CGG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3077AA60A6D4B6C;
        }
    }

    class CGI(ulong val) : CGH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D74C83E5A9D6BC;
        }
    }

    class CGJ(ulong val) : CGI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36ACD0D7FF17676;
        }
    }

    class CGK(ulong val) : CGJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70DF817C94B7F53;
        }
    }

    class CGL(ulong val) : CGK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6481754225A4939;
        }
    }

    class CGM(ulong val) : CGL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x79925518482C114;
        }
    }

    class CGN(ulong val) : CGM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x444F7F66BF6188D;
        }
    }

    class CGO(ulong val) : CGN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x979F3F977717A3F;
        }
    }

    class CGP(ulong val) : CGO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x404E3CE76EBECC5;
        }
    }

    class CGQ(ulong val) : CGP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x110B3597BD8CB39;
        }
    }

    class CGR(ulong val) : CGQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8E3120364E7CAD3;
        }
    }

    class CGS(ulong val) : CGR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73373A73B798B3A;
        }
    }

    class CGT(ulong val) : CGS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6B446D177062BF3;
        }
    }

    class CGU(ulong val) : CGT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B562564A119C9A;
        }
    }

    class CGV(ulong val) : CGU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x89028207550CC3D;
        }
    }

    class CGW(ulong val) : CGV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E37EA1B08BA4E1;
        }
    }

    class CGX(ulong val) : CGW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3E2496790CE6A04;
        }
    }

    class CGY(ulong val) : CGX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88C7EC581960742;
        }
    }

    class CGZ(ulong val) : CGY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x569594E6104E30F;
        }
    }

    class CHA(ulong val) : CGZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x81CCE798BCC3F35;
        }
    }

    class CHB(ulong val) : CHA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x18745BC7DAE20D3;
        }
    }

    class CHC(ulong val) : CHB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8CCF87AF2C2DE00;
        }
    }

    class CHD(ulong val) : CHC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7135E5781C08890;
        }
    }

    class CHE(ulong val) : CHD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4606AB8F9B7243F;
        }
    }

    class CHF(ulong val) : CHE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8971A344D596F3D;
        }
    }

    class CHG(ulong val) : CHF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x983F0011D6EFEA0;
        }
    }

    class CHH(ulong val) : CHG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73A8A94E5865E2C;
        }
    }

    class CHI(ulong val) : CHH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6AF8115A438C07C;
        }
    }

    class CHJ(ulong val) : CHI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3CAB130AF39F16A;
        }
    }

    class CHK(ulong val) : CHJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58C0BBB7D7ACA01;
        }
    }

    class CHL(ulong val) : CHK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x44F766C5AA334E3;
        }
    }

    class CHM(ulong val) : CHL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x575172765DAD6E2;
        }
    }

    class CHN(ulong val) : CHM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2113ED0253A4EEB;
        }
    }

    class CHO(ulong val) : CHN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x117FFB0FE5C871A;
        }
    }

    class CHP(ulong val) : CHO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18CB350B45A21F2;
        }
    }

    class CHQ(ulong val) : CHP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x915E17F9716608D;
        }
    }

    class CHR(ulong val) : CHQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x281F90707EA1820;
        }
    }

    class CHS(ulong val) : CHR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x151686728DE4EBF;
        }
    }

    class CHT(ulong val) : CHS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8105469198DC0E8;
        }
    }

    class CHU(ulong val) : CHT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8222C68CD1F040A;
        }
    }

    class CHV(ulong val) : CHU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x734765732CC8508;
        }
    }

    class CHW(ulong val) : CHV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22CF08739816DF4;
        }
    }

    class CHX(ulong val) : CHW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4451980EBEE7286;
        }
    }

    class CHY(ulong val) : CHX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x694F27410E8BD04;
        }
    }

    class CHZ(ulong val) : CHY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8088EDA4BEA1BDE;
        }
    }

    class CIA(ulong val) : CHZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x842AD88C4DD7372;
        }
    }

    class CIB(ulong val) : CIA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5600B8F66040518;
        }
    }

    class CIC(ulong val) : CIB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x965BC44E892D176;
        }
    }

    class CID(ulong val) : CIC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x673518C8C1AA31E;
        }
    }

    class CIE(ulong val) : CID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3364EAA2BA973BF;
        }
    }

    class CIF(ulong val) : CIE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6D7FA9663E7C43D;
        }
    }

    class CIG(ulong val) : CIF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4CFF5B94970536F;
        }
    }

    class CIH(ulong val) : CIG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5FC81AC8FA93CED;
        }
    }

    class CII(ulong val) : CIH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77FDEF41786E7DE;
        }
    }

    class CIJ(ulong val) : CII(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34D56199D474BC5;
        }
    }

    class CIK(ulong val) : CIJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2756748B2C30C65;
        }
    }

    class CIL(ulong val) : CIK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2CD3FDEC38C310F;
        }
    }

    class CIM(ulong val) : CIL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17A677697EC0BF8;
        }
    }

    class CIN(ulong val) : CIM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86115154396B4EA;
        }
    }

    class CIO(ulong val) : CIN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D2D53EF46CDDB9;
        }
    }

    class CIP(ulong val) : CIO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x823CACCC1710BE2;
        }
    }

    class CIQ(ulong val) : CIP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x258D8B7E950208D;
        }
    }

    class CIR(ulong val) : CIQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1BA475180EB7EC7;
        }
    }

    class CIS(ulong val) : CIR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1DBFFF1DC4E3B1F;
        }
    }

    class CIT(ulong val) : CIS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36C117242D1ACB7;
        }
    }

    class CIU(ulong val) : CIT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x965F50F0ED055E7;
        }
    }

    class CIV(ulong val) : CIU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x634608245A992F3;
        }
    }

    class CIW(ulong val) : CIV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x572D638ADE0363B;
        }
    }

    class CIX(ulong val) : CIW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7B2AADEE2F4BAE1;
        }
    }

    class CIY(ulong val) : CIX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35C2AD4B2AFB50D;
        }
    }

    class CIZ(ulong val) : CIY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x599EC70D356A78B;
        }
    }

    class CJA(ulong val) : CIZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x33D59843FFAE602;
        }
    }

    class CJB(ulong val) : CJA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x741B5AAB718DF48;
        }
    }

    class CJC(ulong val) : CJB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x178D67D7F1CF743;
        }
    }

    class CJD(ulong val) : CJC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x782E08C6CF3913B;
        }
    }

    class CJE(ulong val) : CJD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6213FF156B904B3;
        }
    }

    class CJF(ulong val) : CJE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x305678BB4D03E9C;
        }
    }

    class CJG(ulong val) : CJF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53ACF4F79FF49E6;
        }
    }

    class CJH(ulong val) : CJG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43D18BDAE0A9E52;
        }
    }

    class CJI(ulong val) : CJH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3CB833BA5AC56E5;
        }
    }

    class CJJ(ulong val) : CJI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70C23B8154B9DE4;
        }
    }

    class CJK(ulong val) : CJJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CEE8F720C232E0;
        }
    }

    class CJL(ulong val) : CJK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56C76C77B2D9A10;
        }
    }

    class CJM(ulong val) : CJL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x707F3711597CDC4;
        }
    }

    class CJN(ulong val) : CJM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6AB57C9D78FA507;
        }
    }

    class CJO(ulong val) : CJN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1357CBA8764CDE2;
        }
    }

    class CJP(ulong val) : CJO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60EBE7EAE8B62C4;
        }
    }

    class CJQ(ulong val) : CJP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B557537CE46C6D;
        }
    }

    class CJR(ulong val) : CJQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x548C0FE4431B3B0;
        }
    }

    class CJS(ulong val) : CJR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x425AD72BE67A7DA;
        }
    }

    class CJT(ulong val) : CJS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x64DE68194A8B800;
        }
    }

    class CJU(ulong val) : CJT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7EAA5B997C7054B;
        }
    }

    class CJV(ulong val) : CJU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5DFEA74EA8C0CD8;
        }
    }

    class CJW(ulong val) : CJV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C4B9BE9542582E;
        }
    }

    class CJX(ulong val) : CJW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x273B846F828D266;
        }
    }

    class CJY(ulong val) : CJX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x53E4D8154EFBA73;
        }
    }

    class CJZ(ulong val) : CJY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42FF468C14DB754;
        }
    }

    class CKA(ulong val) : CJZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x458ADC89FD3279D;
        }
    }

    class CKB(ulong val) : CKA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x14D0776804F23FB;
        }
    }

    class CKC(ulong val) : CKB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x325559CB6494562;
        }
    }

    class CKD(ulong val) : CKC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1B2E0419E7BFFD9;
        }
    }

    class CKE(ulong val) : CKD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92810A159A6A5BC;
        }
    }

    class CKF(ulong val) : CKE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x22920903570A9C1;
        }
    }

    class CKG(ulong val) : CKF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29563DD8EE2342E;
        }
    }

    class CKH(ulong val) : CKG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x768482AF350EC6A;
        }
    }

    class CKI(ulong val) : CKH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A3541555834B4D;
        }
    }

    class CKJ(ulong val) : CKI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1839025E692733B;
        }
    }

    class CKK(ulong val) : CKJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A4C3AD4B63A2E7;
        }
    }

    class CKL(ulong val) : CKK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x18D0D328B47CBC0;
        }
    }

    class CKM(ulong val) : CKL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49718418DD9F5D4;
        }
    }

    class CKN(ulong val) : CKM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x58C163033E30222;
        }
    }

    class CKO(ulong val) : CKN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1006F95F8F3E80D;
        }
    }

    class CKP(ulong val) : CKO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B94EF1BBB72B18;
        }
    }

    class CKQ(ulong val) : CKP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6FAFF526F596E16;
        }
    }

    class CKR(ulong val) : CKQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5293AEDF65F9A55;
        }
    }

    class CKS(ulong val) : CKR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6DBAB66714B37F1;
        }
    }

    class CKT(ulong val) : CKS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x84F02CD185020A6;
        }
    }

    class CKU(ulong val) : CKT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12863B117616E05;
        }
    }

    class CKV(ulong val) : CKU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1B36F3C1CFE6C04;
        }
    }

    class CKW(ulong val) : CKV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12045B04CAD4C46;
        }
    }

    class CKX(ulong val) : CKW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6A65707B159F752;
        }
    }

    class CKY(ulong val) : CKX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F8621417B6272C;
        }
    }

    class CKZ(ulong val) : CKY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78C8719F14191AC;
        }
    }

    class CLA(ulong val) : CKZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x301758694849C74;
        }
    }

    class CLB(ulong val) : CLA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79BBEFBD6D45151;
        }
    }

    class CLC(ulong val) : CLB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3DAFCDFC9C2FADB;
        }
    }

    class CLD(ulong val) : CLC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x130DD0C6F86D694;
        }
    }

    class CLE(ulong val) : CLD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2355BE3FF6BD534;
        }
    }

    class CLF(ulong val) : CLE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B13FD47D95BAF7;
        }
    }

    class CLG(ulong val) : CLF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8FCCA68F013EE75;
        }
    }

    class CLH(ulong val) : CLG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6C32FF09DBB98F2;
        }
    }

    class CLI(ulong val) : CLH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x754EE0A2F73E43B;
        }
    }

    class CLJ(ulong val) : CLI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6AE20877280CAF0;
        }
    }

    class CLK(ulong val) : CLJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48B79FF4ACBDA89;
        }
    }

    class CLL(ulong val) : CLK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9660654FFBD6AFA;
        }
    }

    class CLM(ulong val) : CLL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x468DAA8958ECDE0;
        }
    }

    class CLN(ulong val) : CLM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4761B65DF8DA58F;
        }
    }

    class CLO(ulong val) : CLN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A67DA4E7518B42;
        }
    }

    class CLP(ulong val) : CLO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x998CC6833E5B8A7;
        }
    }

    class CLQ(ulong val) : CLP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20E98D42C53D0FF;
        }
    }

    class CLR(ulong val) : CLQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x77522C3D810E721;
        }
    }

    class CLS(ulong val) : CLR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60FD828A5C2642E;
        }
    }

    class CLT(ulong val) : CLS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x44FBEAA7B25086A;
        }
    }

    class CLU(ulong val) : CLT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7AEE33BFE71C0D2;
        }
    }

    class CLV(ulong val) : CLU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D1BA5E56937FEA;
        }
    }

    class CLW(ulong val) : CLV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x35B3E49C48831B9;
        }
    }

    class CLX(ulong val) : CLW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4700F76126E067E;
        }
    }

    class CLY(ulong val) : CLX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x245B045803FE2C6;
        }
    }

    class CLZ(ulong val) : CLY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9395D8985134F8E;
        }
    }

    class CMA(ulong val) : CLZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x231C70D00CD4DDA;
        }
    }

    class CMB(ulong val) : CMA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x459A24982F40520;
        }
    }

    class CMC(ulong val) : CMB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6DA4286E8B6650B;
        }
    }

    class CMD(ulong val) : CMC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x892613CF59774E4;
        }
    }

    class CME(ulong val) : CMD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x51C777106B08B58;
        }
    }

    class CMF(ulong val) : CME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CE782CB46405F4;
        }
    }

    class CMG(ulong val) : CMF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A373203778C584;
        }
    }

    class CMH(ulong val) : CMG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C4B8E55716FFDC;
        }
    }

    class CMI(ulong val) : CMH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x71EB04B94CE76AA;
        }
    }

    class CMJ(ulong val) : CMI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x261D8DA33BEEBAA;
        }
    }

    class CMK(ulong val) : CMJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C6C9E897B8B8C0;
        }
    }

    class CML(ulong val) : CMK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x43728ADBC6F5E0D;
        }
    }

    class CMM(ulong val) : CML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A05E7270257785;
        }
    }

    class CMN(ulong val) : CMM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A4FD2B6DC08407;
        }
    }

    class CMO(ulong val) : CMN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x767F0203CE31BA7;
        }
    }

    class CMP(ulong val) : CMO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6CBB0AD97F19E29;
        }
    }

    class CMQ(ulong val) : CMP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4F7D3524D1D5E8C;
        }
    }

    class CMR(ulong val) : CMQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85220E76AD413E6;
        }
    }

    class CMS(ulong val) : CMR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21A91726CF6158A;
        }
    }

    class CMT(ulong val) : CMS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FEF35155BC51D6;
        }
    }

    class CMU(ulong val) : CMT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52593348201CDFD;
        }
    }

    class CMV(ulong val) : CMU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70EAA53364DBE55;
        }
    }

    class CMW(ulong val) : CMV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E885F52BCE9C80;
        }
    }

    class CMX(ulong val) : CMW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C1B5C656F815DA;
        }
    }

    class CMY(ulong val) : CMX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C5E6766CBE310D;
        }
    }

    class CMZ(ulong val) : CMY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3547149F90B3ADA;
        }
    }

    class CNA(ulong val) : CMZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8E5175BFD8944ED;
        }
    }

    class CNB(ulong val) : CNA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x52D4DD92E2A45D3;
        }
    }

    class CNC(ulong val) : CNB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9755C6B6CBF6E1D;
        }
    }

    class CND(ulong val) : CNC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8AF18EC7C19171F;
        }
    }

    class CNE(ulong val) : CND(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15D061F03AE084F;
        }
    }

    class CNF(ulong val) : CNE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x71D16EA7D6B3620;
        }
    }

    class CNG(ulong val) : CNF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x51721F9381552C3;
        }
    }

    class CNH(ulong val) : CNG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CF8118519C845F;
        }
    }

    class CNI(ulong val) : CNH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x238A16BF3138101;
        }
    }

    class CNJ(ulong val) : CNI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4201E35B3A299EB;
        }
    }

    class CNK(ulong val) : CNJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2DDCC14930EA65A;
        }
    }

    class CNL(ulong val) : CNK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E201EBDE18CB8F;
        }
    }

    class CNM(ulong val) : CNL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x968C1CB1F3DE160;
        }
    }

    class CNN(ulong val) : CNM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AB015017A68E7E;
        }
    }

    class CNO(ulong val) : CNN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3EDB8B2FA32E8FE;
        }
    }

    class CNP(ulong val) : CNO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x670C0DC744485D5;
        }
    }

    class CNQ(ulong val) : CNP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4109887802AF8F0;
        }
    }

    class CNR(ulong val) : CNQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96267EDB0977CB4;
        }
    }

    class CNS(ulong val) : CNR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x494414DDCF15BFD;
        }
    }

    class CNT(ulong val) : CNS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x463BE8691455829;
        }
    }

    class CNU(ulong val) : CNT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7BD4D068039E4AD;
        }
    }

    class CNV(ulong val) : CNU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x343639FB3F2BAA9;
        }
    }

    class CNW(ulong val) : CNV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16025C640D05EB0;
        }
    }

    class CNX(ulong val) : CNW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92C44BFC5BBF8A8;
        }
    }

    class CNY(ulong val) : CNX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x81203B213624A60;
        }
    }

    class CNZ(ulong val) : CNY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3A65D42FD3BB2DF;
        }
    }

    class COA(ulong val) : CNZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x14D061A56636562;
        }
    }

    class COB(ulong val) : COA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x277BC536F98DC1E;
        }
    }

    class COC(ulong val) : COB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95DE203587AAF0E;
        }
    }

    class COD(ulong val) : COC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x33860FF33626D23;
        }
    }

    class COE(ulong val) : COD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4B1E3D926649698;
        }
    }

    class COF(ulong val) : COE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1CABC6653A52996;
        }
    }

    class COG(ulong val) : COF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C72EF3CEDCCEA3;
        }
    }

    class COH(ulong val) : COG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x529B5A26B0304E4;
        }
    }

    class COI(ulong val) : COH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x347843073A3A7EF;
        }
    }

    class COJ(ulong val) : COI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x776FEF4EF072AD3;
        }
    }

    class COK(ulong val) : COJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DBCBED83F58436;
        }
    }

    class COL(ulong val) : COK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x551AA6BB35D72D6;
        }
    }

    class COM(ulong val) : COL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F3B4662BAF4365;
        }
    }

    class CON(ulong val) : COM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x755DC54F71A359D;
        }
    }

    class COO(ulong val) : CON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E67D6BE240F219;
        }
    }

    class COP(ulong val) : COO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4797E05840D3CC6;
        }
    }

    class COQ(ulong val) : COP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7381FDC254AB6A1;
        }
    }

    class COR(ulong val) : COQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5995523E72CC9FA;
        }
    }

    class COS(ulong val) : COR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15BCC0BF2F1B21F;
        }
    }

    class COT(ulong val) : COS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x416ED545C913963;
        }
    }

    class COU(ulong val) : COT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6D63431578B8A9C;
        }
    }

    class COV(ulong val) : COU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5956F4317E06070;
        }
    }

    class COW(ulong val) : COV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22F03B08CF154FB;
        }
    }

    class COX(ulong val) : COW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20C65CE89740FE5;
        }
    }

    class COY(ulong val) : COX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x35294BC2FE9B97A;
        }
    }

    class COZ(ulong val) : COY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C2BDB624EF0074;
        }
    }

    class CPA(ulong val) : COZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36062CA41E3E346;
        }
    }

    class CPB(ulong val) : CPA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x431ACAFCBC398FE;
        }
    }

    class CPC(ulong val) : CPB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3CFB6EA0ECF73BE;
        }
    }

    class CPD(ulong val) : CPC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C23B4A14CA6ADE;
        }
    }

    class CPE(ulong val) : CPD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C845CF981E86EE;
        }
    }

    class CPF(ulong val) : CPE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F10107232CEE99;
        }
    }

    class CPG(ulong val) : CPF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78CA0CC564F0A14;
        }
    }

    class CPH(ulong val) : CPG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55AB3A2C3ED2D0E;
        }
    }

    class CPI(ulong val) : CPH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x78C690BC71474C7;
        }
    }

    class CPJ(ulong val) : CPI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39B8E778951643D;
        }
    }

    class CPK(ulong val) : CPJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x757C9B56221F566;
        }
    }

    class CPL(ulong val) : CPK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1B08D96D080A33C;
        }
    }

    class CPM(ulong val) : CPL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86372B1C2547722;
        }
    }

    class CPN(ulong val) : CPM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1869B4413BF75FD;
        }
    }

    class CPO(ulong val) : CPN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50EEAE9E543BCE3;
        }
    }

    class CPP(ulong val) : CPO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9318998BCDA03AC;
        }
    }

    class CPQ(ulong val) : CPP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x341F7E8CCD79A3C;
        }
    }

    class CPR(ulong val) : CPQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x990BEE9BFB9CE0C;
        }
    }

    class CPS(ulong val) : CPR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x21180ADC8B43B54;
        }
    }

    class CPT(ulong val) : CPS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E5DFD03A6A0CDD;
        }
    }

    class CPU(ulong val) : CPT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3DB83C34A70CDDD;
        }
    }

    class CPV(ulong val) : CPU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x68004D6C8D54B03;
        }
    }

    class CPW(ulong val) : CPV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1AEC345D2962396;
        }
    }

    class CPX(ulong val) : CPW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4AE8B5F5BDC47F5;
        }
    }

    class CPY(ulong val) : CPX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A62212B76B5EE7;
        }
    }

    class CPZ(ulong val) : CPY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2408B770A4A5889;
        }
    }

    class CQA(ulong val) : CPZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2149C9A91068477;
        }
    }

    class CQB(ulong val) : CQA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12939494973F079;
        }
    }

    class CQC(ulong val) : CQB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x43ED2D8C9DF7B7B;
        }
    }

    class CQD(ulong val) : CQC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A8C3F93FA222C0;
        }
    }

    class CQE(ulong val) : CQD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6992CC0F0898E2B;
        }
    }

    class CQF(ulong val) : CQE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B5163C9DA6512C;
        }
    }

    class CQG(ulong val) : CQF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AAE5F65C26BB27;
        }
    }

    class CQH(ulong val) : CQG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2BEFBD7B011D3DF;
        }
    }

    class CQI(ulong val) : CQH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E5C27D1FACCD8E;
        }
    }

    class CQJ(ulong val) : CQI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6094964F9B33E5F;
        }
    }

    class CQK(ulong val) : CQJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6586BD12F76C3E4;
        }
    }

    class CQL(ulong val) : CQK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53319BC9C6321F4;
        }
    }

    class CQM(ulong val) : CQL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x508522D6F7D8495;
        }
    }

    class CQN(ulong val) : CQM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96F1F81E519A40E;
        }
    }

    class CQO(ulong val) : CQN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x42CEEBC472A9BE4;
        }
    }

    class CQP(ulong val) : CQO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x961F2F0A9A82562;
        }
    }

    class CQQ(ulong val) : CQP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5BAE713B0DEE45D;
        }
    }

    class CQR(ulong val) : CQQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x74D24EA172E6301;
        }
    }

    class CQS(ulong val) : CQR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31315573984419F;
        }
    }

    class CQT(ulong val) : CQS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8294A8BE7BAC777;
        }
    }

    class CQU(ulong val) : CQT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50E87EFE99A7429;
        }
    }

    class CQV(ulong val) : CQU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x62C323F739CA521;
        }
    }

    class CQW(ulong val) : CQV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x53EFE6D9829AABD;
        }
    }

    class CQX(ulong val) : CQW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A620DC291523ED;
        }
    }

    class CQY(ulong val) : CQX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x811DCB1D313455A;
        }
    }

    class CQZ(ulong val) : CQY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x14B4E9EBBD52A94;
        }
    }

    class CRA(ulong val) : CQZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x883221E41F1D553;
        }
    }

    class CRB(ulong val) : CRA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3BF66DD0DF282D0;
        }
    }

    class CRC(ulong val) : CRB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C3D4EF38F15E2D;
        }
    }

    class CRD(ulong val) : CRC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23EB01EEA35BEBD;
        }
    }

    class CRE(ulong val) : CRD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x504BFD8C57CBCC4;
        }
    }

    class CRF(ulong val) : CRE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6DE235FBF59A6A2;
        }
    }

    class CRG(ulong val) : CRF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x487F4EB9A24E518;
        }
    }

    class CRH(ulong val) : CRG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F5EDCD85B478DC;
        }
    }

    class CRI(ulong val) : CRH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x705F6040D5F17CE;
        }
    }

    class CRJ(ulong val) : CRI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x228D5F91D13DC12;
        }
    }

    class CRK(ulong val) : CRJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2533626A72C36E6;
        }
    }

    class CRL(ulong val) : CRK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x859929DBB5792FE;
        }
    }

    class CRM(ulong val) : CRL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F2AE096767D4AB;
        }
    }

    class CRN(ulong val) : CRM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x570A58FA620EDBA;
        }
    }

    class CRO(ulong val) : CRN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8C0A749EC45F2EC;
        }
    }

    class CRP(ulong val) : CRO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C30824FFFAA8C7;
        }
    }

    class CRQ(ulong val) : CRP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x39981109FC9AE6D;
        }
    }

    class CRR(ulong val) : CRQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C8B878449059B1;
        }
    }

    class CRS(ulong val) : CRR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96CB74A90E7EA29;
        }
    }

    class CRT(ulong val) : CRS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F0219E9EAF54A4;
        }
    }

    class CRU(ulong val) : CRT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x727997E425FDA24;
        }
    }

    class CRV(ulong val) : CRU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x376DA698553E3AA;
        }
    }

    class CRW(ulong val) : CRV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5DD9F462C3C5538;
        }
    }

    class CRX(ulong val) : CRW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x797E1C4C714390F;
        }
    }

    class CRY(ulong val) : CRX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A0C8A068E7DA11;
        }
    }

    class CRZ(ulong val) : CRY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72F50F6978E5AF6;
        }
    }

    class CSA(ulong val) : CRZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3CF0615AA86F122;
        }
    }

    class CSB(ulong val) : CSA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x398AE2B9C2C0CF2;
        }
    }

    class CSC(ulong val) : CSB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3921123D8FF9802;
        }
    }

    class CSD(ulong val) : CSC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E53D0E49604572;
        }
    }

    class CSE(ulong val) : CSD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x83FA32F70322F95;
        }
    }

    class CSF(ulong val) : CSE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x169D8FD4CCFCC9A;
        }
    }

    class CSG(ulong val) : CSF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A4ABB2BC01214E;
        }
    }

    class CSH(ulong val) : CSG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49096E34CB9B6B3;
        }
    }

    class CSI(ulong val) : CSH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D3E4C3399851CC;
        }
    }

    class CSJ(ulong val) : CSI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x41F5EE58096C610;
        }
    }

    class CSK(ulong val) : CSJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x368C330A3CC1B2B;
        }
    }

    class CSL(ulong val) : CSK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F5277C77779469;
        }
    }

    class CSM(ulong val) : CSL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x198A9578F9AFDE8;
        }
    }

    class CSN(ulong val) : CSM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x333DEC80D059AC2;
        }
    }

    class CSO(ulong val) : CSN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4FBC82F09B52E31;
        }
    }

    class CSP(ulong val) : CSO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1DE26419C6419D9;
        }
    }

    class CSQ(ulong val) : CSP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3FB8B3B319F366C;
        }
    }

    class CSR(ulong val) : CSQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8352312D727D123;
        }
    }

    class CSS(ulong val) : CSR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x980F97CB9B4EA08;
        }
    }

    class CST(ulong val) : CSS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FCCCF9A4DF7EA2;
        }
    }

    class CSU(ulong val) : CST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x784C8E503DF1CAA;
        }
    }

    class CSV(ulong val) : CSU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43F299E235F712A;
        }
    }

    class CSW(ulong val) : CSV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x825F746A10E870F;
        }
    }

    class CSX(ulong val) : CSW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CA981A059A7606;
        }
    }

    class CSY(ulong val) : CSX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2FEE03918AF22AD;
        }
    }

    class CSZ(ulong val) : CSY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6472A3569741191;
        }
    }

    class CTA(ulong val) : CSZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x10DE43ABF3CAE85;
        }
    }

    class CTB(ulong val) : CTA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F3106F883CC860;
        }
    }

    class CTC(ulong val) : CTB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36F4C863EDD0EE4;
        }
    }

    class CTD(ulong val) : CTC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5595CC32931CFCA;
        }
    }

    class CTE(ulong val) : CTD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5E82F3D1F448C71;
        }
    }

    class CTF(ulong val) : CTE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78A2A51FBC4907C;
        }
    }

    class CTG(ulong val) : CTF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x582CA3E469A77DA;
        }
    }

    class CTH(ulong val) : CTG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DB35D0610C3712;
        }
    }

    class CTI(ulong val) : CTH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C974349866F43F;
        }
    }

    class CTJ(ulong val) : CTI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1F78EF09A951529;
        }
    }

    class CTK(ulong val) : CTJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5380A6E2AE860A8;
        }
    }

    class CTL(ulong val) : CTK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FDDC06E0407760;
        }
    }

    class CTM(ulong val) : CTL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x928C40C56C603AE;
        }
    }

    class CTN(ulong val) : CTM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x976AE158C3C679F;
        }
    }

    class CTO(ulong val) : CTN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8F94BC5118503D8;
        }
    }

    class CTP(ulong val) : CTO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E88A2C4C2114B7;
        }
    }

    class CTQ(ulong val) : CTP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x375F976813418E6;
        }
    }

    class CTR(ulong val) : CTQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C0D7292F8718D8;
        }
    }

    class CTS(ulong val) : CTR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34DE2D6297743BE;
        }
    }

    class CTT(ulong val) : CTS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56B5EC4D57755B2;
        }
    }

    class CTU(ulong val) : CTT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AD533D988A804F;
        }
    }

    class CTV(ulong val) : CTU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x251B0DBFE203E4A;
        }
    }

    class CTW(ulong val) : CTV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F16D38AE2A049D;
        }
    }

    class CTX(ulong val) : CTW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4FF76781D411BE9;
        }
    }

    class CTY(ulong val) : CTX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x55DD8525EA6F7F1;
        }
    }

    class CTZ(ulong val) : CTY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BB02E817D48F3C;
        }
    }

    class CUA(ulong val) : CTZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1698D36D34E77FD;
        }
    }

    class CUB(ulong val) : CUA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7074E1E206CBCD5;
        }
    }

    class CUC(ulong val) : CUB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4175683BB83DCB7;
        }
    }

    class CUD(ulong val) : CUC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x196E351BAD07984;
        }
    }

    class CUE(ulong val) : CUD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60C26F894518C75;
        }
    }

    class CUF(ulong val) : CUE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x28C7C78CB7339AA;
        }
    }

    class CUG(ulong val) : CUF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80C7C762A54798D;
        }
    }

    class CUH(ulong val) : CUG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x438E76026FB1F49;
        }
    }

    class CUI(ulong val) : CUH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x81D562DBC9E1562;
        }
    }

    class CUJ(ulong val) : CUI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x748A75F8E0137CC;
        }
    }

    class CUK(ulong val) : CUJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8555D33F3127EC6;
        }
    }

    class CUL(ulong val) : CUK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8606C443C54361A;
        }
    }

    class CUM(ulong val) : CUL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x642B4733EE9239A;
        }
    }

    class CUN(ulong val) : CUM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3EE9802E04D19D2;
        }
    }

    class CUO(ulong val) : CUN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4FB9D5AF55D248D;
        }
    }

    class CUP(ulong val) : CUO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85D2C444BD841CF;
        }
    }

    class CUQ(ulong val) : CUP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A69DF3DFE7E35C;
        }
    }

    class CUR(ulong val) : CUQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8FA5207C7CBE21B;
        }
    }

    class CUS(ulong val) : CUR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4099B147D7FC617;
        }
    }

    class CUT(ulong val) : CUS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B536D5D52E433C;
        }
    }

    class CUU(ulong val) : CUT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6062A16E7699F44;
        }
    }

    class CUV(ulong val) : CUU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22A173B9AF9AE01;
        }
    }

    class CUW(ulong val) : CUV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A1FD63B723BBFC;
        }
    }

    class CUX(ulong val) : CUW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x15E3C1C34276520;
        }
    }

    class CUY(ulong val) : CUX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23A014DB4BAB2C7;
        }
    }

    class CUZ(ulong val) : CUY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6BC36C14146926A;
        }
    }

    class CVA(ulong val) : CUZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28609A10B6F4799;
        }
    }

    class CVB(ulong val) : CVA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17EC675F64993B4;
        }
    }

    class CVC(ulong val) : CVB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x49580F490237DC1;
        }
    }

    class CVD(ulong val) : CVC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57090368DBDE7FF;
        }
    }

    class CVE(ulong val) : CVD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5BB1BA197837434;
        }
    }

    class CVF(ulong val) : CVE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8043EFDC4546872;
        }
    }

    class CVG(ulong val) : CVF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x107DF0B6C1BE8C2;
        }
    }

    class CVH(ulong val) : CVG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5CF80C2D843F389;
        }
    }

    class CVI(ulong val) : CVH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3E8093CBB029689;
        }
    }

    class CVJ(ulong val) : CVI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x196767EFF7A3E23;
        }
    }

    class CVK(ulong val) : CVJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48775B87A4AC734;
        }
    }

    class CVL(ulong val) : CVK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A8C6CFB43DC27D;
        }
    }

    class CVM(ulong val) : CVL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7DD6F9BA1215ED6;
        }
    }

    class CVN(ulong val) : CVM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49CACEC89D04328;
        }
    }

    class CVO(ulong val) : CVN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x13824763472061C;
        }
    }

    class CVP(ulong val) : CVO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2916CFB3496868D;
        }
    }

    class CVQ(ulong val) : CVP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A91B25EA0ED421;
        }
    }

    class CVR(ulong val) : CVQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x33E2300AC674825;
        }
    }

    class CVS(ulong val) : CVR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7FFA78F26DBB6D3;
        }
    }

    class CVT(ulong val) : CVS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D495B3EBEA3A31;
        }
    }

    class CVU(ulong val) : CVT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x533077BA2C421A3;
        }
    }

    class CVV(ulong val) : CVU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C3969A4DF43DF1;
        }
    }

    class CVW(ulong val) : CVV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x370646455E1CF99;
        }
    }

    class CVX(ulong val) : CVW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61679A2021D3B4F;
        }
    }

    class CVY(ulong val) : CVX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C3DE47B8C39821;
        }
    }

    class CVZ(ulong val) : CVY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98FB6C0278DB8DA;
        }
    }

    class CWA(ulong val) : CVZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7389DFAACCCF4E5;
        }
    }

    class CWB(ulong val) : CWA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A23AC8D993FE60;
        }
    }

    class CWC(ulong val) : CWB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31A967A03B84515;
        }
    }

    class CWD(ulong val) : CWC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x496688811B0AE23;
        }
    }

    class CWE(ulong val) : CWD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D5E9281AB63346;
        }
    }

    class CWF(ulong val) : CWE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x307286EC0705C16;
        }
    }

    class CWG(ulong val) : CWF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E85CBC3FA6852F;
        }
    }

    class CWH(ulong val) : CWG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61E10F4A62504CE;
        }
    }

    class CWI(ulong val) : CWH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15DD593204EC732;
        }
    }

    class CWJ(ulong val) : CWI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C5A87012F80A3D;
        }
    }

    class CWK(ulong val) : CWJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x147AEE2E4A5E4CF;
        }
    }

    class CWL(ulong val) : CWK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4C9FD0A1FEAC8A3;
        }
    }

    class CWM(ulong val) : CWL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8A5788C708FEC9B;
        }
    }

    class CWN(ulong val) : CWM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24D60A378021A78;
        }
    }

    class CWO(ulong val) : CWN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39358E530890A08;
        }
    }

    class CWP(ulong val) : CWO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x581825C10922B93;
        }
    }

    class CWQ(ulong val) : CWP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x80195CBF4A454BC;
        }
    }

    class CWR(ulong val) : CWQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4CE1C0277CA35DA;
        }
    }

    class CWS(ulong val) : CWR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7110A175F659591;
        }
    }

    class CWT(ulong val) : CWS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x906850EED6CF804;
        }
    }

    class CWU(ulong val) : CWT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9273BCC51331A65;
        }
    }

    class CWV(ulong val) : CWU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7C05E20CC70E334;
        }
    }

    class CWW(ulong val) : CWV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x486C4F464B90036;
        }
    }

    class CWX(ulong val) : CWW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6973485527A68B5;
        }
    }

    class CWY(ulong val) : CWX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x677465D6513E428;
        }
    }

    class CWZ(ulong val) : CWY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x292E2EBD1B5CAFC;
        }
    }

    class CXA(ulong val) : CWZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1FFB4FF6B167D67;
        }
    }

    class CXB(ulong val) : CXA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C6D2B82573F6D1;
        }
    }

    class CXC(ulong val) : CXB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x716EBDF232B0B27;
        }
    }

    class CXD(ulong val) : CXC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98F4977FD8D5681;
        }
    }

    class CXE(ulong val) : CXD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55AAE076CD640BB;
        }
    }

    class CXF(ulong val) : CXE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x403B612F4E5CE51;
        }
    }

    class CXG(ulong val) : CXF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7480C5C326E2BB1;
        }
    }

    class CXH(ulong val) : CXG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5D87D9F79DF0AC7;
        }
    }

    class CXI(ulong val) : CXH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B8AD419FD13C1C;
        }
    }

    class CXJ(ulong val) : CXI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16A788BB73A41A6;
        }
    }

    class CXK(ulong val) : CXJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1610F47C8F6B6EE;
        }
    }

    class CXL(ulong val) : CXK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89A26E97E4F4AB5;
        }
    }

    class CXM(ulong val) : CXL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5AAF48A8F2EAE83;
        }
    }

    class CXN(ulong val) : CXM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6445D25B2183CEB;
        }
    }

    class CXO(ulong val) : CXN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x42FEF4459BC49C8;
        }
    }

    class CXP(ulong val) : CXO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x92931810A9A260E;
        }
    }

    class CXQ(ulong val) : CXP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61CD541DD4AD0F3;
        }
    }

    class CXR(ulong val) : CXQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5033EFAFB4A5612;
        }
    }

    class CXS(ulong val) : CXR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1757F2288D68E2B;
        }
    }

    class CXT(ulong val) : CXS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x270A61263492C95;
        }
    }

    class CXU(ulong val) : CXT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91E6D639EE84A28;
        }
    }

    class CXV(ulong val) : CXU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x13776449FF8CC0C;
        }
    }

    class CXW(ulong val) : CXV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x585736DEDFB260A;
        }
    }

    class CXX(ulong val) : CXW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27138781DF3B21D;
        }
    }

    class CXY(ulong val) : CXX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x40F00AE5DB3B71D;
        }
    }

    class CXZ(ulong val) : CXY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x811800898EE4718;
        }
    }

    class CYA(ulong val) : CXZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F28EF2EC102677;
        }
    }

    class CYB(ulong val) : CYA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54D8E7D43DDF9B6;
        }
    }

    class CYC(ulong val) : CYB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x419C34EEE61A974;
        }
    }

    class CYD(ulong val) : CYC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B87CBE899389E3;
        }
    }

    class CYE(ulong val) : CYD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1A511620A48F4D3;
        }
    }

    class CYF(ulong val) : CYE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A46CD49AAFA01C;
        }
    }

    class CYG(ulong val) : CYF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7388ED539EE86C9;
        }
    }

    class CYH(ulong val) : CYG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56DA44D69767111;
        }
    }

    class CYI(ulong val) : CYH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1BDCED61070D8DF;
        }
    }

    class CYJ(ulong val) : CYI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2ACC9796FBFFA53;
        }
    }

    class CYK(ulong val) : CYJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1EFF7431523A210;
        }
    }

    class CYL(ulong val) : CYK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x98E52A74C46C6AA;
        }
    }

    class CYM(ulong val) : CYL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F88828FC2DE30E;
        }
    }

    class CYN(ulong val) : CYM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x92576E611D86549;
        }
    }

    class CYO(ulong val) : CYN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x529F536C5D6D46D;
        }
    }

    class CYP(ulong val) : CYO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96AC111D7E73539;
        }
    }

    class CYQ(ulong val) : CYP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80D291C0DCD6318;
        }
    }

    class CYR(ulong val) : CYQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2851581865E2B5C;
        }
    }

    class CYS(ulong val) : CYR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3161FE6C1B7B647;
        }
    }

    class CYT(ulong val) : CYS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x92F2FAEB55682C3;
        }
    }

    class CYU(ulong val) : CYT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5FA04175B4E349C;
        }
    }

    class CYV(ulong val) : CYU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x913A731D65A032E;
        }
    }

    class CYW(ulong val) : CYV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x866EA06EE150188;
        }
    }

    class CYX(ulong val) : CYW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x42326A9108F8844;
        }
    }

    class CYY(ulong val) : CYX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A992885BC9E21A;
        }
    }

    class CYZ(ulong val) : CYY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20ADD9189456C59;
        }
    }

    class CZA(ulong val) : CYZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1077B8B443C7614;
        }
    }

    class CZB(ulong val) : CZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2838470748021A2;
        }
    }

    class CZC(ulong val) : CZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D013662AEEE782;
        }
    }

    class CZD(ulong val) : CZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x528759A18AEFA28;
        }
    }

    class CZE(ulong val) : CZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x443544F88193DE0;
        }
    }

    class CZF(ulong val) : CZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x83003C1E6DDBFC5;
        }
    }

    class CZG(ulong val) : CZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1945EF981EE4A40;
        }
    }

    class CZH(ulong val) : CZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CEF78BD880E3D1;
        }
    }

    class CZI(ulong val) : CZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3348B236B3773D1;
        }
    }

    class CZJ(ulong val) : CZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A9B74DCBF9B708;
        }
    }

    class CZK(ulong val) : CZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6960CFBEE3D2627;
        }
    }

    class CZL(ulong val) : CZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BDED22389384DB;
        }
    }

    class CZM(ulong val) : CZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82B9ED64DA86C81;
        }
    }

    class CZN(ulong val) : CZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5095AADEDD3BCDC;
        }
    }

    class CZO(ulong val) : CZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1DBB8C7B2DC0A00;
        }
    }

    class CZP(ulong val) : CZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x28329254A83FE34;
        }
    }

    class CZQ(ulong val) : CZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x37C34CD28C577BD;
        }
    }

    class CZR(ulong val) : CZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2DC012908153C8C;
        }
    }

    class CZS(ulong val) : CZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B0BD592AC74D9B;
        }
    }

    class CZT(ulong val) : CZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A62B302299BBAE;
        }
    }

    class CZU(ulong val) : CZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x71B20C6C4571C2F;
        }
    }

    class CZV(ulong val) : CZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31157008F1ED0D3;
        }
    }

    class CZW(ulong val) : CZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F05D6B6C70F84F;
        }
    }

    class CZX(ulong val) : CZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x31D15C131121F63;
        }
    }

    class CZY(ulong val) : CZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6117832BA0B5517;
        }
    }

    class CZZ(ulong val) : CZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x371ADE5C3B67553;
        }
    }

    class DAA(ulong val) : CZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x837293684594BD4;
        }
    }

    class DAB(ulong val) : DAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D3354C3B486E1D;
        }
    }

    class DAC(ulong val) : DAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5A4B8E2BD3A35DD;
        }
    }

    class DAD(ulong val) : DAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23356A479E9D839;
        }
    }

    class DAE(ulong val) : DAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E3C4F210A3C2A4;
        }
    }

    class DAF(ulong val) : DAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x622F38176AD4AEF;
        }
    }

    class DAG(ulong val) : DAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7934C5F67D5273B;
        }
    }

    class DAH(ulong val) : DAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x549E5E3F0811562;
        }
    }

    class DAI(ulong val) : DAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73E155EF9FD3D68;
        }
    }

    class DAJ(ulong val) : DAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x59AAEB153853A98;
        }
    }

    class DAK(ulong val) : DAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81C4D3223611A61;
        }
    }

    class DAL(ulong val) : DAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AECB84CF9D8888;
        }
    }

    class DAM(ulong val) : DAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x288145896A3B839;
        }
    }

    class DAN(ulong val) : DAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x21FF97DFEB77B81;
        }
    }

    class DAO(ulong val) : DAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D91659DA22831A;
        }
    }

    class DAP(ulong val) : DAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x513A6FB8D5BBAB0;
        }
    }

    class DAQ(ulong val) : DAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E7542B3BF2F6F8;
        }
    }

    class DAR(ulong val) : DAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91D81389247550E;
        }
    }

    class DAS(ulong val) : DAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x194D348DA780941;
        }
    }

    class DAT(ulong val) : DAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3162CE4F5C1FA6D;
        }
    }

    class DAU(ulong val) : DAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42710780124C176;
        }
    }

    class DAV(ulong val) : DAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26CA7AAC5E97682;
        }
    }

    class DAW(ulong val) : DAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4847F2C61AD6CC6;
        }
    }

    class DAX(ulong val) : DAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3656D0810602D0C;
        }
    }

    class DAY(ulong val) : DAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x64E2DEFB3CE25BC;
        }
    }

    class DAZ(ulong val) : DAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5AF9C13F79B2C17;
        }
    }

    class DBA(ulong val) : DAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x125BE567F1B6CC3;
        }
    }

    class DBB(ulong val) : DBA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5BEDAC44C4493D8;
        }
    }

    class DBC(ulong val) : DBB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46B7FA189E63591;
        }
    }

    class DBD(ulong val) : DBC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1871F5EF25DB6A5;
        }
    }

    class DBE(ulong val) : DBD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x68B96E6D3A7608E;
        }
    }

    class DBF(ulong val) : DBE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E2CCEE13620E5C;
        }
    }

    class DBG(ulong val) : DBF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x332C7B25C963A10;
        }
    }

    class DBH(ulong val) : DBG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49D33723861B008;
        }
    }

    class DBI(ulong val) : DBH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x45F47A603C8FF3C;
        }
    }

    class DBJ(ulong val) : DBI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93A599E669C7FA9;
        }
    }

    class DBK(ulong val) : DBJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F646BF891963FE;
        }
    }

    class DBL(ulong val) : DBK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x764D477CA7B2A5D;
        }
    }

    class DBM(ulong val) : DBL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E87B8A4F77DA0A;
        }
    }

    class DBN(ulong val) : DBM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67DE7941B5B195C;
        }
    }

    class DBO(ulong val) : DBN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42663E252AC4815;
        }
    }

    class DBP(ulong val) : DBO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D59BAC0EC10C47;
        }
    }

    class DBQ(ulong val) : DBP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1D8BF36D3A9D45E;
        }
    }

    class DBR(ulong val) : DBQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4FC5B237DEEAF8F;
        }
    }

    class DBS(ulong val) : DBR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x101E1A5AF1929A8;
        }
    }

    class DBT(ulong val) : DBS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4EAC4F2B6B6A3F6;
        }
    }

    class DBU(ulong val) : DBT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2EA3DBFB4BDF774;
        }
    }

    class DBV(ulong val) : DBU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3116D8FD1ECB222;
        }
    }

    class DBW(ulong val) : DBV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8DF9B3B52BF5FCE;
        }
    }

    class DBX(ulong val) : DBW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x739C05CA3D40AFA;
        }
    }

    class DBY(ulong val) : DBX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FA4B2F386532CC;
        }
    }

    class DBZ(ulong val) : DBY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x100A67DD28E1962;
        }
    }

    class DCA(ulong val) : DBZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7CFDAF732EB4411;
        }
    }

    class DCB(ulong val) : DCA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56963A7F05DBE11;
        }
    }

    class DCC(ulong val) : DCB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2912A5D121BF9FA;
        }
    }

    class DCD(ulong val) : DCC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x630AAAA878EDA34;
        }
    }

    class DCE(ulong val) : DCD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B3EA1358C67C20;
        }
    }

    class DCF(ulong val) : DCE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x94ED5E6BECD4D84;
        }
    }

    class DCG(ulong val) : DCF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x303024BDC870605;
        }
    }

    class DCH(ulong val) : DCG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C9A3BCD834E6A9;
        }
    }

    class DCI(ulong val) : DCH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E36FED5F431EF3;
        }
    }

    class DCJ(ulong val) : DCI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D1E0567A11FD17;
        }
    }

    class DCK(ulong val) : DCJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C2E1B2F8AE71BD;
        }
    }

    class DCL(ulong val) : DCK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B4EA0F8EE8D453;
        }
    }

    class DCM(ulong val) : DCL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x646516221DE9FEA;
        }
    }

    class DCN(ulong val) : DCM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x235C740A2D73A98;
        }
    }

    class DCO(ulong val) : DCN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F17EBE7A3AD68C;
        }
    }

    class DCP(ulong val) : DCO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x64CD6054B55F393;
        }
    }

    class DCQ(ulong val) : DCP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x166B8D0C59C60F3;
        }
    }

    class DCR(ulong val) : DCQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5DDC49F4170A1EB;
        }
    }

    class DCS(ulong val) : DCR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7403D911087C2A2;
        }
    }

    class DCT(ulong val) : DCS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x603F965183DA555;
        }
    }

    class DCU(ulong val) : DCT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6558A9B4708DDD7;
        }
    }

    class DCV(ulong val) : DCU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47CE68EB69DD5C6;
        }
    }

    class DCW(ulong val) : DCV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x353F7D89F473BD4;
        }
    }

    class DCX(ulong val) : DCW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3785CE8F237C5D8;
        }
    }

    class DCY(ulong val) : DCX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2662B0FF86B1DBE;
        }
    }

    class DCZ(ulong val) : DCY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C374F7E0A21A10;
        }
    }

    class DDA(ulong val) : DCZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x477EDA6DB5C5A01;
        }
    }

    class DDB(ulong val) : DDA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9915E5ECB80DBA7;
        }
    }

    class DDC(ulong val) : DDB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6524FE861684112;
        }
    }

    class DDD(ulong val) : DDC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CAD905BB637FED;
        }
    }

    class DDE(ulong val) : DDD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x97D105D9D452A33;
        }
    }

    class DDF(ulong val) : DDE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26419DA710DC3BB;
        }
    }

    class DDG(ulong val) : DDF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23F9050A40CDEA3;
        }
    }

    class DDH(ulong val) : DDG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x82306027BD7BEE8;
        }
    }

    class DDI(ulong val) : DDH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3893793DB4AAE92;
        }
    }

    class DDJ(ulong val) : DDI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x39B7A7B08FC43CB;
        }
    }

    class DDK(ulong val) : DDJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B24783BC23D7E5;
        }
    }

    class DDL(ulong val) : DDK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3100D0798204AEE;
        }
    }

    class DDM(ulong val) : DDL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x766C0757970B087;
        }
    }

    class DDN(ulong val) : DDM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7514D47FF42AE91;
        }
    }

    class DDO(ulong val) : DDN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x17B2796914260DE;
        }
    }

    class DDP(ulong val) : DDO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49DCE642351107F;
        }
    }

    class DDQ(ulong val) : DDP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7BF8AAB12A266BB;
        }
    }

    class DDR(ulong val) : DDQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x623B61837BBB471;
        }
    }

    class DDS(ulong val) : DDR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2915A6ACF2367D8;
        }
    }

    class DDT(ulong val) : DDS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x355BC1631820A89;
        }
    }

    class DDU(ulong val) : DDT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x67B38F54ADB7E43;
        }
    }

    class DDV(ulong val) : DDU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53D179DC6850DCA;
        }
    }

    class DDW(ulong val) : DDV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x864029518978529;
        }
    }

    class DDX(ulong val) : DDW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67CFD7B06C02CF6;
        }
    }

    class DDY(ulong val) : DDX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1FC922D1E558F0D;
        }
    }

    class DDZ(ulong val) : DDY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x491EBA55FFFB633;
        }
    }

    class DEA(ulong val) : DDZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x179DBEA9B43E85D;
        }
    }

    class DEB(ulong val) : DEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x21A0C58A1BEBA47;
        }
    }

    class DEC(ulong val) : DEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E39203878A4932;
        }
    }

    class DED(ulong val) : DEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E55E46384EDB47;
        }
    }

    class DEE(ulong val) : DED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1765A5DF4B02A89;
        }
    }

    class DEF(ulong val) : DEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4300102960C5866;
        }
    }

    class DEG(ulong val) : DEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64B52E9AD90F470;
        }
    }

    class DEH(ulong val) : DEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C7D7D4C57F9EF5;
        }
    }

    class DEI(ulong val) : DEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B7706D92F610AB;
        }
    }

    class DEJ(ulong val) : DEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95B838F6C52FC22;
        }
    }

    class DEK(ulong val) : DEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B0148E87257137;
        }
    }

    class DEL(ulong val) : DEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x728B926E345E832;
        }
    }

    class DEM(ulong val) : DEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2083C1AE9448E16;
        }
    }

    class DEN(ulong val) : DEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4B40B83F87F2596;
        }
    }

    class DEO(ulong val) : DEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55013CE88476589;
        }
    }

    class DEP(ulong val) : DEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FB3CB17F253B45;
        }
    }

    class DEQ(ulong val) : DEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x412785EA17B2767;
        }
    }

    class DER(ulong val) : DEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16F84DFC9E3BE53;
        }
    }

    class DES(ulong val) : DER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x280B69354677067;
        }
    }

    class DET(ulong val) : DES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D7BD5EFBF9C571;
        }
    }

    class DEU(ulong val) : DET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58DA196C127F98D;
        }
    }

    class DEV(ulong val) : DEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1345B6DC00968ED;
        }
    }

    class DEW(ulong val) : DEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x46B1A568E5230AC;
        }
    }

    class DEX(ulong val) : DEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x889D4113783EFB8;
        }
    }

    class DEY(ulong val) : DEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x170AA6E19241907;
        }
    }

    class DEZ(ulong val) : DEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B1805AADB49122;
        }
    }

    class DFA(ulong val) : DEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8E787404583DF70;
        }
    }

    class DFB(ulong val) : DFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8897D3A0B187E14;
        }
    }

    class DFC(ulong val) : DFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x788C59776E37301;
        }
    }

    class DFD(ulong val) : DFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FF00AEB72C1BD5;
        }
    }

    class DFE(ulong val) : DFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FC1DC038D152E3;
        }
    }

    class DFF(ulong val) : DFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1099B56250775B9;
        }
    }

    class DFG(ulong val) : DFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6836E342C865606;
        }
    }

    class DFH(ulong val) : DFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x43263D429F95BE7;
        }
    }

    class DFI(ulong val) : DFH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16CFDE627BF1216;
        }
    }

    class DFJ(ulong val) : DFI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F135A6C49C65BB;
        }
    }

    class DFK(ulong val) : DFJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29ECA569290F15C;
        }
    }

    class DFL(ulong val) : DFK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B4101A0831BA8D;
        }
    }

    class DFM(ulong val) : DFL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x244A007C4533A45;
        }
    }

    class DFN(ulong val) : DFM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DD239EB26E9AE8;
        }
    }

    class DFO(ulong val) : DFN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6398C685482D1CD;
        }
    }

    class DFP(ulong val) : DFO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3718BD372A76E48;
        }
    }

    class DFQ(ulong val) : DFP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x14AC3B37057FA05;
        }
    }

    class DFR(ulong val) : DFQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x19C8AF8EF78FB8F;
        }
    }

    class DFS(ulong val) : DFR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2D50C9C141461FB;
        }
    }

    class DFT(ulong val) : DFS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x431D86607F32551;
        }
    }

    class DFU(ulong val) : DFT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42E83A1892B2222;
        }
    }

    class DFV(ulong val) : DFU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AC1D182A0D94FF;
        }
    }

    class DFW(ulong val) : DFV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x489DA598D529F58;
        }
    }

    class DFX(ulong val) : DFW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FC2490830CC2E5;
        }
    }

    class DFY(ulong val) : DFX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6F66502319FF1CC;
        }
    }

    class DFZ(ulong val) : DFY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x170CDD1A61DFE02;
        }
    }

    class DGA(ulong val) : DFZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x109D6F12A4E576E;
        }
    }

    class DGB(ulong val) : DGA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x71D9AC2D73FBFD7;
        }
    }

    class DGC(ulong val) : DGB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80AF9CFDAB9CCC8;
        }
    }

    class DGD(ulong val) : DGC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x181E865AF453689;
        }
    }

    class DGE(ulong val) : DGD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B271FBA265919E;
        }
    }

    class DGF(ulong val) : DGE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91661CD7A8AD95B;
        }
    }

    class DGG(ulong val) : DGF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4E265E4689D170E;
        }
    }

    class DGH(ulong val) : DGG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94DF1892075B273;
        }
    }

    class DGI(ulong val) : DGH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B2440993415838;
        }
    }

    class DGJ(ulong val) : DGI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D43ADCA09E90A5;
        }
    }

    class DGK(ulong val) : DGJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x909363F2201A0B2;
        }
    }

    class DGL(ulong val) : DGK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x77CB50993D626FD;
        }
    }

    class DGM(ulong val) : DGL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B44D8621E419EC;
        }
    }

    class DGN(ulong val) : DGM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87F7E174E2CDFE1;
        }
    }

    class DGO(ulong val) : DGN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8904FFE6B517942;
        }
    }

    class DGP(ulong val) : DGO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19DFF97E2FE7C24;
        }
    }

    class DGQ(ulong val) : DGP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x61C4395DAB21B02;
        }
    }

    class DGR(ulong val) : DGQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x67F68406FF78F2C;
        }
    }

    class DGS(ulong val) : DGR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B9047CFF1EA0F1;
        }
    }

    class DGT(ulong val) : DGS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B609696D658D1E;
        }
    }

    class DGU(ulong val) : DGT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x40A92DFBA91CAF8;
        }
    }

    class DGV(ulong val) : DGU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x72FF153CAC0DCF4;
        }
    }

    class DGW(ulong val) : DGV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B3559A0513638A;
        }
    }

    class DGX(ulong val) : DGW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D321F1370B0352;
        }
    }

    class DGY(ulong val) : DGX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A1898FC6075F7D;
        }
    }

    class DGZ(ulong val) : DGY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67F0A573135F079;
        }
    }

    class DHA(ulong val) : DGZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x67CCF5FAE0045BB;
        }
    }

    class DHB(ulong val) : DHA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F41B3E08A46CF6;
        }
    }

    class DHC(ulong val) : DHB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x73969A7F9387290;
        }
    }

    class DHD(ulong val) : DHC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FBB1D36277B9E9;
        }
    }

    class DHE(ulong val) : DHD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BE92822AFC223A;
        }
    }

    class DHF(ulong val) : DHE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x40101DE33041F4F;
        }
    }

    class DHG(ulong val) : DHF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6D0AF88CEF3289B;
        }
    }

    class DHH(ulong val) : DHG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88B9E5B3200F319;
        }
    }

    class DHI(ulong val) : DHH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4221B14F4B4C497;
        }
    }

    class DHJ(ulong val) : DHI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x22D30D0401797CC;
        }
    }

    class DHK(ulong val) : DHJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A0743F16A3F386;
        }
    }

    class DHL(ulong val) : DHK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x354C66A7CB689E3;
        }
    }

    class DHM(ulong val) : DHL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x406AB9A4BE904CC;
        }
    }

    class DHN(ulong val) : DHM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x930B41F84C1A28C;
        }
    }

    class DHO(ulong val) : DHN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x64C00ECB80E0D7A;
        }
    }

    class DHP(ulong val) : DHO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8FAF7635BFE1E3E;
        }
    }

    class DHQ(ulong val) : DHP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78F32EE1BA2EB2A;
        }
    }

    class DHR(ulong val) : DHQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x790394F4AD011E3;
        }
    }

    class DHS(ulong val) : DHR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x984E884B290A99E;
        }
    }

    class DHT(ulong val) : DHS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50CD9418109F08F;
        }
    }

    class DHU(ulong val) : DHT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3BC4CED1171B141;
        }
    }

    class DHV(ulong val) : DHU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94BE538CDBE739B;
        }
    }

    class DHW(ulong val) : DHV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x41B2040CC387925;
        }
    }

    class DHX(ulong val) : DHW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71CB1C9A6208457;
        }
    }

    class DHY(ulong val) : DHX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24416C50CCC8321;
        }
    }

    class DHZ(ulong val) : DHY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x825ADC1BEFBFF05;
        }
    }

    class DIA(ulong val) : DHZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11F57FEF48393EE;
        }
    }

    class DIB(ulong val) : DIA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6453A996AFEE041;
        }
    }

    class DIC(ulong val) : DIB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B1D6BC19754C58;
        }
    }

    class DID(ulong val) : DIC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x223730871BF72AB;
        }
    }

    class DIE(ulong val) : DID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x445E82DA336039D;
        }
    }

    class DIF(ulong val) : DIE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x97201D40F56C862;
        }
    }

    class DIG(ulong val) : DIF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91397942E635E2C;
        }
    }

    class DIH(ulong val) : DIG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8834A94101D9C60;
        }
    }

    class DII(ulong val) : DIH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5B3AEE29CACECD6;
        }
    }

    class DIJ(ulong val) : DII(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x386D3BC249EAEEA;
        }
    }

    class DIK(ulong val) : DIJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A8764EF75E0F81;
        }
    }

    class DIL(ulong val) : DIK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B095BA36443285;
        }
    }

    class DIM(ulong val) : DIL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x74CB3DED6355C39;
        }
    }

    class DIN(ulong val) : DIM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78A8BA474893957;
        }
    }

    class DIO(ulong val) : DIN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x638CE611282F12C;
        }
    }

    class DIP(ulong val) : DIO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A807F0FBD33A03;
        }
    }

    class DIQ(ulong val) : DIP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x117DE1CD2E13A78;
        }
    }

    class DIR(ulong val) : DIQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x237EE5D1E6E00CD;
        }
    }

    class DIS(ulong val) : DIR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x631F4675A81F42B;
        }
    }

    class DIT(ulong val) : DIS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4EC2AD7F1E9B4AB;
        }
    }

    class DIU(ulong val) : DIT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5240C5A0E9107C5;
        }
    }

    class DIV(ulong val) : DIU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x234FA36D91DD9C2;
        }
    }

    class DIW(ulong val) : DIV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x505F402571A66E0;
        }
    }

    class DIX(ulong val) : DIW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7C8A7D908F94566;
        }
    }

    class DIY(ulong val) : DIX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6FB8B046264D4D3;
        }
    }

    class DIZ(ulong val) : DIY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77C6EDD0D82E49E;
        }
    }

    class DJA(ulong val) : DIZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17A4C6F2CAB312A;
        }
    }

    class DJB(ulong val) : DJA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C493B24774F8E8;
        }
    }

    class DJC(ulong val) : DJB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79BA2AC27FFF0FF;
        }
    }

    class DJD(ulong val) : DJC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A64B4889E1DE96;
        }
    }

    class DJE(ulong val) : DJD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31810A63A7B4F31;
        }
    }

    class DJF(ulong val) : DJE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A33886222B885E;
        }
    }

    class DJG(ulong val) : DJF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8DBF349D23BDB73;
        }
    }

    class DJH(ulong val) : DJG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18C51118FC8C494;
        }
    }

    class DJI(ulong val) : DJH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x26B4F8295D92217;
        }
    }

    class DJJ(ulong val) : DJI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x808C761DEDA5DCF;
        }
    }

    class DJK(ulong val) : DJJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18869C5FF21EEAD;
        }
    }

    class DJL(ulong val) : DJK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16040462A407135;
        }
    }

    class DJM(ulong val) : DJL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7BE3A44A57BF826;
        }
    }

    class DJN(ulong val) : DJM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x32F97152938CEEF;
        }
    }

    class DJO(ulong val) : DJN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E49C8AAAB6D09F;
        }
    }

    class DJP(ulong val) : DJO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FD01639E749AA4;
        }
    }

    class DJQ(ulong val) : DJP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A3BF143FA581D3;
        }
    }

    class DJR(ulong val) : DJQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x169E7546B8F6BA8;
        }
    }

    class DJS(ulong val) : DJR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x58834F97EA1790A;
        }
    }

    class DJT(ulong val) : DJS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16C1F13C534C7E5;
        }
    }

    class DJU(ulong val) : DJT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D012F667D9DB11;
        }
    }

    class DJV(ulong val) : DJU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7694314492E8E2D;
        }
    }

    class DJW(ulong val) : DJV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5D77E027FA19D01;
        }
    }

    class DJX(ulong val) : DJW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8EC613F82304958;
        }
    }

    class DJY(ulong val) : DJX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47FAD5BF62C2212;
        }
    }

    class DJZ(ulong val) : DJY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x378B43DAF4C8748;
        }
    }

    class DKA(ulong val) : DJZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x585EDFB82B92AFB;
        }
    }

    class DKB(ulong val) : DKA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DCE115AC88CD00;
        }
    }

    class DKC(ulong val) : DKB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x27C2B209FBFD064;
        }
    }

    class DKD(ulong val) : DKC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4597B2857C161DB;
        }
    }

    class DKE(ulong val) : DKD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3460E83B67887B2;
        }
    }

    class DKF(ulong val) : DKE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A40E879D0E10DC;
        }
    }

    class DKG(ulong val) : DKF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x503D376E4255DF5;
        }
    }

    class DKH(ulong val) : DKG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5C2BEFFBA9BEFE2;
        }
    }

    class DKI(ulong val) : DKH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6FAB660E7598488;
        }
    }

    class DKJ(ulong val) : DKI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x776C59DA5233B0A;
        }
    }

    class DKK(ulong val) : DKJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x109BFAA72F4C26F;
        }
    }

    class DKL(ulong val) : DKK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7FEDEB5A7300E16;
        }
    }

    class DKM(ulong val) : DKL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x288F9F65D00C8DE;
        }
    }

    class DKN(ulong val) : DKM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x18083BA1A71A413;
        }
    }

    class DKO(ulong val) : DKN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D47DC127876AE5;
        }
    }

    class DKP(ulong val) : DKO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x430730D262FE4EC;
        }
    }

    class DKQ(ulong val) : DKP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x332941C196208FF;
        }
    }

    class DKR(ulong val) : DKQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1B6CC22B63677C4;
        }
    }

    class DKS(ulong val) : DKR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F913CDA4176840;
        }
    }

    class DKT(ulong val) : DKS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x42BAF4EDDF92D1B;
        }
    }

    class DKU(ulong val) : DKT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x714EC05C797FCB8;
        }
    }

    class DKV(ulong val) : DKU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x916F9525EFC8187;
        }
    }

    class DKW(ulong val) : DKV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5EEA31C477EC7E1;
        }
    }

    class DKX(ulong val) : DKW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x643FAF2094148AA;
        }
    }

    class DKY(ulong val) : DKX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8053CE6F5A60F5D;
        }
    }

    class DKZ(ulong val) : DKY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61FAA183E74305A;
        }
    }

    class DLA(ulong val) : DKZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49D23EDBC88F60E;
        }
    }

    class DLB(ulong val) : DLA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6F547797A07F4A1;
        }
    }

    class DLC(ulong val) : DLB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A27655C981FDB5;
        }
    }

    class DLD(ulong val) : DLC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x320184D1E6F4FCD;
        }
    }

    class DLE(ulong val) : DLD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81963BB4AE5A95B;
        }
    }

    class DLF(ulong val) : DLE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26388CF877CB6D9;
        }
    }

    class DLG(ulong val) : DLF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9324029B9E9500D;
        }
    }

    class DLH(ulong val) : DLG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x82289F48218BBBB;
        }
    }

    class DLI(ulong val) : DLH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A2D2342E596A94;
        }
    }

    class DLJ(ulong val) : DLI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79B65031A3F442F;
        }
    }

    class DLK(ulong val) : DLJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19989AF7CC6388F;
        }
    }

    class DLL(ulong val) : DLK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x620064018310F2A;
        }
    }

    class DLM(ulong val) : DLL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B6052D0CC57008;
        }
    }

    class DLN(ulong val) : DLM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x705707AA99D707F;
        }
    }

    class DLO(ulong val) : DLN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93DB0A4E1799D06;
        }
    }

    class DLP(ulong val) : DLO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x982AEAAD3B25D45;
        }
    }

    class DLQ(ulong val) : DLP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1A8233B340C7505;
        }
    }

    class DLR(ulong val) : DLQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79177C25798697A;
        }
    }

    class DLS(ulong val) : DLR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x89D2E4961D88CBA;
        }
    }

    class DLT(ulong val) : DLS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x32869D8BC1BD8A6;
        }
    }

    class DLU(ulong val) : DLT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2ECB02BEEF0B2D9;
        }
    }

    class DLV(ulong val) : DLU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9149FAD039292CE;
        }
    }

    class DLW(ulong val) : DLV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x287208AB2D933FA;
        }
    }

    class DLX(ulong val) : DLW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x518AF10FD9F3336;
        }
    }

    class DLY(ulong val) : DLX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1AB54F8C1FBD4F7;
        }
    }

    class DLZ(ulong val) : DLY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5732ACDFE02AE4E;
        }
    }

    class DMA(ulong val) : DLZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3F2B974726F4AED;
        }
    }

    class DMB(ulong val) : DMA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x84F9D5AFAA2C6DF;
        }
    }

    class DMC(ulong val) : DMB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C016ABAED848F3;
        }
    }

    class DMD(ulong val) : DMC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E71196818DADDB;
        }
    }

    class DME(ulong val) : DMD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E3461C28B02B64;
        }
    }

    class DMF(ulong val) : DME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4981E900AA6CB4A;
        }
    }

    class DMG(ulong val) : DMF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92DAD17E5D343E3;
        }
    }

    class DMH(ulong val) : DMG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x984B40E84E9560B;
        }
    }

    class DMI(ulong val) : DMH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x552C03C5E7AD65D;
        }
    }

    class DMJ(ulong val) : DMI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F2B7F531FB8E69;
        }
    }

    class DMK(ulong val) : DMJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4582D0C3D0EF85F;
        }
    }

    class DML(ulong val) : DMK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x230AA3E645F605B;
        }
    }

    class DMM(ulong val) : DML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x756BEF458B305CA;
        }
    }

    class DMN(ulong val) : DMM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71A81CA1BA64008;
        }
    }

    class DMO(ulong val) : DMN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D81BB53977C385;
        }
    }

    class DMP(ulong val) : DMO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x57FE252D791F533;
        }
    }

    class DMQ(ulong val) : DMP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x363439F86F67623;
        }
    }

    class DMR(ulong val) : DMQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B4C85DEA6E0B3E;
        }
    }

    class DMS(ulong val) : DMR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3ADFE7ABF5701D0;
        }
    }

    class DMT(ulong val) : DMS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x527C93311138B76;
        }
    }

    class DMU(ulong val) : DMT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x105C43060E1EA13;
        }
    }

    class DMV(ulong val) : DMU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A61BDAF110588D;
        }
    }

    class DMW(ulong val) : DMV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x245E6018FB687B7;
        }
    }

    class DMX(ulong val) : DMW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x832801FA628E2C6;
        }
    }

    class DMY(ulong val) : DMX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9065CE838CD987C;
        }
    }

    class DMZ(ulong val) : DMY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E9C87B1F19D3B4;
        }
    }

    class DNA(ulong val) : DMZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x985A30132D74A4E;
        }
    }

    class DNB(ulong val) : DNA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CB58E592FF0730;
        }
    }

    class DNC(ulong val) : DNB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60DB7F140379C5E;
        }
    }

    class DND(ulong val) : DNC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x92E6A6D58617C35;
        }
    }

    class DNE(ulong val) : DND(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x488420569B4E26B;
        }
    }

    class DNF(ulong val) : DNE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A58E7E888083FB;
        }
    }

    class DNG(ulong val) : DNF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E53C6E92201628;
        }
    }

    class DNH(ulong val) : DNG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x589EB1C44E7A8C1;
        }
    }

    class DNI(ulong val) : DNH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x14993B43EFF1D3F;
        }
    }

    class DNJ(ulong val) : DNI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6C6E590A440972F;
        }
    }

    class DNK(ulong val) : DNJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x282ABD972E9B69B;
        }
    }

    class DNL(ulong val) : DNK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6939510F4247614;
        }
    }

    class DNM(ulong val) : DNL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A13EBE8E099E49;
        }
    }

    class DNN(ulong val) : DNM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35A650378341100;
        }
    }

    class DNO(ulong val) : DNN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9684A174DC570A6;
        }
    }

    class DNP(ulong val) : DNO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63B3EBF4CDCC3A3;
        }
    }

    class DNQ(ulong val) : DNP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48B0625A22A97E5;
        }
    }

    class DNR(ulong val) : DNQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x818427CE35BE061;
        }
    }

    class DNS(ulong val) : DNR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A6A8D1538D611D;
        }
    }

    class DNT(ulong val) : DNS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4231CD36D947861;
        }
    }

    class DNU(ulong val) : DNT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15B063296BB03F4;
        }
    }

    class DNV(ulong val) : DNU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34AF175F44CF1E6;
        }
    }

    class DNW(ulong val) : DNV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A12E80EE5AFA1F;
        }
    }

    class DNX(ulong val) : DNW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57FD159B65A8D48;
        }
    }

    class DNY(ulong val) : DNX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E5BEB460051D92;
        }
    }

    class DNZ(ulong val) : DNY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x927C4F4D3F6D375;
        }
    }

    class DOA(ulong val) : DNZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x31004AB6DEE3C30;
        }
    }

    class DOB(ulong val) : DOA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6481BE8F07D9F41;
        }
    }

    class DOC(ulong val) : DOB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E7482C56D8DA19;
        }
    }

    class DOD(ulong val) : DOC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4FA489B00B4E7D2;
        }
    }

    class DOE(ulong val) : DOD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x18953A1E01A694B;
        }
    }

    class DOF(ulong val) : DOE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23C8EEF8E97E0E3;
        }
    }

    class DOG(ulong val) : DOF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x674D994E5BBFFD4;
        }
    }

    class DOH(ulong val) : DOG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C80832F81390B8;
        }
    }

    class DOI(ulong val) : DOH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x434397D1C94214C;
        }
    }

    class DOJ(ulong val) : DOI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2823F14F604F581;
        }
    }

    class DOK(ulong val) : DOJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x648B6A97C69579E;
        }
    }

    class DOL(ulong val) : DOK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11BACDBEA6DB366;
        }
    }

    class DOM(ulong val) : DOL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F045B57C91BF65;
        }
    }

    class DON(ulong val) : DOM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x548FA6BE487A261;
        }
    }

    class DOO(ulong val) : DON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26908B9EE339974;
        }
    }

    class DOP(ulong val) : DOO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80C08749EFDFF9B;
        }
    }

    class DOQ(ulong val) : DOP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3D014E9F1043390;
        }
    }

    class DOR(ulong val) : DOQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A52A70DECA902D;
        }
    }

    class DOS(ulong val) : DOR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1949BFE5984AF8F;
        }
    }

    class DOT(ulong val) : DOS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x884B201099A76DC;
        }
    }

    class DOU(ulong val) : DOT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x901BCED79097273;
        }
    }

    class DOV(ulong val) : DOU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26E2F0A24C0D20F;
        }
    }

    class DOW(ulong val) : DOV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x696FF3F845FB6FE;
        }
    }

    class DOX(ulong val) : DOW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E87A5A4F184FDF;
        }
    }

    class DOY(ulong val) : DOX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6FA1D57BB547F79;
        }
    }

    class DOZ(ulong val) : DOY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x98ECAFCCF2610A3;
        }
    }

    class DPA(ulong val) : DOZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A7E1A3410CF5F7;
        }
    }

    class DPB(ulong val) : DPA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80D7740D14DEA9C;
        }
    }

    class DPC(ulong val) : DPB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3D5CAE1861A9EBD;
        }
    }

    class DPD(ulong val) : DPC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x40044F02963ED63;
        }
    }

    class DPE(ulong val) : DPD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9967EA9E93B2DA7;
        }
    }

    class DPF(ulong val) : DPE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x509532DFE944256;
        }
    }

    class DPG(ulong val) : DPF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79F10DC09D50D6E;
        }
    }

    class DPH(ulong val) : DPG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4FEA76653A7F009;
        }
    }

    class DPI(ulong val) : DPH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2473C64E136CF2B;
        }
    }

    class DPJ(ulong val) : DPI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23F6CF0FAF61C9C;
        }
    }

    class DPK(ulong val) : DPJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6067A51A3FDD625;
        }
    }

    class DPL(ulong val) : DPK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x940BFDC7496A8A7;
        }
    }

    class DPM(ulong val) : DPL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1E5CCB5D0D9938D;
        }
    }

    class DPN(ulong val) : DPM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77155C0717EA2AD;
        }
    }

    class DPO(ulong val) : DPN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D1D27259FE4474;
        }
    }

    class DPP(ulong val) : DPO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x14BE87716F7713D;
        }
    }

    class DPQ(ulong val) : DPP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63AC8D9AD769FB8;
        }
    }

    class DPR(ulong val) : DPQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1D70D5C0DABF0DD;
        }
    }

    class DPS(ulong val) : DPR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F3EDB0BF509B50;
        }
    }

    class DPT(ulong val) : DPS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1034C3E04A0C259;
        }
    }

    class DPU(ulong val) : DPT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88EE5977A84D077;
        }
    }

    class DPV(ulong val) : DPU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D5D3B1C39CBD87;
        }
    }

    class DPW(ulong val) : DPV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x78277CA9175ED33;
        }
    }

    class DPX(ulong val) : DPW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1C6C38794912B6B;
        }
    }

    class DPY(ulong val) : DPX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D78E11BD88724B;
        }
    }

    class DPZ(ulong val) : DPY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x179C1DB5645435F;
        }
    }

    class DQA(ulong val) : DPZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F079CC83835F65;
        }
    }

    class DQB(ulong val) : DQA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1A3BD94CD9A4542;
        }
    }

    class DQC(ulong val) : DQB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47B56D7CC703ABD;
        }
    }

    class DQD(ulong val) : DQC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E52E675696BADD;
        }
    }

    class DQE(ulong val) : DQD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F0A90681EF5992;
        }
    }

    class DQF(ulong val) : DQE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D71E2C19FEB09A;
        }
    }

    class DQG(ulong val) : DQF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x68A89C362383AC5;
        }
    }

    class DQH(ulong val) : DQG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x68752A9DBE859A1;
        }
    }

    class DQI(ulong val) : DQH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F3AD9650CD0AC5;
        }
    }

    class DQJ(ulong val) : DQI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A2251BB790D256;
        }
    }

    class DQK(ulong val) : DQJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36B96C74D955D61;
        }
    }

    class DQL(ulong val) : DQK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x300CC2FE2537572;
        }
    }

    class DQM(ulong val) : DQL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3526F15E8B691A3;
        }
    }

    class DQN(ulong val) : DQM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x468EC064840AD48;
        }
    }

    class DQO(ulong val) : DQN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B795DB475B86E4;
        }
    }

    class DQP(ulong val) : DQO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x28027B9BE824D70;
        }
    }

    class DQQ(ulong val) : DQP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x79BC73E24BEFB47;
        }
    }

    class DQR(ulong val) : DQQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x449920B7C620C90;
        }
    }

    class DQS(ulong val) : DQR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88860F72B95DE23;
        }
    }

    class DQT(ulong val) : DQS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62E318CDE6DB6FB;
        }
    }

    class DQU(ulong val) : DQT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x83A2B84A992AFD7;
        }
    }

    class DQV(ulong val) : DQU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x23BBE9E39AFF9C2;
        }
    }

    class DQW(ulong val) : DQV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23286CF5EDE1654;
        }
    }

    class DQX(ulong val) : DQW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86117742EB090BC;
        }
    }

    class DQY(ulong val) : DQX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A87BBB26B8EB31;
        }
    }

    class DQZ(ulong val) : DQY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x334880A7F245F7A;
        }
    }

    class DRA(ulong val) : DQZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4DE44166A8D23D9;
        }
    }

    class DRB(ulong val) : DRA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3165D3A1B7E9FED;
        }
    }

    class DRC(ulong val) : DRB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A5EF9420714E41;
        }
    }

    class DRD(ulong val) : DRC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x728A1CE88EBD7F8;
        }
    }

    class DRE(ulong val) : DRD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x480121BAC87AD46;
        }
    }

    class DRF(ulong val) : DRE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4318273E1B3D962;
        }
    }

    class DRG(ulong val) : DRF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3522185011F9691;
        }
    }

    class DRH(ulong val) : DRG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19387C123BB0A87;
        }
    }

    class DRI(ulong val) : DRH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x436252BE46E3888;
        }
    }

    class DRJ(ulong val) : DRI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AAAF720BC7A7DB;
        }
    }

    class DRK(ulong val) : DRJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3A16D0E6E89B8EA;
        }
    }

    class DRL(ulong val) : DRK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3EE2F81B302F873;
        }
    }

    class DRM(ulong val) : DRL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5ACC464CBC27B5D;
        }
    }

    class DRN(ulong val) : DRM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9904EF3939644B0;
        }
    }

    class DRO(ulong val) : DRN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3BA00FCCB4598AC;
        }
    }

    class DRP(ulong val) : DRO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3BE4051712B7334;
        }
    }

    class DRQ(ulong val) : DRP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x783E6C1EB996F59;
        }
    }

    class DRR(ulong val) : DRQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82F6953ED3BB5AF;
        }
    }

    class DRS(ulong val) : DRR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x384F8B78D83E068;
        }
    }

    class DRT(ulong val) : DRS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A53A1983F8BC70;
        }
    }

    class DRU(ulong val) : DRT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x314F139B1AC996A;
        }
    }

    class DRV(ulong val) : DRU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x58D5DCFC5F6B3CC;
        }
    }

    class DRW(ulong val) : DRV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D10455DE08135C;
        }
    }

    class DRX(ulong val) : DRW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81E47D4963585F5;
        }
    }

    class DRY(ulong val) : DRX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A142E99404869D;
        }
    }

    class DRZ(ulong val) : DRY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x88F39D75CB72BB3;
        }
    }

    class DSA(ulong val) : DRZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x19939C1035BBDF3;
        }
    }

    class DSB(ulong val) : DSA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3E7DD7B4EC9F70C;
        }
    }

    class DSC(ulong val) : DSB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x19F0746A6BC886B;
        }
    }

    class DSD(ulong val) : DSC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x600189CAB708D1D;
        }
    }

    class DSE(ulong val) : DSD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x404D91B142220DD;
        }
    }

    class DSF(ulong val) : DSE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x12ED7685484ACF3;
        }
    }

    class DSG(ulong val) : DSF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35B335DF556E985;
        }
    }

    class DSH(ulong val) : DSG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A941AB599B2A51;
        }
    }

    class DSI(ulong val) : DSH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5F60BC083877919;
        }
    }

    class DSJ(ulong val) : DSI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x45EC47578680D1F;
        }
    }

    class DSK(ulong val) : DSJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F89E46D615F4F2;
        }
    }

    class DSL(ulong val) : DSK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F772C72F264754;
        }
    }

    class DSM(ulong val) : DSL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5BD8A211A61DB2E;
        }
    }

    class DSN(ulong val) : DSM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x557C1C7C755FED1;
        }
    }

    class DSO(ulong val) : DSN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2110F638D8AABDB;
        }
    }

    class DSP(ulong val) : DSO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8CAB0646D8075FB;
        }
    }

    class DSQ(ulong val) : DSP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D8215C7A1CBBF9;
        }
    }

    class DSR(ulong val) : DSQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81A207D9CF6383C;
        }
    }

    class DSS(ulong val) : DSR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x567D6A6E12FA244;
        }
    }

    class DST(ulong val) : DSS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1276315C24919E9;
        }
    }

    class DSU(ulong val) : DST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9232FFF0F29CF01;
        }
    }

    class DSV(ulong val) : DSU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x218C26A67DADC21;
        }
    }

    class DSW(ulong val) : DSV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x279AB561BA9167E;
        }
    }

    class DSX(ulong val) : DSW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FCF839D66C8B42;
        }
    }

    class DSY(ulong val) : DSX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4C074BDA7ABECAB;
        }
    }

    class DSZ(ulong val) : DSY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B4B2009F5321C4;
        }
    }

    class DTA(ulong val) : DSZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24AABE90F211C7D;
        }
    }

    class DTB(ulong val) : DTA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x928A507D9CD6E82;
        }
    }

    class DTC(ulong val) : DTB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21E3631921F6D62;
        }
    }

    class DTD(ulong val) : DTC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7F1FE0DCA83F724;
        }
    }

    class DTE(ulong val) : DTD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95A3047D3225577;
        }
    }

    class DTF(ulong val) : DTE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87CE50EC6BF6A03;
        }
    }

    class DTG(ulong val) : DTF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x977AF195764ADC3;
        }
    }

    class DTH(ulong val) : DTG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A094CACA5274C5;
        }
    }

    class DTI(ulong val) : DTH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x32E32EF1F7FA793;
        }
    }

    class DTJ(ulong val) : DTI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36C2D6D1C7AB8E4;
        }
    }

    class DTK(ulong val) : DTJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E930D653FCF426;
        }
    }

    class DTL(ulong val) : DTK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7146234121F036C;
        }
    }

    class DTM(ulong val) : DTL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8481D534E080D78;
        }
    }

    class DTN(ulong val) : DTM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3F55203CAAFF9FE;
        }
    }

    class DTO(ulong val) : DTN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C269E909056EB6;
        }
    }

    class DTP(ulong val) : DTO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36D7BD14D08E32B;
        }
    }

    class DTQ(ulong val) : DTP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6563E2069D68FAD;
        }
    }

    class DTR(ulong val) : DTQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x90D5F406A6CB30B;
        }
    }

    class DTS(ulong val) : DTR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x52F41371DAF4619;
        }
    }

    class DTT(ulong val) : DTS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85B37CEEB5F3AC0;
        }
    }

    class DTU(ulong val) : DTT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x357B61295F876CB;
        }
    }

    class DTV(ulong val) : DTU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26F43068685575E;
        }
    }

    class DTW(ulong val) : DTV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A98BB5F7FFA9D0;
        }
    }

    class DTX(ulong val) : DTW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C86E893108AC0D;
        }
    }

    class DTY(ulong val) : DTX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B2A577280BE351;
        }
    }

    class DTZ(ulong val) : DTY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x32D64AA95773EA4;
        }
    }

    class DUA(ulong val) : DTZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FF50B5C9C6B911;
        }
    }

    class DUB(ulong val) : DUA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x112843B16907C41;
        }
    }

    class DUC(ulong val) : DUB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1BC403D8ACCB6F6;
        }
    }

    class DUD(ulong val) : DUC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64C67533A581756;
        }
    }

    class DUE(ulong val) : DUD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A0ACB01F7C6C7E;
        }
    }

    class DUF(ulong val) : DUE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F1F3C6F3D6F383;
        }
    }

    class DUG(ulong val) : DUF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9831D39B15D2D65;
        }
    }

    class DUH(ulong val) : DUG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7198FD6ECBE7041;
        }
    }

    class DUI(ulong val) : DUH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B40FA152F02210;
        }
    }

    class DUJ(ulong val) : DUI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x60983A39F348D14;
        }
    }

    class DUK(ulong val) : DUJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BD7A95D36194AD;
        }
    }

    class DUL(ulong val) : DUK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x562E55980019106;
        }
    }

    class DUM(ulong val) : DUL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7ABE3DE3916A05D;
        }
    }

    class DUN(ulong val) : DUM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63D8233151C12E4;
        }
    }

    class DUO(ulong val) : DUN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34F6DB23CF74A59;
        }
    }

    class DUP(ulong val) : DUO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98B9186EDC6ADF7;
        }
    }

    class DUQ(ulong val) : DUP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3773DDDC450C030;
        }
    }

    class DUR(ulong val) : DUQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B2D55194161E5B;
        }
    }

    class DUS(ulong val) : DUR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B64F4593F35854;
        }
    }

    class DUT(ulong val) : DUS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x692A3FD15D5EF33;
        }
    }

    class DUU(ulong val) : DUT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4BC4D6DBC015D50;
        }
    }

    class DUV(ulong val) : DUU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5B0611D9684A8C0;
        }
    }

    class DUW(ulong val) : DUV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x10D9E731833ADC1;
        }
    }

    class DUX(ulong val) : DUW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x155778E0C1338A5;
        }
    }

    class DUY(ulong val) : DUX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52298C564BDBC41;
        }
    }

    class DUZ(ulong val) : DUY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x74DCFF60C089F46;
        }
    }

    class DVA(ulong val) : DUZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E46A0459131455;
        }
    }

    class DVB(ulong val) : DVA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2985416ACA3279C;
        }
    }

    class DVC(ulong val) : DVB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AF0BFD227D894C;
        }
    }

    class DVD(ulong val) : DVC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6ECEBC1B5B0F9FA;
        }
    }

    class DVE(ulong val) : DVD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x760E811FB7ACBA7;
        }
    }

    class DVF(ulong val) : DVE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x912BD159D376776;
        }
    }

    class DVG(ulong val) : DVF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x44C02E76ABDF3C4;
        }
    }

    class DVH(ulong val) : DVG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53147465DF7AA6E;
        }
    }

    class DVI(ulong val) : DVH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9227F021E6470CE;
        }
    }

    class DVJ(ulong val) : DVI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E959738B37D8D9;
        }
    }

    class DVK(ulong val) : DVJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x808ADF5B0481A95;
        }
    }

    class DVL(ulong val) : DVK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5605CC7AE587252;
        }
    }

    class DVM(ulong val) : DVL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7972EBBC0FD1370;
        }
    }

    class DVN(ulong val) : DVM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x623D094B74755F4;
        }
    }

    class DVO(ulong val) : DVN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2446DA3E7B0D599;
        }
    }

    class DVP(ulong val) : DVO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9948D7084992214;
        }
    }

    class DVQ(ulong val) : DVP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E12ABBF8F79689;
        }
    }

    class DVR(ulong val) : DVQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2EEBE423AF8C61B;
        }
    }

    class DVS(ulong val) : DVR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E1C6E5BEC0BBAB;
        }
    }

    class DVT(ulong val) : DVS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x304598881F59F46;
        }
    }

    class DVU(ulong val) : DVT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96653769CCD8006;
        }
    }

    class DVV(ulong val) : DVU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5167D07D458C780;
        }
    }

    class DVW(ulong val) : DVV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x956F34728412808;
        }
    }

    class DVX(ulong val) : DVW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x67263DD9C7C9B83;
        }
    }

    class DVY(ulong val) : DVX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8795A7710F01744;
        }
    }

    class DVZ(ulong val) : DVY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1114D19129AF23B;
        }
    }

    class DWA(ulong val) : DVZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3E3178A1B172D28;
        }
    }

    class DWB(ulong val) : DWA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85BD68247BDD2A0;
        }
    }

    class DWC(ulong val) : DWB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x394B3D03E416DEC;
        }
    }

    class DWD(ulong val) : DWC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5209A753C885B6B;
        }
    }

    class DWE(ulong val) : DWD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E94CBFAFF7C27D;
        }
    }

    class DWF(ulong val) : DWE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5C57CFDC9CF8997;
        }
    }

    class DWG(ulong val) : DWF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63A9A53C3BC8189;
        }
    }

    class DWH(ulong val) : DWG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85C7CD39737935E;
        }
    }

    class DWI(ulong val) : DWH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7672C160A85A1F6;
        }
    }

    class DWJ(ulong val) : DWI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x542E5C6C0879275;
        }
    }

    class DWK(ulong val) : DWJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x450BB4B5B4F4489;
        }
    }

    class DWL(ulong val) : DWK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x58E98418AA179F0;
        }
    }

    class DWM(ulong val) : DWL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F155FD72BC67A3;
        }
    }

    class DWN(ulong val) : DWM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x708EF96189AA9F2;
        }
    }

    class DWO(ulong val) : DWN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x669D28E995BD74D;
        }
    }

    class DWP(ulong val) : DWO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x20291840732E1B7;
        }
    }

    class DWQ(ulong val) : DWP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x972F2C74A94838E;
        }
    }

    class DWR(ulong val) : DWQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x30417990E1C5EC0;
        }
    }

    class DWS(ulong val) : DWR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46A5755A906E3A4;
        }
    }

    class DWT(ulong val) : DWS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B33EBF6C1DCA7C;
        }
    }

    class DWU(ulong val) : DWT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x25D03B0C1C5DD6E;
        }
    }

    class DWV(ulong val) : DWU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F7B01766DF86D0;
        }
    }

    class DWW(ulong val) : DWV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48AB1ED731E7C2D;
        }
    }

    class DWX(ulong val) : DWW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A8B4B05084BC7E;
        }
    }

    class DWY(ulong val) : DWX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x700DFD30CAB2298;
        }
    }

    class DWZ(ulong val) : DWY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x84884F471A09A22;
        }
    }

    class DXA(ulong val) : DWZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x295B3318F346302;
        }
    }

    class DXB(ulong val) : DXA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DCBCC94F122BA8;
        }
    }

    class DXC(ulong val) : DXB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43D720E45443539;
        }
    }

    class DXD(ulong val) : DXC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CF15CF69E91579;
        }
    }

    class DXE(ulong val) : DXD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x89CE2C06F8C4DC7;
        }
    }

    class DXF(ulong val) : DXE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F1DED0F8C74287;
        }
    }

    class DXG(ulong val) : DXF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E0C34954922F34;
        }
    }

    class DXH(ulong val) : DXG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80F9DD560394459;
        }
    }

    class DXI(ulong val) : DXH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x785CC66FDAD49D2;
        }
    }

    class DXJ(ulong val) : DXI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x68BC0E599F75642;
        }
    }

    class DXK(ulong val) : DXJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F552B7BAB2184A;
        }
    }

    class DXL(ulong val) : DXK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E6C56A3E55C4D3;
        }
    }

    class DXM(ulong val) : DXL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61393E540B517E4;
        }
    }

    class DXN(ulong val) : DXM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D821772D0C944A;
        }
    }

    class DXO(ulong val) : DXN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2C62895486FCBEF;
        }
    }

    class DXP(ulong val) : DXO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B37C0A65D448A4;
        }
    }

    class DXQ(ulong val) : DXP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A3BBB151B82518;
        }
    }

    class DXR(ulong val) : DXQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x398F50722C7526F;
        }
    }

    class DXS(ulong val) : DXR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85EFB0766DC25D8;
        }
    }

    class DXT(ulong val) : DXS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A4FF7ECCC261B3;
        }
    }

    class DXU(ulong val) : DXT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x724B42EA9B3BCB4;
        }
    }

    class DXV(ulong val) : DXU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F851B1C41D6D11;
        }
    }

    class DXW(ulong val) : DXV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4AE81C795A0267C;
        }
    }

    class DXX(ulong val) : DXW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39E84D1B2FC9AEE;
        }
    }

    class DXY(ulong val) : DXX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48F3630542AD726;
        }
    }

    class DXZ(ulong val) : DXY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3DD05FD25858FBD;
        }
    }

    class DYA(ulong val) : DXZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x274EBDF8FBD7AF4;
        }
    }

    class DYB(ulong val) : DYA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BDA0C9896944DB;
        }
    }

    class DYC(ulong val) : DYB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6931B712BF663EB;
        }
    }

    class DYD(ulong val) : DYC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x829B1A100F4D8AE;
        }
    }

    class DYE(ulong val) : DYD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x178FD24280B4818;
        }
    }

    class DYF(ulong val) : DYE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72B793EC79B6941;
        }
    }

    class DYG(ulong val) : DYF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x99292DA573F421B;
        }
    }

    class DYH(ulong val) : DYG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6890DE7E88201D5;
        }
    }

    class DYI(ulong val) : DYH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x51E49F7F900152F;
        }
    }

    class DYJ(ulong val) : DYI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B380FEFEACC329;
        }
    }

    class DYK(ulong val) : DYJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x41361B40255B65E;
        }
    }

    class DYL(ulong val) : DYK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11BFE8D1D0E95BB;
        }
    }

    class DYM(ulong val) : DYL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E0C11B8B617708;
        }
    }

    class DYN(ulong val) : DYM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x81173A611428A86;
        }
    }

    class DYO(ulong val) : DYN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63B7CEC7549BD9E;
        }
    }

    class DYP(ulong val) : DYO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x338C9E758A091C7;
        }
    }

    class DYQ(ulong val) : DYP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15B53CFB033FCC6;
        }
    }

    class DYR(ulong val) : DYQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x781CA58FB1A940C;
        }
    }

    class DYS(ulong val) : DYR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4F39379DED9150C;
        }
    }

    class DYT(ulong val) : DYS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A62CE88EBEF986;
        }
    }

    class DYU(ulong val) : DYT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3488040E5DD387B;
        }
    }

    class DYV(ulong val) : DYU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x647753EB63DD04B;
        }
    }

    class DYW(ulong val) : DYV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63B3B3D40D7E6F4;
        }
    }

    class DYX(ulong val) : DYW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x848D19B110FEA26;
        }
    }

    class DYY(ulong val) : DYX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8144955D1EA7160;
        }
    }

    class DYZ(ulong val) : DYY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x564972CC8E60B01;
        }
    }

    class DZA(ulong val) : DYZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5016950A5B0463A;
        }
    }

    class DZB(ulong val) : DZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1BBBD1B1BD043CB;
        }
    }

    class DZC(ulong val) : DZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x22D44E899FA82C7;
        }
    }

    class DZD(ulong val) : DZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BC91C7DBD00CF7;
        }
    }

    class DZE(ulong val) : DZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85D7E259CE10B9C;
        }
    }

    class DZF(ulong val) : DZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x97B026D6E831EF7;
        }
    }

    class DZG(ulong val) : DZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B9C2292A362522;
        }
    }

    class DZH(ulong val) : DZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A918E247B109E1;
        }
    }

    class DZI(ulong val) : DZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C298EE5C0A488C;
        }
    }

    class DZJ(ulong val) : DZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26EA04B85EB41C1;
        }
    }

    class DZK(ulong val) : DZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4F096D9A941A5FB;
        }
    }

    class DZL(ulong val) : DZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E5F3D372C06622;
        }
    }

    class DZM(ulong val) : DZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x95B7BC79764BBC3;
        }
    }

    class DZN(ulong val) : DZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3EE278B4513BC89;
        }
    }

    class DZO(ulong val) : DZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12AF01790351AA2;
        }
    }

    class DZP(ulong val) : DZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16290105505B7AC;
        }
    }

    class DZQ(ulong val) : DZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55FC02B66AEC054;
        }
    }

    class DZR(ulong val) : DZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4F98FEE4618D200;
        }
    }

    class DZS(ulong val) : DZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x75898F425E75A36;
        }
    }

    class DZT(ulong val) : DZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x694CD6C4C768FE0;
        }
    }

    class DZU(ulong val) : DZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F507C09EE053BE;
        }
    }

    class DZV(ulong val) : DZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C470EE43D72280;
        }
    }

    class DZW(ulong val) : DZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x95B6E86E8558F12;
        }
    }

    class DZX(ulong val) : DZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26BD723B7112BBA;
        }
    }

    class DZY(ulong val) : DZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x276A175DF3745F5;
        }
    }

    class DZZ(ulong val) : DZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x382B12EF519D6A1;
        }
    }

    class EAA(ulong val) : DZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x119933DBDE7C5AE;
        }
    }

    class EAB(ulong val) : EAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56FE6697CFCDC3A;
        }
    }

    class EAC(ulong val) : EAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6F4DD3AD233BFCC;
        }
    }

    class EAD(ulong val) : EAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2CE31DFCEF58CCF;
        }
    }

    class EAE(ulong val) : EAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x368FFBE518ADEC8;
        }
    }

    class EAF(ulong val) : EAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4242EB49746B991;
        }
    }

    class EAG(ulong val) : EAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x57603296EF1AD4A;
        }
    }

    class EAH(ulong val) : EAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B81918914A0CB5;
        }
    }

    class EAI(ulong val) : EAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1CCA8552FE3050B;
        }
    }

    class EAJ(ulong val) : EAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A0E66E6C74EC96;
        }
    }

    class EAK(ulong val) : EAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x46DD8BA6D65163D;
        }
    }

    class EAL(ulong val) : EAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x356991FDDF2FCC3;
        }
    }

    class EAM(ulong val) : EAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8EA07EF20AA0986;
        }
    }

    class EAN(ulong val) : EAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FE077354EE3F4A;
        }
    }

    class EAO(ulong val) : EAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86F3DE873179DFC;
        }
    }

    class EAP(ulong val) : EAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7AEA7A1AA804C6C;
        }
    }

    class EAQ(ulong val) : EAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x82A586A3538FCC7;
        }
    }

    class EAR(ulong val) : EAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6111F0031533E59;
        }
    }

    class EAS(ulong val) : EAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x480AA1A24E6C8DC;
        }
    }

    class EAT(ulong val) : EAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16D2399468CA0D0;
        }
    }

    class EAU(ulong val) : EAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x684F17582BA7448;
        }
    }

    class EAV(ulong val) : EAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70A5FB1348BA2F8;
        }
    }

    class EAW(ulong val) : EAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x476A3D53F981CD7;
        }
    }

    class EAX(ulong val) : EAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D7837B17467644;
        }
    }

    class EAY(ulong val) : EAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x929C5C5878AF770;
        }
    }

    class EAZ(ulong val) : EAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x37AE297A04A1D24;
        }
    }

    class EBA(ulong val) : EAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7D7A642654787B7;
        }
    }

    class EBB(ulong val) : EBA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62A9D098DD76693;
        }
    }

    class EBC(ulong val) : EBB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E6E13E7589A75B;
        }
    }

    class EBD(ulong val) : EBC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CB2BF0E33E3894;
        }
    }

    class EBE(ulong val) : EBD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A3065BAB2EA841;
        }
    }

    class EBF(ulong val) : EBE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x28B0F796092F49A;
        }
    }

    class EBG(ulong val) : EBF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9222F6CE418B34A;
        }
    }

    class EBH(ulong val) : EBG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x451C7EA63F0DCD8;
        }
    }

    class EBI(ulong val) : EBH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3721F4661D653AA;
        }
    }

    class EBJ(ulong val) : EBI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A2708BBA0539C5;
        }
    }

    class EBK(ulong val) : EBJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4FC6C03320D1DF8;
        }
    }

    class EBL(ulong val) : EBK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x59EF9573EFCC993;
        }
    }

    class EBM(ulong val) : EBL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x29F879794861324;
        }
    }

    class EBN(ulong val) : EBM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D2EFB8AF0CCC2B;
        }
    }

    class EBO(ulong val) : EBN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x278BE359881EFFE;
        }
    }

    class EBP(ulong val) : EBO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x610B0AB3D9FAB20;
        }
    }

    class EBQ(ulong val) : EBP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5758CD3B79DA4C9;
        }
    }

    class EBR(ulong val) : EBQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E8955FCC2F33AB;
        }
    }

    class EBS(ulong val) : EBR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x243724D456BAC52;
        }
    }

    class EBT(ulong val) : EBS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x605832323395B30;
        }
    }

    class EBU(ulong val) : EBT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x75FC1FC74FD3124;
        }
    }

    class EBV(ulong val) : EBU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C4CA588AEE351F;
        }
    }

    class EBW(ulong val) : EBV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x97D2CB69BBB773C;
        }
    }

    class EBX(ulong val) : EBW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1FF89C70C60A91A;
        }
    }

    class EBY(ulong val) : EBX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B6C1F4CBA2FD0D;
        }
    }

    class EBZ(ulong val) : EBY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x82CE7ED577EA302;
        }
    }

    class ECA(ulong val) : EBZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55CA6BEB3B7B2AD;
        }
    }

    class ECB(ulong val) : ECA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7EEFC83C675736E;
        }
    }

    class ECC(ulong val) : ECB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x40066F54D74395A;
        }
    }

    class ECD(ulong val) : ECC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x912514D821D1C9D;
        }
    }

    class ECE(ulong val) : ECD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x731A4C40A21F093;
        }
    }

    class ECF(ulong val) : ECE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2097D76C713CBAD;
        }
    }

    class ECG(ulong val) : ECF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x38640583FAF112D;
        }
    }

    class ECH(ulong val) : ECG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4151082A6F1EDFE;
        }
    }

    class ECI(ulong val) : ECH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C2A8CCD684FFCA;
        }
    }

    class ECJ(ulong val) : ECI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x370F881390BE46B;
        }
    }

    class ECK(ulong val) : ECJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CA35137BD13D94;
        }
    }

    class ECL(ulong val) : ECK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x525DBD92514EA27;
        }
    }

    class ECM(ulong val) : ECL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x168DFF53B9D19E1;
        }
    }

    class ECN(ulong val) : ECM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A1B4682D9E0FDF;
        }
    }

    class ECO(ulong val) : ECN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7B80CA883D425FF;
        }
    }

    class ECP(ulong val) : ECO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x327F5CD593C40E2;
        }
    }

    class ECQ(ulong val) : ECP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x655888D1BEE933D;
        }
    }

    class ECR(ulong val) : ECQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77B3A5223DAEE1D;
        }
    }

    class ECS(ulong val) : ECR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x582C8B8266B5DDB;
        }
    }

    class ECT(ulong val) : ECS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x31C108F3B0DD732;
        }
    }

    class ECU(ulong val) : ECT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1489A3D966FF52A;
        }
    }

    class ECV(ulong val) : ECU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8231AA52C174259;
        }
    }

    class ECW(ulong val) : ECV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x651F371D2FD92B7;
        }
    }

    class ECX(ulong val) : ECW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1230E799744D841;
        }
    }

    class ECY(ulong val) : ECX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2AA3ECC393066AA;
        }
    }

    class ECZ(ulong val) : ECY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81D4D5199818667;
        }
    }

    class EDA(ulong val) : ECZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x93B831597054F84;
        }
    }

    class EDB(ulong val) : EDA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F4DD2043A92FA3;
        }
    }

    class EDC(ulong val) : EDB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D90CDB670A7AF7;
        }
    }

    class EDD(ulong val) : EDC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8B7E84BA4A7F005;
        }
    }

    class EDE(ulong val) : EDD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7458A307E0FFE6C;
        }
    }

    class EDF(ulong val) : EDE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F73A781FA0270C;
        }
    }

    class EDG(ulong val) : EDF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A04F7D0D44233F;
        }
    }

    class EDH(ulong val) : EDG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2846B90E4ED4769;
        }
    }

    class EDI(ulong val) : EDH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1957140D7E0D016;
        }
    }

    class EDJ(ulong val) : EDI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CF13F529C04FFF;
        }
    }

    class EDK(ulong val) : EDJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E6CC7031E73F13;
        }
    }

    class EDL(ulong val) : EDK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92E6B34F6116793;
        }
    }

    class EDM(ulong val) : EDL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x541C2856AEA0BEF;
        }
    }

    class EDN(ulong val) : EDM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x16C2CE9F4CD6676;
        }
    }

    class EDO(ulong val) : EDN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C65F6EFDBA9B91;
        }
    }

    class EDP(ulong val) : EDO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1DE7A9FE267B7E4;
        }
    }

    class EDQ(ulong val) : EDP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x608480F716293BC;
        }
    }

    class EDR(ulong val) : EDQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7587D1FA79CC71D;
        }
    }

    class EDS(ulong val) : EDR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x77809DB439A9850;
        }
    }

    class EDT(ulong val) : EDS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CB87C5B7BCF6CF;
        }
    }

    class EDU(ulong val) : EDT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35A4EAC184D47DC;
        }
    }

    class EDV(ulong val) : EDU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F1DE32B989BAC8;
        }
    }

    class EDW(ulong val) : EDV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D048F1658FA487;
        }
    }

    class EDX(ulong val) : EDW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x246A3D2F5507E00;
        }
    }

    class EDY(ulong val) : EDX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x394DD3DA609935A;
        }
    }

    class EDZ(ulong val) : EDY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x374DA0FBD42043F;
        }
    }

    class EEA(ulong val) : EDZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17FFAAAC3D8CBAD;
        }
    }

    class EEB(ulong val) : EEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39E8F3E3E9E8412;
        }
    }

    class EEC(ulong val) : EEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x259BCC0AC0CBCDF;
        }
    }

    class EED(ulong val) : EEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F41B7D0C5743AC;
        }
    }

    class EEE(ulong val) : EED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2B6F79DE172DFC5;
        }
    }

    class EEF(ulong val) : EEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8793A92123C715F;
        }
    }

    class EEG(ulong val) : EEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C56FFD0263A29C;
        }
    }

    class EEH(ulong val) : EEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56DD244136E1F8D;
        }
    }

    class EEI(ulong val) : EEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B5AA7EF5204C4A;
        }
    }

    class EEJ(ulong val) : EEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5AB56C190AA2F96;
        }
    }

    class EEK(ulong val) : EEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x65E1DA1ED420A34;
        }
    }

    class EEL(ulong val) : EEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x44C8AD20208C2D1;
        }
    }

    class EEM(ulong val) : EEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x798EA16D94B18C5;
        }
    }

    class EEN(ulong val) : EEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D41D0F4E9F1073;
        }
    }

    class EEO(ulong val) : EEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x784CCFF55736F75;
        }
    }

    class EEP(ulong val) : EEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6188B27F83FA5BC;
        }
    }

    class EEQ(ulong val) : EEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F30C9A599B9FE3;
        }
    }

    class EER(ulong val) : EEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7FC32B47CFF601C;
        }
    }

    class EES(ulong val) : EER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2506049843A933C;
        }
    }

    class EET(ulong val) : EES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B94B01E4E85967;
        }
    }

    class EEU(ulong val) : EET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D411DC192CF367;
        }
    }

    class EEV(ulong val) : EEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x167503DB7887448;
        }
    }

    class EEW(ulong val) : EEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x777C1014B80F222;
        }
    }

    class EEX(ulong val) : EEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x293BE2F66766515;
        }
    }

    class EEY(ulong val) : EEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x214D70B7DD5DF6A;
        }
    }

    class EEZ(ulong val) : EEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F8CEF994BE886B;
        }
    }

    class EFA(ulong val) : EEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52BFF7C3238D99C;
        }
    }

    class EFB(ulong val) : EFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7DE04FA8F723781;
        }
    }

    class EFC(ulong val) : EFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DC690C23A80620;
        }
    }

    class EFD(ulong val) : EFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3146ED930DFBE6A;
        }
    }

    class EFE(ulong val) : EFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x90C8B38B6A72DB4;
        }
    }

    class EFF(ulong val) : EFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DD06707BC14F8F;
        }
    }

    class EFG(ulong val) : EFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8C378303DEBB1AE;
        }
    }

    class EFH(ulong val) : EFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x44F6397A1AE3735;
        }
    }

    class EFI(ulong val) : EFH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x73054C7F52703E6;
        }
    }

    class EFJ(ulong val) : EFI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x865AB81185DA787;
        }
    }

    class EFK(ulong val) : EFJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x720AF3588F8F693;
        }
    }

    class EFL(ulong val) : EFK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x277BC4513739B34;
        }
    }

    class EFM(ulong val) : EFL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x127F0182FC97AAF;
        }
    }

    class EFN(ulong val) : EFM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E7FDAD13E95213;
        }
    }

    class EFO(ulong val) : EFN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x989593AC07DA57A;
        }
    }

    class EFP(ulong val) : EFO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x40397AC2E93FC2D;
        }
    }

    class EFQ(ulong val) : EFP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B16322C6C707EE;
        }
    }

    class EFR(ulong val) : EFQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C1BDCC88F7BC6E;
        }
    }

    class EFS(ulong val) : EFR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54416882D4CBE55;
        }
    }

    class EFT(ulong val) : EFS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x40B36967F28ACE6;
        }
    }

    class EFU(ulong val) : EFT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x407F8496C874BD1;
        }
    }

    class EFV(ulong val) : EFU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2B877701916F166;
        }
    }

    class EFW(ulong val) : EFV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1BEB38FC64F3479;
        }
    }

    class EFX(ulong val) : EFW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9365A0ECFE3CF17;
        }
    }

    class EFY(ulong val) : EFX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x758B9B0C5DE50B0;
        }
    }

    class EFZ(ulong val) : EFY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x69540EB0464FABB;
        }
    }

    class EGA(ulong val) : EFZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x52FB47DDC2BBBFA;
        }
    }

    class EGB(ulong val) : EGA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96278A0737023BD;
        }
    }

    class EGC(ulong val) : EGB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20461DBE40DEFC0;
        }
    }

    class EGD(ulong val) : EGC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x855E74ED4D00439;
        }
    }

    class EGE(ulong val) : EGD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x715372583932CF7;
        }
    }

    class EGF(ulong val) : EGE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6ED528DB8256FF7;
        }
    }

    class EGG(ulong val) : EGF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E73DFD942235BD;
        }
    }

    class EGH(ulong val) : EGG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x874414BD13ACA95;
        }
    }

    class EGI(ulong val) : EGH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85D55579B0FC08F;
        }
    }

    class EGJ(ulong val) : EGI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x43AA7114036183B;
        }
    }

    class EGK(ulong val) : EGJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x735728F4A0EED4D;
        }
    }

    class EGL(ulong val) : EGK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BD72E6B3F9156E;
        }
    }

    class EGM(ulong val) : EGL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7009BF1E112EFD7;
        }
    }

    class EGN(ulong val) : EGM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80A8561F90E445D;
        }
    }

    class EGO(ulong val) : EGN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x437AADD055F0E36;
        }
    }

    class EGP(ulong val) : EGO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8D2785D9C7ABD1B;
        }
    }

    class EGQ(ulong val) : EGP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9491EE21C33B0AE;
        }
    }

    class EGR(ulong val) : EGQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x217CB84273DC339;
        }
    }

    class EGS(ulong val) : EGR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80D8BB68668F6B3;
        }
    }

    class EGT(ulong val) : EGS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1AFD3D8A7F113B9;
        }
    }

    class EGU(ulong val) : EGT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E500A1D3EB236F;
        }
    }

    class EGV(ulong val) : EGU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x255E669CFDFD13C;
        }
    }

    class EGW(ulong val) : EGV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88712696A3134CB;
        }
    }

    class EGX(ulong val) : EGW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64761B9E1F81E43;
        }
    }

    class EGY(ulong val) : EGX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x790DD9CDA529C3C;
        }
    }

    class EGZ(ulong val) : EGY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4D6C48FB36F9234;
        }
    }

    class EHA(ulong val) : EGZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x225E6CB79B5D16A;
        }
    }

    class EHB(ulong val) : EHA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C7995433345383;
        }
    }

    class EHC(ulong val) : EHB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x559AE933259F1E1;
        }
    }

    class EHD(ulong val) : EHC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B6AC4E7D36D566;
        }
    }

    class EHE(ulong val) : EHD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x79431B3B9BA82CC;
        }
    }

    class EHF(ulong val) : EHE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9932857DA7B0C97;
        }
    }

    class EHG(ulong val) : EHF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x125FF03819EEFEB;
        }
    }

    class EHH(ulong val) : EHG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x373CF84C726634E;
        }
    }

    class EHI(ulong val) : EHH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A1FC7704FFEA6F;
        }
    }

    class EHJ(ulong val) : EHI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2DCB55B4EECAE62;
        }
    }

    class EHK(ulong val) : EHJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4DF903B57B441F0;
        }
    }

    class EHL(ulong val) : EHK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8995636CA0D2B0D;
        }
    }

    class EHM(ulong val) : EHL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2529BAB1162ED76;
        }
    }

    class EHN(ulong val) : EHM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x62AD01330AB43E3;
        }
    }

    class EHO(ulong val) : EHN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x852487E310E58A6;
        }
    }

    class EHP(ulong val) : EHO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FB4DB07425D0CF;
        }
    }

    class EHQ(ulong val) : EHP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3AFBE68CFD0E104;
        }
    }

    class EHR(ulong val) : EHQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56B18D9AB39E678;
        }
    }

    class EHS(ulong val) : EHR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x646891C5C8F1358;
        }
    }

    class EHT(ulong val) : EHS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11A6436E71D42D4;
        }
    }

    class EHU(ulong val) : EHT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8771A1AFB04B6BD;
        }
    }

    class EHV(ulong val) : EHU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E14EEEB72382CE;
        }
    }

    class EHW(ulong val) : EHV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2D378F9AA53487B;
        }
    }

    class EHX(ulong val) : EHW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x889A949E2917CBE;
        }
    }

    class EHY(ulong val) : EHX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x95DAF54605511D6;
        }
    }

    class EHZ(ulong val) : EHY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x978BBF9B4787B0D;
        }
    }

    class EIA(ulong val) : EHZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x902B0618DB3DF5B;
        }
    }

    class EIB(ulong val) : EIA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FC20D700363356;
        }
    }

    class EIC(ulong val) : EIB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BCB3FD35EC788B;
        }
    }

    class EID(ulong val) : EIC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3B60B0A28BE362E;
        }
    }

    class EIE(ulong val) : EID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93E7C841F2F47A4;
        }
    }

    class EIF(ulong val) : EIE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54EB95013AA08CE;
        }
    }

    class EIG(ulong val) : EIF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x380526550EE02C6;
        }
    }

    class EIH(ulong val) : EIG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4836DC3172A8730;
        }
    }

    class EII(ulong val) : EIH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11D94871F402112;
        }
    }

    class EIJ(ulong val) : EII(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8AC7AFA4B355A59;
        }
    }

    class EIK(ulong val) : EIJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35A317A0ED6D231;
        }
    }

    class EIL(ulong val) : EIK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x864E24176B5F2E4;
        }
    }

    class EIM(ulong val) : EIL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7CBFD75A882CA7F;
        }
    }

    class EIN(ulong val) : EIM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x97A7184D5F7F6CF;
        }
    }

    class EIO(ulong val) : EIN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x638D35E5AE8A98C;
        }
    }

    class EIP(ulong val) : EIO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A1F008D739F831;
        }
    }

    class EIQ(ulong val) : EIP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8ABF41E839C99CC;
        }
    }

    class EIR(ulong val) : EIQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8ED39E6A72BEF96;
        }
    }

    class EIS(ulong val) : EIR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x669A3F2AEEC94B2;
        }
    }

    class EIT(ulong val) : EIS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4FF7F70B73BC277;
        }
    }

    class EIU(ulong val) : EIT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6902A4E46B75FE8;
        }
    }

    class EIV(ulong val) : EIU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x915331DCDA7B670;
        }
    }

    class EIW(ulong val) : EIV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x22223877864FF81;
        }
    }

    class EIX(ulong val) : EIW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8A8E72BD64A9898;
        }
    }

    class EIY(ulong val) : EIX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x290C57464648E17;
        }
    }

    class EIZ(ulong val) : EIY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91DDF58D6BF8B40;
        }
    }

    class EJA(ulong val) : EIZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28A2E430EAC30F2;
        }
    }

    class EJB(ulong val) : EJA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x380475B74B2E6B4;
        }
    }

    class EJC(ulong val) : EJB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x484177B14DD331D;
        }
    }

    class EJD(ulong val) : EJC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39F5A7DE6E5AD7B;
        }
    }

    class EJE(ulong val) : EJD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5241C2FA11227DE;
        }
    }

    class EJF(ulong val) : EJE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x381366DF6F0C962;
        }
    }

    class EJG(ulong val) : EJF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x786B2BF7BFDB8C3;
        }
    }

    class EJH(ulong val) : EJG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3740AD1504E93BE;
        }
    }

    class EJI(ulong val) : EJH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54E76E43A19D885;
        }
    }

    class EJJ(ulong val) : EJI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B9793E3E7D9320;
        }
    }

    class EJK(ulong val) : EJJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x255534957F5F3C8;
        }
    }

    class EJL(ulong val) : EJK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A5D28975D5EFB6;
        }
    }

    class EJM(ulong val) : EJL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x12B26E5577EB119;
        }
    }

    class EJN(ulong val) : EJM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C2B1083F176AFE;
        }
    }

    class EJO(ulong val) : EJN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B365D578335C1A;
        }
    }

    class EJP(ulong val) : EJO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D39A81642E975E;
        }
    }

    class EJQ(ulong val) : EJP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4363A0133EB2CFD;
        }
    }

    class EJR(ulong val) : EJQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3B8372727B8B3A5;
        }
    }

    class EJS(ulong val) : EJR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x706ACA59784ACE7;
        }
    }

    class EJT(ulong val) : EJS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4254646F95F72D0;
        }
    }

    class EJU(ulong val) : EJT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A0D35306442001;
        }
    }

    class EJV(ulong val) : EJU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5B96E152BF97EC7;
        }
    }

    class EJW(ulong val) : EJV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1571CD93C4EC0CA;
        }
    }

    class EJX(ulong val) : EJW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x35C01239B31E27C;
        }
    }

    class EJY(ulong val) : EJX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x949BC6C13C09F5F;
        }
    }

    class EJZ(ulong val) : EJY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F5369B127BD606;
        }
    }

    class EKA(ulong val) : EJZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6BEE40FAE966451;
        }
    }

    class EKB(ulong val) : EKA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x44A48FFD3EBE964;
        }
    }

    class EKC(ulong val) : EKB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x72C3D99F71E6278;
        }
    }

    class EKD(ulong val) : EKC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56932B11BD66079;
        }
    }

    class EKE(ulong val) : EKD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x34F038B286F3B68;
        }
    }

    class EKF(ulong val) : EKE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D081C7B60427FB;
        }
    }

    class EKG(ulong val) : EKF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8E7C65ACFCA0F0A;
        }
    }

    class EKH(ulong val) : EKG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A8163273E0C7B9;
        }
    }

    class EKI(ulong val) : EKH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B66A01D78FC407;
        }
    }

    class EKJ(ulong val) : EKI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x618634E8294E016;
        }
    }

    class EKK(ulong val) : EKJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C34EFDC87A97AE;
        }
    }

    class EKL(ulong val) : EKK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5EBAC2B5030E034;
        }
    }

    class EKM(ulong val) : EKL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46B7ADEE070923C;
        }
    }

    class EKN(ulong val) : EKM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x94CF89D113AA1C2;
        }
    }

    class EKO(ulong val) : EKN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8ADDFA78DF14EFC;
        }
    }

    class EKP(ulong val) : EKO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x556AA827A4B22CF;
        }
    }

    class EKQ(ulong val) : EKP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3BC147F6BF07313;
        }
    }

    class EKR(ulong val) : EKQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93101F585198230;
        }
    }

    class EKS(ulong val) : EKR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4258A62A2E6FA24;
        }
    }

    class EKT(ulong val) : EKS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57BEBAEC849885A;
        }
    }

    class EKU(ulong val) : EKT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x996AE7E660DBFE5;
        }
    }

    class EKV(ulong val) : EKU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x155EF2DF0267E3F;
        }
    }

    class EKW(ulong val) : EKV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17B562113C2EE56;
        }
    }

    class EKX(ulong val) : EKW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B3AD8615533F65;
        }
    }

    class EKY(ulong val) : EKX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63DD410881457F6;
        }
    }

    class EKZ(ulong val) : EKY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2853263D504AF6C;
        }
    }

    class ELA(ulong val) : EKZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x87D1F33F63EF310;
        }
    }

    class ELB(ulong val) : ELA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7235F69522A8438;
        }
    }

    class ELC(ulong val) : ELB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B3E745086F6184;
        }
    }

    class ELD(ulong val) : ELC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x627050165C96415;
        }
    }

    class ELE(ulong val) : ELD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49012A9264A720E;
        }
    }

    class ELF(ulong val) : ELE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6C19B7F807CA90F;
        }
    }

    class ELG(ulong val) : ELF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x535A30AB9A2A78E;
        }
    }

    class ELH(ulong val) : ELG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57152DBF547AADD;
        }
    }

    class ELI(ulong val) : ELH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62538E0B03217FC;
        }
    }

    class ELJ(ulong val) : ELI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5ADFC3DFA0F3542;
        }
    }

    class ELK(ulong val) : ELJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4ACD2D37564F305;
        }
    }

    class ELL(ulong val) : ELK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x564E4E8B84A67EF;
        }
    }

    class ELM(ulong val) : ELL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x40F7E6C07389891;
        }
    }

    class ELN(ulong val) : ELM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8AAC349E8806BB4;
        }
    }

    class ELO(ulong val) : ELN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C71E4E9C90313E;
        }
    }

    class ELP(ulong val) : ELO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x75F2B2D557A0FE4;
        }
    }

    class ELQ(ulong val) : ELP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6016B1CE382510C;
        }
    }

    class ELR(ulong val) : ELQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9622EC9E6766092;
        }
    }

    class ELS(ulong val) : ELR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3DF4FD5B6EE27DA;
        }
    }

    class ELT(ulong val) : ELS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5DAFADE2252F91A;
        }
    }

    class ELU(ulong val) : ELT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2B0A3A273C7B75A;
        }
    }

    class ELV(ulong val) : ELU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F3A2C575459CAA;
        }
    }

    class ELW(ulong val) : ELV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58C46A9C73EF608;
        }
    }

    class ELX(ulong val) : ELW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2455AC7AE916211;
        }
    }

    class ELY(ulong val) : ELX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39C49511157FE57;
        }
    }

    class ELZ(ulong val) : ELY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70B42F2A6291D6C;
        }
    }

    class EMA(ulong val) : ELZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7196AEAA3F73CF2;
        }
    }

    class EMB(ulong val) : EMA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A1D1F43B915AC6;
        }
    }

    class EMC(ulong val) : EMB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x534A0A2968C7F4C;
        }
    }

    class EMD(ulong val) : EMC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8CFD9AE7B747062;
        }
    }

    class EME(ulong val) : EMD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B353C1468A1369;
        }
    }

    class EMF(ulong val) : EME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CA64611A339958;
        }
    }

    class EMG(ulong val) : EMF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E44B23191B4D0C;
        }
    }

    class EMH(ulong val) : EMG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D89D2F73F352D9;
        }
    }

    class EMI(ulong val) : EMH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x131E93B81722032;
        }
    }

    class EMJ(ulong val) : EMI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2AF579543A66973;
        }
    }

    class EMK(ulong val) : EMJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B0C741EC377AEA;
        }
    }

    class EML(ulong val) : EMK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A043AB53B3AC6C;
        }
    }

    class EMM(ulong val) : EML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x66DAB8C2181A2A4;
        }
    }

    class EMN(ulong val) : EMM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E27A3693FD52F0;
        }
    }

    class EMO(ulong val) : EMN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1818E4E0E1FF530;
        }
    }

    class EMP(ulong val) : EMO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61F1009E882FE69;
        }
    }

    class EMQ(ulong val) : EMP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24C8DC852B6E041;
        }
    }

    class EMR(ulong val) : EMQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x76EE5AD7DABF10D;
        }
    }

    class EMS(ulong val) : EMR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B0A323759DC9B2;
        }
    }

    class EMT(ulong val) : EMS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C49A774D1A05C7;
        }
    }

    class EMU(ulong val) : EMT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E3C8543BCC9D3F;
        }
    }

    class EMV(ulong val) : EMU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x553D8A3867B8DB9;
        }
    }

    class EMW(ulong val) : EMV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4941B0BC0D331B4;
        }
    }

    class EMX(ulong val) : EMW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16E0C8FB730B9E8;
        }
    }

    class EMY(ulong val) : EMX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4A64FC389D15EF9;
        }
    }

    class EMZ(ulong val) : EMY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x58F9722E1F8407D;
        }
    }

    class ENA(ulong val) : EMZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x669E876F4890D21;
        }
    }

    class ENB(ulong val) : ENA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D32749B6C7F035;
        }
    }

    class ENC(ulong val) : ENB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x94942D6DD74D638;
        }
    }

    class END(ulong val) : ENC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x68B01B72B20838B;
        }
    }

    class ENE(ulong val) : END(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98077BA0E3F4D76;
        }
    }

    class ENF(ulong val) : ENE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9462C96E40885B1;
        }
    }

    class ENG(ulong val) : ENF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C1579566AB8A63;
        }
    }

    class ENH(ulong val) : ENG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7531AA92EF1B943;
        }
    }

    class ENI(ulong val) : ENH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2B2D74C4D38DC9D;
        }
    }

    class ENJ(ulong val) : ENI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92605D9A056A028;
        }
    }

    class ENK(ulong val) : ENJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D0C2766DB5B16B;
        }
    }

    class ENL(ulong val) : ENK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E7BAACFE355D61;
        }
    }

    class ENM(ulong val) : ENL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x129A1A3C89F6478;
        }
    }

    class ENN(ulong val) : ENM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9762B5A329C20F5;
        }
    }

    class ENO(ulong val) : ENN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49AEA9DD1990C34;
        }
    }

    class ENP(ulong val) : ENO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B6FC3F131F9E37;
        }
    }

    class ENQ(ulong val) : ENP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1ED7E87C078D07E;
        }
    }

    class ENR(ulong val) : ENQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2015DD42EF77B34;
        }
    }

    class ENS(ulong val) : ENR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x26BCCBAAEE99A26;
        }
    }

    class ENT(ulong val) : ENS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x58F7287668C1AAC;
        }
    }

    class ENU(ulong val) : ENT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19EFB7C218961AE;
        }
    }

    class ENV(ulong val) : ENU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6FE4E4E9EA26D57;
        }
    }

    class ENW(ulong val) : ENV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3DBE73EF6F8690E;
        }
    }

    class ENX(ulong val) : ENW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4E8E58F3A584CD4;
        }
    }

    class ENY(ulong val) : ENX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x51655CD281CB1B2;
        }
    }

    class ENZ(ulong val) : ENY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x783D937E77AF309;
        }
    }

    class EOA(ulong val) : ENZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17DB6CEBAA2C520;
        }
    }

    class EOB(ulong val) : EOA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x31BFAF680887E3A;
        }
    }

    class EOC(ulong val) : EOB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C182B53519F070;
        }
    }

    class EOD(ulong val) : EOC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x230E7041C7A6DEC;
        }
    }

    class EOE(ulong val) : EOD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6222DB135F72490;
        }
    }

    class EOF(ulong val) : EOE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85533A0DFBA5E82;
        }
    }

    class EOG(ulong val) : EOF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E0AB80494DD0F3;
        }
    }

    class EOH(ulong val) : EOG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x756D9128E04B2D0;
        }
    }

    class EOI(ulong val) : EOH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x995FE6054041856;
        }
    }

    class EOJ(ulong val) : EOI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E446E41E6D7E3A;
        }
    }

    class EOK(ulong val) : EOJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27277205F847A80;
        }
    }

    class EOL(ulong val) : EOK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1BC6EDDD6118E2C;
        }
    }

    class EOM(ulong val) : EOL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x311140020516FB8;
        }
    }

    class EON(ulong val) : EOM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E4539C1799938D;
        }
    }

    class EOO(ulong val) : EON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52BBCC5D85E7D33;
        }
    }

    class EOP(ulong val) : EOO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x175CDCD4866DDB4;
        }
    }

    class EOQ(ulong val) : EOP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E8ED69DD90E3FA;
        }
    }

    class EOR(ulong val) : EOQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x333D7542616B3B3;
        }
    }

    class EOS(ulong val) : EOR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1684E18FA4F9C46;
        }
    }

    class EOT(ulong val) : EOS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x65DA4150ADC1224;
        }
    }

    class EOU(ulong val) : EOT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46CAFA6FD123F91;
        }
    }

    class EOV(ulong val) : EOU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96BA187CD2C72C3;
        }
    }

    class EOW(ulong val) : EOV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x73A57C4CE1CD5CA;
        }
    }

    class EOX(ulong val) : EOW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11F2C8E79DEFC89;
        }
    }

    class EOY(ulong val) : EOX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24C9236FEE4671B;
        }
    }

    class EOZ(ulong val) : EOY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17001F911517CBD;
        }
    }

    class EPA(ulong val) : EOZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x166163C7CE9B8D0;
        }
    }

    class EPB(ulong val) : EPA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C2D4354C091B11;
        }
    }

    class EPC(ulong val) : EPB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7EB537B10304F13;
        }
    }

    class EPD(ulong val) : EPC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4554C900072DA73;
        }
    }

    class EPE(ulong val) : EPD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62AA175BD963E07;
        }
    }

    class EPF(ulong val) : EPE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x81D57FD71728405;
        }
    }

    class EPG(ulong val) : EPF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x68200690CDFED27;
        }
    }

    class EPH(ulong val) : EPG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x990E30445797E01;
        }
    }

    class EPI(ulong val) : EPH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2025E4EE20BD9C3;
        }
    }

    class EPJ(ulong val) : EPI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F0709C841B05E6;
        }
    }

    class EPK(ulong val) : EPJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x987AC500A82977F;
        }
    }

    class EPL(ulong val) : EPK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56381D7B27FBD7E;
        }
    }

    class EPM(ulong val) : EPL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A6EEEDC2914E0F;
        }
    }

    class EPN(ulong val) : EPM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B1ED4D6E6B0FB0;
        }
    }

    class EPO(ulong val) : EPN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E1C3E6DDD79715;
        }
    }

    class EPP(ulong val) : EPO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D8592084E88BAC;
        }
    }

    class EPQ(ulong val) : EPP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x73BF928B4C6A43A;
        }
    }

    class EPR(ulong val) : EPQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D39EDB59C5C3D5;
        }
    }

    class EPS(ulong val) : EPR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7838D1662B4492E;
        }
    }

    class EPT(ulong val) : EPS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1C8A0D6C409BAAB;
        }
    }

    class EPU(ulong val) : EPT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x726F5E881F45C32;
        }
    }

    class EPV(ulong val) : EPU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6F9FCA4FDF1B010;
        }
    }

    class EPW(ulong val) : EPV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64D2AFFE87EE1A7;
        }
    }

    class EPX(ulong val) : EPW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2432881105A4270;
        }
    }

    class EPY(ulong val) : EPX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x67A94F178F9E09B;
        }
    }

    class EPZ(ulong val) : EPY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86E8436A14D52F5;
        }
    }

    class EQA(ulong val) : EPZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x187F662B07CBF6E;
        }
    }

    class EQB(ulong val) : EQA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1AAE51E29DF5883;
        }
    }

    class EQC(ulong val) : EQB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5B93F13A2C2ABF3;
        }
    }

    class EQD(ulong val) : EQC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45ACDF890B0D298;
        }
    }

    class EQE(ulong val) : EQD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CB8D32A7B3E39D;
        }
    }

    class EQF(ulong val) : EQE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3091B77FC741B52;
        }
    }

    class EQG(ulong val) : EQF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39BA4DB3B686719;
        }
    }

    class EQH(ulong val) : EQG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x680A75E2725371B;
        }
    }

    class EQI(ulong val) : EQH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x37EAFB56780AEF4;
        }
    }

    class EQJ(ulong val) : EQI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x10300C09C9CFBFE;
        }
    }

    class EQK(ulong val) : EQJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7DE4D9714AE59F3;
        }
    }

    class EQL(ulong val) : EQK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x68DC6BB5CB92E8B;
        }
    }

    class EQM(ulong val) : EQL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4620455399372B3;
        }
    }

    class EQN(ulong val) : EQM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x826ED8A609BC356;
        }
    }

    class EQO(ulong val) : EQN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F9F1A15BB60F23;
        }
    }

    class EQP(ulong val) : EQO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4AEA0D3055F5C98;
        }
    }

    class EQQ(ulong val) : EQP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A743233AD453CB;
        }
    }

    class EQR(ulong val) : EQQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x520B89868735316;
        }
    }

    class EQS(ulong val) : EQR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x37B7585CD389D9B;
        }
    }

    class EQT(ulong val) : EQS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x81CCB0AB97C748F;
        }
    }

    class EQU(ulong val) : EQT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x613A2671916FD62;
        }
    }

    class EQV(ulong val) : EQU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x554424960878742;
        }
    }

    class EQW(ulong val) : EQV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D15C232B6F84CC;
        }
    }

    class EQX(ulong val) : EQW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x74F93D02D0442CC;
        }
    }

    class EQY(ulong val) : EQX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74DC60001FC1145;
        }
    }

    class EQZ(ulong val) : EQY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B331DB1B2C052B;
        }
    }

    class ERA(ulong val) : EQZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x54197EED41296CD;
        }
    }

    class ERB(ulong val) : ERA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x684E914CDB02FAD;
        }
    }

    class ERC(ulong val) : ERB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x227674C9DCB4376;
        }
    }

    class ERD(ulong val) : ERC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88DA9E5D51510B2;
        }
    }

    class ERE(ulong val) : ERD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6D21ADD7FFE7F07;
        }
    }

    class ERF(ulong val) : ERE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x995945015DF2619;
        }
    }

    class ERG(ulong val) : ERF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x264BD9913948E52;
        }
    }

    class ERH(ulong val) : ERG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D45F299BD089A4;
        }
    }

    class ERI(ulong val) : ERH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2719E6AD5CFCD63;
        }
    }

    class ERJ(ulong val) : ERI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x916344C37C91532;
        }
    }

    class ERK(ulong val) : ERJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E2187C57B81C2E;
        }
    }

    class ERL(ulong val) : ERK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6815FA6C95954B7;
        }
    }

    class ERM(ulong val) : ERL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7CDAD9184384D99;
        }
    }

    class ERN(ulong val) : ERM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x255EFBB10C11553;
        }
    }

    class ERO(ulong val) : ERN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x409F24958EB2B8F;
        }
    }

    class ERP(ulong val) : ERO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86A17E615FA6A7F;
        }
    }

    class ERQ(ulong val) : ERP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4380B7173FCB3BD;
        }
    }

    class ERR(ulong val) : ERQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86BE3DA36A424E5;
        }
    }

    class ERS(ulong val) : ERR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11FAE3F3BF90261;
        }
    }

    class ERT(ulong val) : ERS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2D053B52865757B;
        }
    }

    class ERU(ulong val) : ERT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86DAD0050E78B21;
        }
    }

    class ERV(ulong val) : ERU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4485925388DDE61;
        }
    }

    class ERW(ulong val) : ERV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CA0218E0F1D69E;
        }
    }

    class ERX(ulong val) : ERW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x89A3335FED6ECAA;
        }
    }

    class ERY(ulong val) : ERX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x19E32A3FBDAE940;
        }
    }

    class ERZ(ulong val) : ERY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x305955410AB61D6;
        }
    }

    class ESA(ulong val) : ERZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x728CE7490A50BC9;
        }
    }

    class ESB(ulong val) : ESA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x91BAC9672C6B1FE;
        }
    }

    class ESC(ulong val) : ESB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2608844D4069439;
        }
    }

    class ESD(ulong val) : ESC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2F9968B46391556;
        }
    }

    class ESE(ulong val) : ESD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x24CFE790F12E45A;
        }
    }

    class ESF(ulong val) : ESE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5F1EEFEAFB5348A;
        }
    }

    class ESG(ulong val) : ESF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x582F18C1CB7C7FE;
        }
    }

    class ESH(ulong val) : ESG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x518925BCC6CDFBB;
        }
    }

    class ESI(ulong val) : ESH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6409E49425C0447;
        }
    }

    class ESJ(ulong val) : ESI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85F5796C0D30B48;
        }
    }

    class ESK(ulong val) : ESJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7ABBFF81187A195;
        }
    }

    class ESL(ulong val) : ESK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E1CC484B812B8F;
        }
    }

    class ESM(ulong val) : ESL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x603B4C5E91325E6;
        }
    }

    class ESN(ulong val) : ESM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6E2B6106F2CE13E;
        }
    }

    class ESO(ulong val) : ESN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77F99965CD5DB73;
        }
    }

    class ESP(ulong val) : ESO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CD3875730EADD9;
        }
    }

    class ESQ(ulong val) : ESP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F8C043C6D4A4C0;
        }
    }

    class ESR(ulong val) : ESQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x166BBAAA372379D;
        }
    }

    class ESS(ulong val) : ESR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5449AAF58118385;
        }
    }

    class EST(ulong val) : ESS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8EBDF6F7FF7316A;
        }
    }

    class ESU(ulong val) : EST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x324C53193463F5D;
        }
    }

    class ESV(ulong val) : ESU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80CC0B3B3AB3E4C;
        }
    }

    class ESW(ulong val) : ESV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5AC58601F5B23BC;
        }
    }

    class ESX(ulong val) : ESW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x24141676B7C4036;
        }
    }

    class ESY(ulong val) : ESX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x69CAB1109CEA1E9;
        }
    }

    class ESZ(ulong val) : ESY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6AC0CD7CB07F48A;
        }
    }

    class ETA(ulong val) : ESZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5A8307AE4BA52AD;
        }
    }

    class ETB(ulong val) : ETA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96DC9E48C60D446;
        }
    }

    class ETC(ulong val) : ETB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x835F7F671121405;
        }
    }

    class ETD(ulong val) : ETC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57000CA96A1A300;
        }
    }

    class ETE(ulong val) : ETD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C8AED4619C23D1;
        }
    }

    class ETF(ulong val) : ETE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x588BD8AA3DBCAB6;
        }
    }

    class ETG(ulong val) : ETF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2179CE1C08055A6;
        }
    }

    class ETH(ulong val) : ETG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3981346DB518302;
        }
    }

    class ETI(ulong val) : ETH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C3F1ED71C18180;
        }
    }

    class ETJ(ulong val) : ETI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x381564205E5E171;
        }
    }

    class ETK(ulong val) : ETJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B1A28D672CC0E7;
        }
    }

    class ETL(ulong val) : ETK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79D31115C07B990;
        }
    }

    class ETM(ulong val) : ETL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x992111B0882C05A;
        }
    }

    class ETN(ulong val) : ETM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49B72EF201F70AA;
        }
    }

    class ETO(ulong val) : ETN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x899794CF2E0A6B3;
        }
    }

    class ETP(ulong val) : ETO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4853082D2276596;
        }
    }

    class ETQ(ulong val) : ETP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7ABA43249521160;
        }
    }

    class ETR(ulong val) : ETQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x919162FC248452B;
        }
    }

    class ETS(ulong val) : ETR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x35BD0C4F038134D;
        }
    }

    class ETT(ulong val) : ETS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8B0D54A7D9C664C;
        }
    }

    class ETU(ulong val) : ETT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61E2989E5CD6D87;
        }
    }

    class ETV(ulong val) : ETU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x637C11DED9D8A9A;
        }
    }

    class ETW(ulong val) : ETV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1EEADB5AC47E141;
        }
    }

    class ETX(ulong val) : ETW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F8D4A1B99AD1F0;
        }
    }

    class ETY(ulong val) : ETX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x618ADFA8451EF05;
        }
    }

    class ETZ(ulong val) : ETY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x372E5717FE633E3;
        }
    }

    class EUA(ulong val) : ETZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D40D0F32C6439D;
        }
    }

    class EUB(ulong val) : EUA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5197A6ED64493F7;
        }
    }

    class EUC(ulong val) : EUB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2F13C6EE0C648BA;
        }
    }

    class EUD(ulong val) : EUC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x29D031D09FB1DBB;
        }
    }

    class EUE(ulong val) : EUD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D2629C62B46E1E;
        }
    }

    class EUF(ulong val) : EUE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x60E336066B444A7;
        }
    }

    class EUG(ulong val) : EUF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x385F0A9701D3089;
        }
    }

    class EUH(ulong val) : EUG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89C0F364375A8CF;
        }
    }

    class EUI(ulong val) : EUH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x97DE5AC8328FE92;
        }
    }

    class EUJ(ulong val) : EUI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1215FE471EF4064;
        }
    }

    class EUK(ulong val) : EUJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x693149D51CA98E5;
        }
    }

    class EUL(ulong val) : EUK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6D0B2B4A35F64CE;
        }
    }

    class EUM(ulong val) : EUL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FD5684CA890B87;
        }
    }

    class EUN(ulong val) : EUM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x872AD1225560F07;
        }
    }

    class EUO(ulong val) : EUN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x820653BCD568A80;
        }
    }

    class EUP(ulong val) : EUO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x32342B336CE8A40;
        }
    }

    class EUQ(ulong val) : EUP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48BA6FC34E2C6CF;
        }
    }

    class EUR(ulong val) : EUQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x707D8013717A076;
        }
    }

    class EUS(ulong val) : EUR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5FA49FE6782C523;
        }
    }

    class EUT(ulong val) : EUS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DC23877CDA6822;
        }
    }

    class EUU(ulong val) : EUT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5809F63DC292281;
        }
    }

    class EUV(ulong val) : EUU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x59A81380416442C;
        }
    }

    class EUW(ulong val) : EUV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x855613E0889A948;
        }
    }

    class EUX(ulong val) : EUW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1CA8A6F9FEC70BF;
        }
    }

    class EUY(ulong val) : EUX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2254540CDC7416F;
        }
    }

    class EUZ(ulong val) : EUY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6E07270DA587590;
        }
    }

    class EVA(ulong val) : EUZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A76EE57D7A3E04;
        }
    }

    class EVB(ulong val) : EVA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x816741D81390C05;
        }
    }

    class EVC(ulong val) : EVB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BCFE6127877551;
        }
    }

    class EVD(ulong val) : EVC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x84CF1B1808D8C6E;
        }
    }

    class EVE(ulong val) : EVD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4AE13C32EADBFA5;
        }
    }

    class EVF(ulong val) : EVE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x384D87AC79D6DCF;
        }
    }

    class EVG(ulong val) : EVF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9901844F7A37D07;
        }
    }

    class EVH(ulong val) : EVG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x864B8E012884F46;
        }
    }

    class EVI(ulong val) : EVH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DD7433BD2E63BE;
        }
    }

    class EVJ(ulong val) : EVI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A52610B48073E5;
        }
    }

    class EVK(ulong val) : EVJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5B1E2E4F6A336D1;
        }
    }

    class EVL(ulong val) : EVK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15477EEB20705FA;
        }
    }

    class EVM(ulong val) : EVL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x83E43351CAEDCE9;
        }
    }

    class EVN(ulong val) : EVM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6DF30B5696DEA48;
        }
    }

    class EVO(ulong val) : EVN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15F161E214076C3;
        }
    }

    class EVP(ulong val) : EVO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x58CDF52CBAC3BF8;
        }
    }

    class EVQ(ulong val) : EVP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D57D488D119646;
        }
    }

    class EVR(ulong val) : EVQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x45ACB66AB113BEA;
        }
    }

    class EVS(ulong val) : EVR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1ADA74929B28820;
        }
    }

    class EVT(ulong val) : EVS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4CEAF05275DD42F;
        }
    }

    class EVU(ulong val) : EVT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x83BDE3A60D0DB9E;
        }
    }

    class EVV(ulong val) : EVU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E5D082703A3C4F;
        }
    }

    class EVW(ulong val) : EVV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x31215D6129D5AAE;
        }
    }

    class EVX(ulong val) : EVW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x918A3A1800B5629;
        }
    }

    class EVY(ulong val) : EVX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35632FCB2179D79;
        }
    }

    class EVZ(ulong val) : EVY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8AF9813AB2A6ED7;
        }
    }

    class EWA(ulong val) : EVZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x430DE535EFE67CE;
        }
    }

    class EWB(ulong val) : EWA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5527499DD51F620;
        }
    }

    class EWC(ulong val) : EWB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5929F6E29EB2CF6;
        }
    }

    class EWD(ulong val) : EWC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3979E97E43BDBCD;
        }
    }

    class EWE(ulong val) : EWD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x21F6D635CD6827E;
        }
    }

    class EWF(ulong val) : EWE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E3E0D0EDF516BD;
        }
    }

    class EWG(ulong val) : EWF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2395E40C05EEE42;
        }
    }

    class EWH(ulong val) : EWG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F24DCAB48E0FC3;
        }
    }

    class EWI(ulong val) : EWH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4AFC3838BC8ED79;
        }
    }

    class EWJ(ulong val) : EWI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x736D19BC01AA237;
        }
    }

    class EWK(ulong val) : EWJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7B0EB67441C08E9;
        }
    }

    class EWL(ulong val) : EWK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C82302D6BEA4DF;
        }
    }

    class EWM(ulong val) : EWL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x682A0725EFA8A1D;
        }
    }

    class EWN(ulong val) : EWM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4667602FF86E071;
        }
    }

    class EWO(ulong val) : EWN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x80F5C29EE3F5870;
        }
    }

    class EWP(ulong val) : EWO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x295F0266932AF4C;
        }
    }

    class EWQ(ulong val) : EWP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6F76357DE4BB081;
        }
    }

    class EWR(ulong val) : EWQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7EA3CF068E5C8E8;
        }
    }

    class EWS(ulong val) : EWR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8283AFE5E1455AC;
        }
    }

    class EWT(ulong val) : EWS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48674661CDF0AF2;
        }
    }

    class EWU(ulong val) : EWT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x59721C39F593BA1;
        }
    }

    class EWV(ulong val) : EWU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5A24FE910443D23;
        }
    }

    class EWW(ulong val) : EWV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x863E1C190371F32;
        }
    }

    class EWX(ulong val) : EWW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24657C4E913E27E;
        }
    }

    class EWY(ulong val) : EWX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A95CA159AC07CA;
        }
    }

    class EWZ(ulong val) : EWY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73AD694B6CDF9FF;
        }
    }

    class EXA(ulong val) : EWZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x44D23C8F7625ECA;
        }
    }

    class EXB(ulong val) : EXA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5D3ADD4E23F36B6;
        }
    }

    class EXC(ulong val) : EXB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68077F9A8E18BDF;
        }
    }

    class EXD(ulong val) : EXC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x858B58F4BAB40DE;
        }
    }

    class EXE(ulong val) : EXD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7EE952D0E820B12;
        }
    }

    class EXF(ulong val) : EXE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x373A357315ABDAD;
        }
    }

    class EXG(ulong val) : EXF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x101EDF08165E749;
        }
    }

    class EXH(ulong val) : EXG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x383675E5E6B555D;
        }
    }

    class EXI(ulong val) : EXH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1D57698A05DDDC1;
        }
    }

    class EXJ(ulong val) : EXI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1B432E13572EF98;
        }
    }

    class EXK(ulong val) : EXJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x40BA051B6044FD0;
        }
    }

    class EXL(ulong val) : EXK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x67B0DD84160B1DB;
        }
    }

    class EXM(ulong val) : EXL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63F3503B06A431F;
        }
    }

    class EXN(ulong val) : EXM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4BF4D4421A3069A;
        }
    }

    class EXO(ulong val) : EXN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x909A89BF7263574;
        }
    }

    class EXP(ulong val) : EXO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3804FA3B594D49B;
        }
    }

    class EXQ(ulong val) : EXP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x990D1D31A9B57FD;
        }
    }

    class EXR(ulong val) : EXQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D1C123D25E884E;
        }
    }

    class EXS(ulong val) : EXR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x54FDC7F0D89F6B5;
        }
    }

    class EXT(ulong val) : EXS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4BC458FB9993C5D;
        }
    }

    class EXU(ulong val) : EXT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B675C920F704EC;
        }
    }

    class EXV(ulong val) : EXU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B6A5A28D7638D4;
        }
    }

    class EXW(ulong val) : EXV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x549724154C4EA56;
        }
    }

    class EXX(ulong val) : EXW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7FC483D9EC0F83C;
        }
    }

    class EXY(ulong val) : EXX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x265718903433C22;
        }
    }

    class EXZ(ulong val) : EXY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11B0D34CC9E8CE2;
        }
    }

    class EYA(ulong val) : EXZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x52C50809B343AF8;
        }
    }

    class EYB(ulong val) : EYA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25C758079B83490;
        }
    }

    class EYC(ulong val) : EYB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x18686743AE74850;
        }
    }

    class EYD(ulong val) : EYC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5DF4958ADA0C03F;
        }
    }

    class EYE(ulong val) : EYD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x901C59D2F954690;
        }
    }

    class EYF(ulong val) : EYE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x30AB97E82005DAD;
        }
    }

    class EYG(ulong val) : EYF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7CE1C0F737A3A54;
        }
    }

    class EYH(ulong val) : EYG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7D941D396DE01A3;
        }
    }

    class EYI(ulong val) : EYH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A987142D5B0210;
        }
    }

    class EYJ(ulong val) : EYI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80FC6EE14B398B7;
        }
    }

    class EYK(ulong val) : EYJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8BAE2B338D2564F;
        }
    }

    class EYL(ulong val) : EYK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FDF7797E28F0F7;
        }
    }

    class EYM(ulong val) : EYL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x874D2A0B41287C6;
        }
    }

    class EYN(ulong val) : EYM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63F9DA542963A8F;
        }
    }

    class EYO(ulong val) : EYN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x154B560525275B2;
        }
    }

    class EYP(ulong val) : EYO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5FBB34BC89657E2;
        }
    }

    class EYQ(ulong val) : EYP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x290F0C84BAF68BC;
        }
    }

    class EYR(ulong val) : EYQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x25DF3A4E1BE382E;
        }
    }

    class EYS(ulong val) : EYR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F207E26B423D43;
        }
    }

    class EYT(ulong val) : EYS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x494456174CD31EF;
        }
    }

    class EYU(ulong val) : EYT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A8DE3ACD0AB5C6;
        }
    }

    class EYV(ulong val) : EYU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x435C35E299BDEA1;
        }
    }

    class EYW(ulong val) : EYV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8B77ED22D91A99A;
        }
    }

    class EYX(ulong val) : EYW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C4757871AF63F9;
        }
    }

    class EYY(ulong val) : EYX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x42D43F913E6F840;
        }
    }

    class EYZ(ulong val) : EYY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26D5858149778C1;
        }
    }

    class EZA(ulong val) : EYZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6BD5EEB0AFA58FF;
        }
    }

    class EZB(ulong val) : EZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8F5ED8E172DA083;
        }
    }

    class EZC(ulong val) : EZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28B9016FFA7E81E;
        }
    }

    class EZD(ulong val) : EZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x621B01CA0B54A3A;
        }
    }

    class EZE(ulong val) : EZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5363C8F1FEE0238;
        }
    }

    class EZF(ulong val) : EZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BF643BF669FC70;
        }
    }

    class EZG(ulong val) : EZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x607EB14D75F6B1B;
        }
    }

    class EZH(ulong val) : EZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2EB54169B25FD10;
        }
    }

    class EZI(ulong val) : EZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A743F307CC1A4B;
        }
    }

    class EZJ(ulong val) : EZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E4F377C9A0F61F;
        }
    }

    class EZK(ulong val) : EZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x538F1964DCAC3EE;
        }
    }

    class EZL(ulong val) : EZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x15C74FC6F8BB91B;
        }
    }

    class EZM(ulong val) : EZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62F3C122DF54961;
        }
    }

    class EZN(ulong val) : EZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2390B9865CF606D;
        }
    }

    class EZO(ulong val) : EZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x25A093BD0184459;
        }
    }

    class EZP(ulong val) : EZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50458A327B69AEA;
        }
    }

    class EZQ(ulong val) : EZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1429EC34E8DD115;
        }
    }

    class EZR(ulong val) : EZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47206DD24DBCE99;
        }
    }

    class EZS(ulong val) : EZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8034E717F896F8B;
        }
    }

    class EZT(ulong val) : EZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2215633BBECAC1A;
        }
    }

    class EZU(ulong val) : EZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3815873B2C98398;
        }
    }

    class EZV(ulong val) : EZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x697BE3BACD0CDE9;
        }
    }

    class EZW(ulong val) : EZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x147C921E510644E;
        }
    }

    class EZX(ulong val) : EZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6716C1FE3FBA400;
        }
    }

    class EZY(ulong val) : EZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5240DDA97FCE5B6;
        }
    }

    class EZZ(ulong val) : EZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x22CF02A4F5D2EEC;
        }
    }

    class FAA(ulong val) : EZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x62800B0D7F416CA;
        }
    }

    class FAB(ulong val) : FAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26A0009881CD407;
        }
    }

    class FAC(ulong val) : FAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1EAF25A5D815121;
        }
    }

    class FAD(ulong val) : FAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B41E036C3976A7;
        }
    }

    class FAE(ulong val) : FAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F0A35E0DAB5FDB;
        }
    }

    class FAF(ulong val) : FAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8A386684F3D181C;
        }
    }

    class FAG(ulong val) : FAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95C26AC2F8F3E0E;
        }
    }

    class FAH(ulong val) : FAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x45C14359D1435DA;
        }
    }

    class FAI(ulong val) : FAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1ADD36F560C29FC;
        }
    }

    class FAJ(ulong val) : FAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15EFD3E930EB927;
        }
    }

    class FAK(ulong val) : FAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7C5522BAB24FF97;
        }
    }

    class FAL(ulong val) : FAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D085AA44EBFDE2;
        }
    }

    class FAM(ulong val) : FAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A1BD330524160B;
        }
    }

    class FAN(ulong val) : FAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2210E553D399DE4;
        }
    }

    class FAO(ulong val) : FAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56BB8C67D68C021;
        }
    }

    class FAP(ulong val) : FAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x53F89EBFDE50C8B;
        }
    }

    class FAQ(ulong val) : FAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E608941F909BCD;
        }
    }

    class FAR(ulong val) : FAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52480CB5FD88038;
        }
    }

    class FAS(ulong val) : FAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x192E6DDFC05C6A7;
        }
    }

    class FAT(ulong val) : FAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E338532F1EECBC;
        }
    }

    class FAU(ulong val) : FAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6ADC1B54CED85B6;
        }
    }

    class FAV(ulong val) : FAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92FDB42C4CB0EAA;
        }
    }

    class FAW(ulong val) : FAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36B8E8E1716EC28;
        }
    }

    class FAX(ulong val) : FAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x231609AE885A151;
        }
    }

    class FAY(ulong val) : FAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x569B666174F3F07;
        }
    }

    class FAZ(ulong val) : FAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x268BED4ABAF6BA4;
        }
    }

    class FBA(ulong val) : FAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F948F40E9D3CAA;
        }
    }

    class FBB(ulong val) : FBA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x94169E8323A6AF2;
        }
    }

    class FBC(ulong val) : FBB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1EC27F6F4E2384E;
        }
    }

    class FBD(ulong val) : FBC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x358B61BCCBF0F00;
        }
    }

    class FBE(ulong val) : FBD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x950B244F437EBDD;
        }
    }

    class FBF(ulong val) : FBE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x21634D8E83E2FA9;
        }
    }

    class FBG(ulong val) : FBF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x531F05ABCEC798D;
        }
    }

    class FBH(ulong val) : FBG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8C22326587E3CD6;
        }
    }

    class FBI(ulong val) : FBH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8DB7DD46D1DFA2F;
        }
    }

    class FBJ(ulong val) : FBI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x543342432FE3207;
        }
    }

    class FBK(ulong val) : FBJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B8AD017B194A0D;
        }
    }

    class FBL(ulong val) : FBK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x339FDD2AE0BA739;
        }
    }

    class FBM(ulong val) : FBL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FBB21FACEE7C2D;
        }
    }

    class FBN(ulong val) : FBM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2D53E2B72618807;
        }
    }

    class FBO(ulong val) : FBN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x50E15E1821C6C4F;
        }
    }

    class FBP(ulong val) : FBO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6381F9E5F8A27BD;
        }
    }

    class FBQ(ulong val) : FBP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39CCA4313E6F45D;
        }
    }

    class FBR(ulong val) : FBQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98216C1E9C5E6F3;
        }
    }

    class FBS(ulong val) : FBR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5DAE4386EA28647;
        }
    }

    class FBT(ulong val) : FBS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x64257E64BAF1EF7;
        }
    }

    class FBU(ulong val) : FBT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A4E164B0771C04;
        }
    }

    class FBV(ulong val) : FBU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x33DF4AA85173D28;
        }
    }

    class FBW(ulong val) : FBV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23DFBBCA85D2BE9;
        }
    }

    class FBX(ulong val) : FBW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F179B8D30EF1C0;
        }
    }

    class FBY(ulong val) : FBX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6FE42854AB16C1C;
        }
    }

    class FBZ(ulong val) : FBY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B9F6235D5B97BE;
        }
    }

    class FCA(ulong val) : FBZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6101A83E36E64BC;
        }
    }

    class FCB(ulong val) : FCA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x988C61007118584;
        }
    }

    class FCC(ulong val) : FCB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8368136E81B9E54;
        }
    }

    class FCD(ulong val) : FCC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1B03C5B0CFA3E41;
        }
    }

    class FCE(ulong val) : FCD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x573DDA2C6FCD7B5;
        }
    }

    class FCF(ulong val) : FCE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A493BBCCDDBFD7;
        }
    }

    class FCG(ulong val) : FCF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x415D0B0DBC699C2;
        }
    }

    class FCH(ulong val) : FCG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7BF533B015308C9;
        }
    }

    class FCI(ulong val) : FCH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1E71AA29D9C64A5;
        }
    }

    class FCJ(ulong val) : FCI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x75854E121DD832D;
        }
    }

    class FCK(ulong val) : FCJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x109B4F709A26DB3;
        }
    }

    class FCL(ulong val) : FCK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15FCCC6F32EA279;
        }
    }

    class FCM(ulong val) : FCL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6AC8D4FD52E7039;
        }
    }

    class FCN(ulong val) : FCM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x66F48E30FEA189E;
        }
    }

    class FCO(ulong val) : FCN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4142A490BF78BAB;
        }
    }

    class FCP(ulong val) : FCO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DC3A1B5C8619E0;
        }
    }

    class FCQ(ulong val) : FCP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x688803F8E17E9A0;
        }
    }

    class FCR(ulong val) : FCQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4587DFEACC2819D;
        }
    }

    class FCS(ulong val) : FCR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x147DB4CED4B5715;
        }
    }

    class FCT(ulong val) : FCS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x74C69F1D36E8A83;
        }
    }

    class FCU(ulong val) : FCT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4772F5F1BDF620C;
        }
    }

    class FCV(ulong val) : FCU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70F89556408FE66;
        }
    }

    class FCW(ulong val) : FCV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1CC8DDD7D17D162;
        }
    }

    class FCX(ulong val) : FCW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3696B7AF13FF733;
        }
    }

    class FCY(ulong val) : FCX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5326CEC40F1EA00;
        }
    }

    class FCZ(ulong val) : FCY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x827901EE14DBE64;
        }
    }

    class FDA(ulong val) : FCZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x59E5B5D19DE8DCD;
        }
    }

    class FDB(ulong val) : FDA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x563FBABC3E42B63;
        }
    }

    class FDC(ulong val) : FDB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5730C4888632C0C;
        }
    }

    class FDD(ulong val) : FDC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x741E7BE594C68CB;
        }
    }

    class FDE(ulong val) : FDD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7196517952326CC;
        }
    }

    class FDF(ulong val) : FDE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28057304C41BF1F;
        }
    }

    class FDG(ulong val) : FDF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8892F5BCF89A17D;
        }
    }

    class FDH(ulong val) : FDG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2AB7BA7ED1455CD;
        }
    }

    class FDI(ulong val) : FDH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1CCECE9D6C5E206;
        }
    }

    class FDJ(ulong val) : FDI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E3A3C29B4F994F;
        }
    }

    class FDK(ulong val) : FDJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5049005BC954BB6;
        }
    }

    class FDL(ulong val) : FDK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79095BF834AE289;
        }
    }

    class FDM(ulong val) : FDL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x21E6EC25549AF9F;
        }
    }

    class FDN(ulong val) : FDM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20558BC668C0489;
        }
    }

    class FDO(ulong val) : FDN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x159D7A276BCEC00;
        }
    }

    class FDP(ulong val) : FDO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6D4B3987DD6A0BD;
        }
    }

    class FDQ(ulong val) : FDP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x618F53E2F66400A;
        }
    }

    class FDR(ulong val) : FDQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5EA9A0A4217806C;
        }
    }

    class FDS(ulong val) : FDR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1863F360684D834;
        }
    }

    class FDT(ulong val) : FDS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9193C045D0E0025;
        }
    }

    class FDU(ulong val) : FDT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x577E9BC7849B097;
        }
    }

    class FDV(ulong val) : FDU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87762C41EE7556A;
        }
    }

    class FDW(ulong val) : FDV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x828FD18EEF32EAB;
        }
    }

    class FDX(ulong val) : FDW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20CD818AEE7C786;
        }
    }

    class FDY(ulong val) : FDX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25A3305D9472BD4;
        }
    }

    class FDZ(ulong val) : FDY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2568B8D913015A3;
        }
    }

    class FEA(ulong val) : FDZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5BBBA4770459B86;
        }
    }

    class FEB(ulong val) : FEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7699AB51E629244;
        }
    }

    class FEC(ulong val) : FEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C9BD350D8CC158;
        }
    }

    class FED(ulong val) : FEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D8AD944C8C6157;
        }
    }

    class FEE(ulong val) : FED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8B97F36D9A965BF;
        }
    }

    class FEF(ulong val) : FEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x523657BCDED2F0A;
        }
    }

    class FEG(ulong val) : FEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4FFEEE804C90174;
        }
    }

    class FEH(ulong val) : FEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11DB39D23AB76FE;
        }
    }

    class FEI(ulong val) : FEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x714335D176793B1;
        }
    }

    class FEJ(ulong val) : FEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1E057A126CA0822;
        }
    }

    class FEK(ulong val) : FEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D3BB8C02A0D8F9;
        }
    }

    class FEL(ulong val) : FEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1B8AB6995B9292A;
        }
    }

    class FEM(ulong val) : FEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F5227B377E17CE;
        }
    }

    class FEN(ulong val) : FEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DE536613FCED4E;
        }
    }

    class FEO(ulong val) : FEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x30D77C7ACCD7FF7;
        }
    }

    class FEP(ulong val) : FEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39E888DC8E18C98;
        }
    }

    class FEQ(ulong val) : FEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2AB0B9F6D8A5BA1;
        }
    }

    class FER(ulong val) : FEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A3B44D6F633FCD;
        }
    }

    class FES(ulong val) : FER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F507B3FD3110E4;
        }
    }

    class FET(ulong val) : FES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1843875F1567F28;
        }
    }

    class FEU(ulong val) : FET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1DE049F5174D477;
        }
    }

    class FEV(ulong val) : FEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x626F326F341E48C;
        }
    }

    class FEW(ulong val) : FEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x561E4F75CA9554C;
        }
    }

    class FEX(ulong val) : FEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1551265CB7CB60A;
        }
    }

    class FEY(ulong val) : FEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x290B230D1F7F4B0;
        }
    }

    class FEZ(ulong val) : FEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D8DFF923DE69A6;
        }
    }

    class FFA(ulong val) : FEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x807218B7FD95122;
        }
    }

    class FFB(ulong val) : FFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C494FB2BE1C6AF;
        }
    }

    class FFC(ulong val) : FFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20760882B6DC4E7;
        }
    }

    class FFD(ulong val) : FFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x91234BBC7B203F1;
        }
    }

    class FFE(ulong val) : FFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34DF78514A46F60;
        }
    }

    class FFF(ulong val) : FFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x903C37F4C892F92;
        }
    }

    class FFG(ulong val) : FFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93F3BC63B945985;
        }
    }

    class FFH(ulong val) : FFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A5F916A76F1813;
        }
    }

    class FFI(ulong val) : FFH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5AE360701D0F87A;
        }
    }

    class FFJ(ulong val) : FFI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x79B8B5DDA5C5AF2;
        }
    }

    class FFK(ulong val) : FFJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x846723E8D6C346A;
        }
    }

    class FFL(ulong val) : FFK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93DC22093C519D2;
        }
    }

    class FFM(ulong val) : FFL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x84EF2DDABBBA899;
        }
    }

    class FFN(ulong val) : FFM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x213578110743CB9;
        }
    }

    class FFO(ulong val) : FFN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x71B1BEEE0DD41BB;
        }
    }

    class FFP(ulong val) : FFO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4DC1CFB72106CF9;
        }
    }

    class FFQ(ulong val) : FFP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F8091A36ABFB69;
        }
    }

    class FFR(ulong val) : FFQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2FB1E8A2D98A10D;
        }
    }

    class FFS(ulong val) : FFR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x499183A5BF981A9;
        }
    }

    class FFT(ulong val) : FFS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8621B39E337FE14;
        }
    }

    class FFU(ulong val) : FFT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4426B70D2A99613;
        }
    }

    class FFV(ulong val) : FFU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5E5DF989705071F;
        }
    }

    class FFW(ulong val) : FFV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6BE1242C96F7D7E;
        }
    }

    class FFX(ulong val) : FFW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x10EB1D4EE104C6F;
        }
    }

    class FFY(ulong val) : FFX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x24DB14DBE1E89C3;
        }
    }

    class FFZ(ulong val) : FFY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x560247DF494FD03;
        }
    }

    class FGA(ulong val) : FFZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x119AB6EEEBC9B37;
        }
    }

    class FGB(ulong val) : FGA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2099CB35C158F5B;
        }
    }

    class FGC(ulong val) : FGB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4970F6A63204A6E;
        }
    }

    class FGD(ulong val) : FGC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B2BC3E8E6E4792;
        }
    }

    class FGE(ulong val) : FGD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x76A7624E2D965F6;
        }
    }

    class FGF(ulong val) : FGE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86A20EE28529773;
        }
    }

    class FGG(ulong val) : FGF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E9D9976FEE071B;
        }
    }

    class FGH(ulong val) : FGG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x21D6AE5BA88AF2B;
        }
    }

    class FGI(ulong val) : FGH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x245F424451ABE9D;
        }
    }

    class FGJ(ulong val) : FGI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x54DA8E4FA945C9D;
        }
    }

    class FGK(ulong val) : FGJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E992211F16025D;
        }
    }

    class FGL(ulong val) : FGK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x684DED4B3889BC8;
        }
    }

    class FGM(ulong val) : FGL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x81850825F5C8FB2;
        }
    }

    class FGN(ulong val) : FGM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B09CDDEF87F974;
        }
    }

    class FGO(ulong val) : FGN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5A14C3728928E57;
        }
    }

    class FGP(ulong val) : FGO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7932733BA39C288;
        }
    }

    class FGQ(ulong val) : FGP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F704970962ABD6;
        }
    }

    class FGR(ulong val) : FGQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x645F88235459DD5;
        }
    }

    class FGS(ulong val) : FGR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E4584C18651C06;
        }
    }

    class FGT(ulong val) : FGS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4DEF5FB19D4167B;
        }
    }

    class FGU(ulong val) : FGT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3922C626091759C;
        }
    }

    class FGV(ulong val) : FGU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x641360BFF5342E4;
        }
    }

    class FGW(ulong val) : FGV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9414CD298DFABD3;
        }
    }

    class FGX(ulong val) : FGW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C30022D16E0DAB;
        }
    }

    class FGY(ulong val) : FGX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x67F674544918947;
        }
    }

    class FGZ(ulong val) : FGY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F927DBB23A1D52;
        }
    }

    class FHA(ulong val) : FGZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A203FB7B594CEC;
        }
    }

    class FHB(ulong val) : FHA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x639DBD5F3779BE7;
        }
    }

    class FHC(ulong val) : FHB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11563D92B12D7E7;
        }
    }

    class FHD(ulong val) : FHC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8FD99BE179B2917;
        }
    }

    class FHE(ulong val) : FHD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x215DCE984FBFA52;
        }
    }

    class FHF(ulong val) : FHE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C4557C57D3C186;
        }
    }

    class FHG(ulong val) : FHF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47856114F1333A8;
        }
    }

    class FHH(ulong val) : FHG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3E16F1C776F3BF4;
        }
    }

    class FHI(ulong val) : FHH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8EACBEB8EDF161B;
        }
    }

    class FHJ(ulong val) : FHI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17E000663821A82;
        }
    }

    class FHK(ulong val) : FHJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BB05BB2D0ED270;
        }
    }

    class FHL(ulong val) : FHK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5DB0DDBCD7BA6D8;
        }
    }

    class FHM(ulong val) : FHL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BC7B2CEE960D66;
        }
    }

    class FHN(ulong val) : FHM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3FE868A5ECC5E0D;
        }
    }

    class FHO(ulong val) : FHN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x35441A08BA3B5AB;
        }
    }

    class FHP(ulong val) : FHO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C9521FD9F6C708;
        }
    }

    class FHQ(ulong val) : FHP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x497D2E33370048D;
        }
    }

    class FHR(ulong val) : FHQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x190412751CACD1C;
        }
    }

    class FHS(ulong val) : FHR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4194ED5052C3889;
        }
    }

    class FHT(ulong val) : FHS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B37D1D8C6BE4A4;
        }
    }

    class FHU(ulong val) : FHT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B3306D2F06C8B8;
        }
    }

    class FHV(ulong val) : FHU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8341B931BEB158C;
        }
    }

    class FHW(ulong val) : FHV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B72422C4909A03;
        }
    }

    class FHX(ulong val) : FHW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48DEA7DF9047735;
        }
    }

    class FHY(ulong val) : FHX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x231B3718F77B79A;
        }
    }

    class FHZ(ulong val) : FHY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C4848FDD2C5AD9;
        }
    }

    class FIA(ulong val) : FHZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87AFF9F49BD4F18;
        }
    }

    class FIB(ulong val) : FIA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72E2B1EA6C091B2;
        }
    }

    class FIC(ulong val) : FIB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x17969C3B23BA90C;
        }
    }

    class FID(ulong val) : FIC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x14A0A0293D29C3E;
        }
    }

    class FIE(ulong val) : FID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x55D1CE56A49B7ED;
        }
    }

    class FIF(ulong val) : FIE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x591B6619E6F762B;
        }
    }

    class FIG(ulong val) : FIF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A402C799E7AC89;
        }
    }

    class FIH(ulong val) : FIG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7E59A50FFD41D27;
        }
    }

    class FII(ulong val) : FIH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x90B0F72BDFDF243;
        }
    }

    class FIJ(ulong val) : FII(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17EFC83A1A5C3CE;
        }
    }

    class FIK(ulong val) : FIJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x748BFA1B044CFF2;
        }
    }

    class FIL(ulong val) : FIK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x703C3B38ECF8A20;
        }
    }

    class FIM(ulong val) : FIL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x72595313D90AF1D;
        }
    }

    class FIN(ulong val) : FIM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6018B6DEB58BAC0;
        }
    }

    class FIO(ulong val) : FIN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9963A1F13AB118F;
        }
    }

    class FIP(ulong val) : FIO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4974B2600BDAF83;
        }
    }

    class FIQ(ulong val) : FIP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2743E16297ECBA3;
        }
    }

    class FIR(ulong val) : FIQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A59806BC1D83DC;
        }
    }

    class FIS(ulong val) : FIR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7AEBF6B67D49890;
        }
    }

    class FIT(ulong val) : FIS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57FC7D8A02DEFBF;
        }
    }

    class FIU(ulong val) : FIT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89FA2BB3D103EAE;
        }
    }

    class FIV(ulong val) : FIU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C32890F57054F9;
        }
    }

    class FIW(ulong val) : FIV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x61468B2E56160A9;
        }
    }

    class FIX(ulong val) : FIW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77B1313029C39BE;
        }
    }

    class FIY(ulong val) : FIX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x66294CC929ACC06;
        }
    }

    class FIZ(ulong val) : FIY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8DA1C34B0510935;
        }
    }

    class FJA(ulong val) : FIZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5FF5B2A8C8F6A70;
        }
    }

    class FJB(ulong val) : FJA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91C26ED5DD61824;
        }
    }

    class FJC(ulong val) : FJB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x612F3DBFAC36B1F;
        }
    }

    class FJD(ulong val) : FJC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D5BDECEDB4A1AC;
        }
    }

    class FJE(ulong val) : FJD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7119C6CEA2F1F9F;
        }
    }

    class FJF(ulong val) : FJE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53544924CB33474;
        }
    }

    class FJG(ulong val) : FJF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x91A74E3C12FEBB5;
        }
    }

    class FJH(ulong val) : FJG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15C4B6FA4C5AB71;
        }
    }

    class FJI(ulong val) : FJH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1267E4EB5F71B41;
        }
    }

    class FJJ(ulong val) : FJI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3806CD6ECBBE0D4;
        }
    }

    class FJK(ulong val) : FJJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48CADF8B87C3252;
        }
    }

    class FJL(ulong val) : FJK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9388D9BDC5EC5B3;
        }
    }

    class FJM(ulong val) : FJL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7ACB3F52C3C89A3;
        }
    }

    class FJN(ulong val) : FJM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3BAEC0FF2A6C63B;
        }
    }

    class FJO(ulong val) : FJN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x25B42EE1966E30F;
        }
    }

    class FJP(ulong val) : FJO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25D14A336B7B0F7;
        }
    }

    class FJQ(ulong val) : FJP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3E512AF5DBE0402;
        }
    }

    class FJR(ulong val) : FJQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F017D2D22C3C97;
        }
    }

    class FJS(ulong val) : FJR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6204E9820128247;
        }
    }

    class FJT(ulong val) : FJS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7A4109561EAF70D;
        }
    }

    class FJU(ulong val) : FJT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3AC89DB2C12F043;
        }
    }

    class FJV(ulong val) : FJU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7CE6E8C7C0D7FAA;
        }
    }

    class FJW(ulong val) : FJV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x141F5A63E7B83C6;
        }
    }

    class FJX(ulong val) : FJW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36F1591335F28E3;
        }
    }

    class FJY(ulong val) : FJX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x213C2C051EB8199;
        }
    }

    class FJZ(ulong val) : FJY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x466BC28851ABD8B;
        }
    }

    class FKA(ulong val) : FJZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8B8D0EC539257D8;
        }
    }

    class FKB(ulong val) : FKA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98AE1638ED76A7F;
        }
    }

    class FKC(ulong val) : FKB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x97F0FA42DD75FE8;
        }
    }

    class FKD(ulong val) : FKC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x18F779E3E16277F;
        }
    }

    class FKE(ulong val) : FKD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6548FC2F633EF34;
        }
    }

    class FKF(ulong val) : FKE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x44156DE814A5C6C;
        }
    }

    class FKG(ulong val) : FKF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71F0335AFA72E33;
        }
    }

    class FKH(ulong val) : FKG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F18481A43D63C4;
        }
    }

    class FKI(ulong val) : FKH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x80AE94316A3D0BE;
        }
    }

    class FKJ(ulong val) : FKI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6A8709360C66CEF;
        }
    }

    class FKK(ulong val) : FKJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C1C73C3503F103;
        }
    }

    class FKL(ulong val) : FKK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88A266278B95C36;
        }
    }

    class FKM(ulong val) : FKL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x684F9A5A1248389;
        }
    }

    class FKN(ulong val) : FKM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x438A87B6A0B99F9;
        }
    }

    class FKO(ulong val) : FKN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D328DA2594E864;
        }
    }

    class FKP(ulong val) : FKO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5FE4FAF1600CC46;
        }
    }

    class FKQ(ulong val) : FKP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4751ED060B79B63;
        }
    }

    class FKR(ulong val) : FKQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x438358431A4F010;
        }
    }

    class FKS(ulong val) : FKR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88C090E3C766B3D;
        }
    }

    class FKT(ulong val) : FKS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80D8FDE40E5F6B2;
        }
    }

    class FKU(ulong val) : FKT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2518861115154E1;
        }
    }

    class FKV(ulong val) : FKU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x12D632745C999AF;
        }
    }

    class FKW(ulong val) : FKV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DD60438826925F;
        }
    }

    class FKX(ulong val) : FKW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x572E3C9A526502F;
        }
    }

    class FKY(ulong val) : FKX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x51C9B0DB6180077;
        }
    }

    class FKZ(ulong val) : FKY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x12B6DCF673654BD;
        }
    }

    class FLA(ulong val) : FKZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16106270A1934FB;
        }
    }

    class FLB(ulong val) : FLA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6EFAC244FE23679;
        }
    }

    class FLC(ulong val) : FLB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x67063803541EC0E;
        }
    }

    class FLD(ulong val) : FLC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5BE4AE67C305DDB;
        }
    }

    class FLE(ulong val) : FLD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7F26407C1CBBCF9;
        }
    }

    class FLF(ulong val) : FLE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6184DA2D1D75CB7;
        }
    }

    class FLG(ulong val) : FLF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9478FB7A38CB602;
        }
    }

    class FLH(ulong val) : FLG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DD900015CA7526;
        }
    }

    class FLI(ulong val) : FLH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15DDDA4A1E330FD;
        }
    }

    class FLJ(ulong val) : FLI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6FAB91215E2F635;
        }
    }

    class FLK(ulong val) : FLJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88034ABDF698045;
        }
    }

    class FLL(ulong val) : FLK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3014B85977AE983;
        }
    }

    class FLM(ulong val) : FLL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x117B8C3181E68FF;
        }
    }

    class FLN(ulong val) : FLM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56F38C844FE571E;
        }
    }

    class FLO(ulong val) : FLN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x20378D1711A455A;
        }
    }

    class FLP(ulong val) : FLO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42C91C73D507A4E;
        }
    }

    class FLQ(ulong val) : FLP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x27DECC927EA0FEC;
        }
    }

    class FLR(ulong val) : FLQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26108C30BA020E5;
        }
    }

    class FLS(ulong val) : FLR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5AC3FA90C6F53B2;
        }
    }

    class FLT(ulong val) : FLS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x95825FD37F76661;
        }
    }

    class FLU(ulong val) : FLT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2FDCD92B9D2C78A;
        }
    }

    class FLV(ulong val) : FLU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x774732F22A1561A;
        }
    }

    class FLW(ulong val) : FLV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1BB256CF30040C8;
        }
    }

    class FLX(ulong val) : FLW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x162EF431F4AD97E;
        }
    }

    class FLY(ulong val) : FLX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x99050B16B620E31;
        }
    }

    class FLZ(ulong val) : FLY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9439687714A782A;
        }
    }

    class FMA(ulong val) : FLZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CA66826B124445;
        }
    }

    class FMB(ulong val) : FMA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5813E418CCCCC14;
        }
    }

    class FMC(ulong val) : FMB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x73F7C21D037D731;
        }
    }

    class FMD(ulong val) : FMC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E484BA435E9C93;
        }
    }

    class FME(ulong val) : FMD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x35005F00C3D1A47;
        }
    }

    class FMF(ulong val) : FME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x936418F918F4E17;
        }
    }

    class FMG(ulong val) : FMF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E5987B67C4BD12;
        }
    }

    class FMH(ulong val) : FMG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57FDC36CE78AEC7;
        }
    }

    class FMI(ulong val) : FMH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5F816F978B5BD2E;
        }
    }

    class FMJ(ulong val) : FMI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88F621B87B97CD3;
        }
    }

    class FMK(ulong val) : FMJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x552BE5E9C2E4317;
        }
    }

    class FML(ulong val) : FMK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27A290B6D11B5EC;
        }
    }

    class FMM(ulong val) : FML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x77EC7E18995CA41;
        }
    }

    class FMN(ulong val) : FMM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8568A3F898E0515;
        }
    }

    class FMO(ulong val) : FMN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x85F146459837044;
        }
    }

    class FMP(ulong val) : FMO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C4BBDF084E46D0;
        }
    }

    class FMQ(ulong val) : FMP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x59C1CBCBF84698D;
        }
    }

    class FMR(ulong val) : FMQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50EE9B1B602AD86;
        }
    }

    class FMS(ulong val) : FMR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x48192A8D80C7580;
        }
    }

    class FMT(ulong val) : FMS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E75D39202DA603;
        }
    }

    class FMU(ulong val) : FMT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B0C623C40F1FA7;
        }
    }

    class FMV(ulong val) : FMU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B17D49D6186691;
        }
    }

    class FMW(ulong val) : FMV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2400EFD5728163E;
        }
    }

    class FMX(ulong val) : FMW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2B4F7DC84572955;
        }
    }

    class FMY(ulong val) : FMX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3D03ADFF60AB681;
        }
    }

    class FMZ(ulong val) : FMY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x657186FFA1CB0FB;
        }
    }

    class FNA(ulong val) : FMZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D86459427110BF;
        }
    }

    class FNB(ulong val) : FNA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91AF2A5F9402E09;
        }
    }

    class FNC(ulong val) : FNB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3FC6F00CB679246;
        }
    }

    class FND(ulong val) : FNC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x19B0C4164062181;
        }
    }

    class FNE(ulong val) : FND(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x379FC6F23718399;
        }
    }

    class FNF(ulong val) : FNE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F323B2575C1D9E;
        }
    }

    class FNG(ulong val) : FNF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87C530AB84AD069;
        }
    }

    class FNH(ulong val) : FNG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x70894824DD44A31;
        }
    }

    class FNI(ulong val) : FNH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D3BAB8027A5ED1;
        }
    }

    class FNJ(ulong val) : FNI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E107D5EBB5CC4E;
        }
    }

    class FNK(ulong val) : FNJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61F9C6BC6BB4E34;
        }
    }

    class FNL(ulong val) : FNK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F5A38B53E62A3E;
        }
    }

    class FNM(ulong val) : FNL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5666F012E43E452;
        }
    }

    class FNN(ulong val) : FNM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x40279DAA4F79BDA;
        }
    }

    class FNO(ulong val) : FNN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7F2508D5A44F9D5;
        }
    }

    class FNP(ulong val) : FNO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1CF4470FEF3C634;
        }
    }

    class FNQ(ulong val) : FNP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x93F683006B3791D;
        }
    }

    class FNR(ulong val) : FNQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x26605A11D1F9FB0;
        }
    }

    class FNS(ulong val) : FNR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x710E3D16D5C0C88;
        }
    }

    class FNT(ulong val) : FNS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72A9EC29AA7BBFC;
        }
    }

    class FNU(ulong val) : FNT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F9202FC67CED2F;
        }
    }

    class FNV(ulong val) : FNU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x109617CF2AA25D3;
        }
    }

    class FNW(ulong val) : FNV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x140AF07DD5595E3;
        }
    }

    class FNX(ulong val) : FNW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96AB7765177AA82;
        }
    }

    class FNY(ulong val) : FNX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8833041E57E7ADB;
        }
    }

    class FNZ(ulong val) : FNY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x610D6B6D61D02A7;
        }
    }

    class FOA(ulong val) : FNZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x182C487C53E0118;
        }
    }

    class FOB(ulong val) : FOA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3489140B8B1C03A;
        }
    }

    class FOC(ulong val) : FOB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E8699679D48C65;
        }
    }

    class FOD(ulong val) : FOC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39500890CAE08E0;
        }
    }

    class FOE(ulong val) : FOD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71DF82389F24486;
        }
    }

    class FOF(ulong val) : FOE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18888970DFEF70F;
        }
    }

    class FOG(ulong val) : FOF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1B84BB41B72E9B3;
        }
    }

    class FOH(ulong val) : FOG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x580DE9C31EA7A85;
        }
    }

    class FOI(ulong val) : FOH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7E669F3D6A1C9F7;
        }
    }

    class FOJ(ulong val) : FOI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x65CDBC09F14C941;
        }
    }

    class FOK(ulong val) : FOJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AAB8E71EC077A8;
        }
    }

    class FOL(ulong val) : FOK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5754213A0A19AF0;
        }
    }

    class FOM(ulong val) : FOL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77A9603C84DBF3A;
        }
    }

    class FON(ulong val) : FOM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x647D43EB59931A2;
        }
    }

    class FOO(ulong val) : FON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B2A6B97CDFC023;
        }
    }

    class FOP(ulong val) : FOO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57FE35FE477CEF8;
        }
    }

    class FOQ(ulong val) : FOP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x174128F17C2AFB1;
        }
    }

    class FOR(ulong val) : FOQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94E7D91C6E98D26;
        }
    }

    class FOS(ulong val) : FOR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A31572BCBCB76C;
        }
    }

    class FOT(ulong val) : FOS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87E0BCED2FD583C;
        }
    }

    class FOU(ulong val) : FOT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E2633C3B5B94BB;
        }
    }

    class FOV(ulong val) : FOU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x23F43E5992916C5;
        }
    }

    class FOW(ulong val) : FOV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D9DD858A71D857;
        }
    }

    class FOX(ulong val) : FOW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9321D0A675B399C;
        }
    }

    class FOY(ulong val) : FOX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x64A1F8EB83776E4;
        }
    }

    class FOZ(ulong val) : FOY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56EEF98B4F897EA;
        }
    }

    class FPA(ulong val) : FOZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5AEBCD95C38CC1E;
        }
    }

    class FPB(ulong val) : FPA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6ACD33C04631128;
        }
    }

    class FPC(ulong val) : FPB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3E542E840932C0D;
        }
    }

    class FPD(ulong val) : FPC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x729A9E5BD799892;
        }
    }

    class FPE(ulong val) : FPD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2256FDFDB5B206C;
        }
    }

    class FPF(ulong val) : FPE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4F2C9665201C43B;
        }
    }

    class FPG(ulong val) : FPF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95D33920D9CE1F6;
        }
    }

    class FPH(ulong val) : FPG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7BE413C68713BA8;
        }
    }

    class FPI(ulong val) : FPH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x381E9A2BDD721DA;
        }
    }

    class FPJ(ulong val) : FPI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x87B852F99A3EF30;
        }
    }

    class FPK(ulong val) : FPJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2F38A2AC5EA1325;
        }
    }

    class FPL(ulong val) : FPK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x10C3472B09DFC01;
        }
    }

    class FPM(ulong val) : FPL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2ADCA042D2A255D;
        }
    }

    class FPN(ulong val) : FPM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2013DCBF6A5B11B;
        }
    }

    class FPO(ulong val) : FPN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78A5375537BB7A5;
        }
    }

    class FPP(ulong val) : FPO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x17B423A22D15FC6;
        }
    }

    class FPQ(ulong val) : FPP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5D78000DF38741A;
        }
    }

    class FPR(ulong val) : FPQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72DD571E9DD798D;
        }
    }

    class FPS(ulong val) : FPR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3549E9026E66FAE;
        }
    }

    class FPT(ulong val) : FPS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x32F602284EF91BE;
        }
    }

    class FPU(ulong val) : FPT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7D0B5A0058105A4;
        }
    }

    class FPV(ulong val) : FPU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DD9E7CAA76E0B9;
        }
    }

    class FPW(ulong val) : FPV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C9574521DB45F1;
        }
    }

    class FPX(ulong val) : FPW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x91EB63C086F351B;
        }
    }

    class FPY(ulong val) : FPX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x292E6E0B01F4F36;
        }
    }

    class FPZ(ulong val) : FPY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x848CF2F90F2535B;
        }
    }

    class FQA(ulong val) : FPZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42FC30EC81B8043;
        }
    }

    class FQB(ulong val) : FQA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1766E3A7B399A19;
        }
    }

    class FQC(ulong val) : FQB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98B8409006BC386;
        }
    }

    class FQD(ulong val) : FQC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6221B2AFDC1C8EB;
        }
    }

    class FQE(ulong val) : FQD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7A545DDA5AC8EA6;
        }
    }

    class FQF(ulong val) : FQE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20C7D74D72A5408;
        }
    }

    class FQG(ulong val) : FQF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3787A2FA9E5B7F7;
        }
    }

    class FQH(ulong val) : FQG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16F3F619AFF947B;
        }
    }

    class FQI(ulong val) : FQH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4A32831A44CAB1D;
        }
    }

    class FQJ(ulong val) : FQI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x55D6D6D90351BE7;
        }
    }

    class FQK(ulong val) : FQJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x521C85EC60D9CAF;
        }
    }

    class FQL(ulong val) : FQK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A7D436D4F0F3CA;
        }
    }

    class FQM(ulong val) : FQL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2C696B58F4BE229;
        }
    }

    class FQN(ulong val) : FQM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FD9196DB3A9CA5;
        }
    }

    class FQO(ulong val) : FQN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x58AC129A37EF8BD;
        }
    }

    class FQP(ulong val) : FQO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x97D8CAD8B740FE7;
        }
    }

    class FQQ(ulong val) : FQP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E3271C36144157;
        }
    }

    class FQR(ulong val) : FQQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x760B20BB23CF109;
        }
    }

    class FQS(ulong val) : FQR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x97D3D3AC8D23B9D;
        }
    }

    class FQT(ulong val) : FQS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x479C66EF6250843;
        }
    }

    class FQU(ulong val) : FQT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x96CA7F4AFFB3D7A;
        }
    }

    class FQV(ulong val) : FQU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58F410EEC8DB718;
        }
    }

    class FQW(ulong val) : FQV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x513BD72E55FE020;
        }
    }

    class FQX(ulong val) : FQW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FAC4B292424DD8;
        }
    }

    class FQY(ulong val) : FQX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7C84854AC89692C;
        }
    }

    class FQZ(ulong val) : FQY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1AA282DE55CA25F;
        }
    }

    class FRA(ulong val) : FQZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11B3D2BA210F74F;
        }
    }

    class FRB(ulong val) : FRA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5CDAFC60E0A26BB;
        }
    }

    class FRC(ulong val) : FRB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58D3EE7A3F211AA;
        }
    }

    class FRD(ulong val) : FRC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x71FBA414B7334FD;
        }
    }

    class FRE(ulong val) : FRD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8150F9A6F6224AA;
        }
    }

    class FRF(ulong val) : FRE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x876B86AB7034422;
        }
    }

    class FRG(ulong val) : FRF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x790BA4B4039F2E6;
        }
    }

    class FRH(ulong val) : FRG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85DB0EECB648E20;
        }
    }

    class FRI(ulong val) : FRH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5FCF880E27C4DA1;
        }
    }

    class FRJ(ulong val) : FRI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36EB907DE2702C3;
        }
    }

    class FRK(ulong val) : FRJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E2132F002CFF64;
        }
    }

    class FRL(ulong val) : FRK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F3DD4FC4844CF3;
        }
    }

    class FRM(ulong val) : FRL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x268BF37B05CD577;
        }
    }

    class FRN(ulong val) : FRM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x321E6A0AE0E3102;
        }
    }

    class FRO(ulong val) : FRN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60A468B22C48FD8;
        }
    }

    class FRP(ulong val) : FRO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39819782EAACD0A;
        }
    }

    class FRQ(ulong val) : FRP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x603FE76A0E3820D;
        }
    }

    class FRR(ulong val) : FRQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7496CF68D46AFB2;
        }
    }

    class FRS(ulong val) : FRR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x18415A6593239ED;
        }
    }

    class FRT(ulong val) : FRS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x587D3FFC20A7B0D;
        }
    }

    class FRU(ulong val) : FRT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D927565B2C5562;
        }
    }

    class FRV(ulong val) : FRU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A364171F43D550;
        }
    }

    class FRW(ulong val) : FRV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1587D3A823B8500;
        }
    }

    class FRX(ulong val) : FRW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3D9559FCE4F69FD;
        }
    }

    class FRY(ulong val) : FRX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AE1FE791F3F902;
        }
    }

    class FRZ(ulong val) : FRY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x84AC7D0A089D75C;
        }
    }

    class FSA(ulong val) : FRZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4641EBABE2D05E3;
        }
    }

    class FSB(ulong val) : FSA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6EC060345F1585B;
        }
    }

    class FSC(ulong val) : FSB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2A7D7B389AD6669;
        }
    }

    class FSD(ulong val) : FSC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x473E554C0CEA7DF;
        }
    }

    class FSE(ulong val) : FSD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C8A7074E8274B1;
        }
    }

    class FSF(ulong val) : FSE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1014A8A347A2D80;
        }
    }

    class FSG(ulong val) : FSF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C78A858AF22C39;
        }
    }

    class FSH(ulong val) : FSG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x667464355D12C4B;
        }
    }

    class FSI(ulong val) : FSH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2CB21D710EEE8B1;
        }
    }

    class FSJ(ulong val) : FSI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17FEA8A9489A1B7;
        }
    }

    class FSK(ulong val) : FSJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39C1B75FC63DDD0;
        }
    }

    class FSL(ulong val) : FSK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x93C03A2D78E6CA9;
        }
    }

    class FSM(ulong val) : FSL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x736F940D279AD33;
        }
    }

    class FSN(ulong val) : FSM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B31DCEF47BE9E0;
        }
    }

    class FSO(ulong val) : FSN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8401A4A13674F3F;
        }
    }

    class FSP(ulong val) : FSO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94E63437A4D5F36;
        }
    }

    class FSQ(ulong val) : FSP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68921123581B2BA;
        }
    }

    class FSR(ulong val) : FSQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2CDACB3C4928A57;
        }
    }

    class FSS(ulong val) : FSR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x17680574AA76084;
        }
    }

    class FST(ulong val) : FSS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4EB1E28ECB9F362;
        }
    }

    class FSU(ulong val) : FST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D91869FFE03ABB;
        }
    }

    class FSV(ulong val) : FSU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x51B309C6FA4C374;
        }
    }

    class FSW(ulong val) : FSV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3473595E33B07CA;
        }
    }

    class FSX(ulong val) : FSW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1CF2A54A74B7971;
        }
    }

    class FSY(ulong val) : FSX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11FD0D3BC43055D;
        }
    }

    class FSZ(ulong val) : FSY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C96744F03BD5E3;
        }
    }

    class FTA(ulong val) : FSZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5AB3A86DEF9F9D3;
        }
    }

    class FTB(ulong val) : FTA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7F45FD3767DCDAE;
        }
    }

    class FTC(ulong val) : FTB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3F34324480B31A4;
        }
    }

    class FTD(ulong val) : FTC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3FED132F1F364E0;
        }
    }

    class FTE(ulong val) : FTD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x820A67B0404EE0F;
        }
    }

    class FTF(ulong val) : FTE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C356CD94B95D32;
        }
    }

    class FTG(ulong val) : FTF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x61ECFC2946A2E6B;
        }
    }

    class FTH(ulong val) : FTG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26D854A20034DD8;
        }
    }

    class FTI(ulong val) : FTH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54E5C037BD09839;
        }
    }

    class FTJ(ulong val) : FTI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x868921FEEF43CBF;
        }
    }

    class FTK(ulong val) : FTJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35AF4AE83E97E41;
        }
    }

    class FTL(ulong val) : FTK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1D53017FC648201;
        }
    }

    class FTM(ulong val) : FTL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x41E137A208C1FCC;
        }
    }

    class FTN(ulong val) : FTM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7934BE8BA22F41E;
        }
    }

    class FTO(ulong val) : FTN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CFD406E4B36456;
        }
    }

    class FTP(ulong val) : FTO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A1DE1CA8F7AEF8;
        }
    }

    class FTQ(ulong val) : FTP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2C70F7C198A23C2;
        }
    }

    class FTR(ulong val) : FTQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5ABA1609AD37233;
        }
    }

    class FTS(ulong val) : FTR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F2857BB6287569;
        }
    }

    class FTT(ulong val) : FTS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E2BE487EC01713;
        }
    }

    class FTU(ulong val) : FTT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x292BA4ABC399A6D;
        }
    }

    class FTV(ulong val) : FTU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x880C59DB823CD6B;
        }
    }

    class FTW(ulong val) : FTV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E14D9528218F07;
        }
    }

    class FTX(ulong val) : FTW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4E36A04CEF73C75;
        }
    }

    class FTY(ulong val) : FTX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E2CD90F5715904;
        }
    }

    class FTZ(ulong val) : FTY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x444C1E0B24F9BB5;
        }
    }

    class FUA(ulong val) : FTZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2621BA123B78DB4;
        }
    }

    class FUB(ulong val) : FUA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x44F95D07CB93A76;
        }
    }

    class FUC(ulong val) : FUB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68A482B61B6F1BD;
        }
    }

    class FUD(ulong val) : FUC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5088136E586AD8A;
        }
    }

    class FUE(ulong val) : FUD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x138A012A2D55A90;
        }
    }

    class FUF(ulong val) : FUE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x85B5920A557528B;
        }
    }

    class FUG(ulong val) : FUF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47FD9A9BB9274C0;
        }
    }

    class FUH(ulong val) : FUG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x478D8FC0F875AC5;
        }
    }

    class FUI(ulong val) : FUH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F86E74DCDD2517;
        }
    }

    class FUJ(ulong val) : FUI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x328381C888118C0;
        }
    }

    class FUK(ulong val) : FUJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x10CD8EFFEAC9E89;
        }
    }

    class FUL(ulong val) : FUK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7324CE4A2F4D11E;
        }
    }

    class FUM(ulong val) : FUL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7774FFAF119AE16;
        }
    }

    class FUN(ulong val) : FUM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x84BC87C0386E052;
        }
    }

    class FUO(ulong val) : FUN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x524AA4BEBE096A7;
        }
    }

    class FUP(ulong val) : FUO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6F8F13AC2083FB3;
        }
    }

    class FUQ(ulong val) : FUP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x415D3E2DEA68F92;
        }
    }

    class FUR(ulong val) : FUQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x494CBD794829030;
        }
    }

    class FUS(ulong val) : FUR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C8A507E64228DD;
        }
    }

    class FUT(ulong val) : FUS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21CFF0B1EA6DFE7;
        }
    }

    class FUU(ulong val) : FUT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x34806FFA99914DD;
        }
    }

    class FUV(ulong val) : FUU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63754EB2330081F;
        }
    }

    class FUW(ulong val) : FUV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x93E76BF8080BE96;
        }
    }

    class FUX(ulong val) : FUW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x45A3A49704072ED;
        }
    }

    class FUY(ulong val) : FUX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A52AF1D063C3BE;
        }
    }

    class FUZ(ulong val) : FUY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x329C48C1ABE1A86;
        }
    }

    class FVA(ulong val) : FUZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6CEC147F0A48EC8;
        }
    }

    class FVB(ulong val) : FVA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74D8192E9397C69;
        }
    }

    class FVC(ulong val) : FVB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4548B58E2959EDA;
        }
    }

    class FVD(ulong val) : FVC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x109EB53B8CEF527;
        }
    }

    class FVE(ulong val) : FVD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6A665DEA7AF029F;
        }
    }

    class FVF(ulong val) : FVE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x75074C8004B12EE;
        }
    }

    class FVG(ulong val) : FVF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x562A6B6B0A142A8;
        }
    }

    class FVH(ulong val) : FVG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x32950B233603061;
        }
    }

    class FVI(ulong val) : FVH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A888574F3F3BC1;
        }
    }

    class FVJ(ulong val) : FVI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x933E5E271F4EA49;
        }
    }

    class FVK(ulong val) : FVJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7980CED7E73166B;
        }
    }

    class FVL(ulong val) : FVK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x19C8D86212934B4;
        }
    }

    class FVM(ulong val) : FVL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87C07A5029FA7E4;
        }
    }

    class FVN(ulong val) : FVM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x58E467430C3EC6B;
        }
    }

    class FVO(ulong val) : FVN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8748D322F5CE59D;
        }
    }

    class FVP(ulong val) : FVO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5C1F4C4601BCB7D;
        }
    }

    class FVQ(ulong val) : FVP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E5ABE46AD6A149;
        }
    }

    class FVR(ulong val) : FVQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60A1D40ACCC0D4C;
        }
    }

    class FVS(ulong val) : FVR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x359DAC0EDEF00DB;
        }
    }

    class FVT(ulong val) : FVS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8858B2FF0A7B8AB;
        }
    }

    class FVU(ulong val) : FVT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x452E01571DB7E93;
        }
    }

    class FVV(ulong val) : FVU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25703987D740618;
        }
    }

    class FVW(ulong val) : FVV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BCC412BED1ADEA;
        }
    }

    class FVX(ulong val) : FVW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20DEA8CAD983DD6;
        }
    }

    class FVY(ulong val) : FVX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x213805565CE6402;
        }
    }

    class FVZ(ulong val) : FVY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5570F3C0A1EB7E8;
        }
    }

    class FWA(ulong val) : FVZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72379267FDF457C;
        }
    }

    class FWB(ulong val) : FWA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4329A2F9F6B078E;
        }
    }

    class FWC(ulong val) : FWB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3004298BAD3124B;
        }
    }

    class FWD(ulong val) : FWC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x904FE8818681924;
        }
    }

    class FWE(ulong val) : FWD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E06A0238AF6FB7;
        }
    }

    class FWF(ulong val) : FWE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82CEE886CC8CD94;
        }
    }

    class FWG(ulong val) : FWF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x621F5390D4673EC;
        }
    }

    class FWH(ulong val) : FWG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52F520D1EEA3943;
        }
    }

    class FWI(ulong val) : FWH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6EE58D49AA81076;
        }
    }

    class FWJ(ulong val) : FWI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E7A131E952FE4C;
        }
    }

    class FWK(ulong val) : FWJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3BBAFBE5BA25496;
        }
    }

    class FWL(ulong val) : FWK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1A1DD96B72E6B0C;
        }
    }

    class FWM(ulong val) : FWL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x60B7F4BA22A4357;
        }
    }

    class FWN(ulong val) : FWM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3E18BD514664B5E;
        }
    }

    class FWO(ulong val) : FWN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D885A499E86C4E;
        }
    }

    class FWP(ulong val) : FWO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C602C3EB17848E;
        }
    }

    class FWQ(ulong val) : FWP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E5F2467ECA3BBC;
        }
    }

    class FWR(ulong val) : FWQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50EEFBCB3976B56;
        }
    }

    class FWS(ulong val) : FWR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x83C405C9FA79194;
        }
    }

    class FWT(ulong val) : FWS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x855568F837EB21E;
        }
    }

    class FWU(ulong val) : FWT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3786F9F64D7A7CF;
        }
    }

    class FWV(ulong val) : FWU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23096B6525614A5;
        }
    }

    class FWW(ulong val) : FWV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3E3132E43E0B0C0;
        }
    }

    class FWX(ulong val) : FWW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x47A68A9A93237D8;
        }
    }

    class FWY(ulong val) : FWX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8FDA36405EB3218;
        }
    }

    class FWZ(ulong val) : FWY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21334156B40AB8A;
        }
    }

    class FXA(ulong val) : FWZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48FB0EA1B8A4EE9;
        }
    }

    class FXB(ulong val) : FXA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4350D2FD629EB3C;
        }
    }

    class FXC(ulong val) : FXB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x643117239453E82;
        }
    }

    class FXD(ulong val) : FXC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BC8ED99D986DE1;
        }
    }

    class FXE(ulong val) : FXD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x846A38DFC99A3C8;
        }
    }

    class FXF(ulong val) : FXE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F2E1A3832A0257;
        }
    }

    class FXG(ulong val) : FXF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FAF363A9C25159;
        }
    }

    class FXH(ulong val) : FXG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x927F651E79E1380;
        }
    }

    class FXI(ulong val) : FXH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1B2B42936FC19A1;
        }
    }

    class FXJ(ulong val) : FXI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2397A45D5E15C9F;
        }
    }

    class FXK(ulong val) : FXJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9759E8E468E8395;
        }
    }

    class FXL(ulong val) : FXK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F829747A748CAD;
        }
    }

    class FXM(ulong val) : FXL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x75EB180EE01F542;
        }
    }

    class FXN(ulong val) : FXM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8DCE61F8E88AFF3;
        }
    }

    class FXO(ulong val) : FXN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x837F96DFFD25907;
        }
    }

    class FXP(ulong val) : FXO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x844152C87CAE693;
        }
    }

    class FXQ(ulong val) : FXP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34F3397704A4E16;
        }
    }

    class FXR(ulong val) : FXQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8C411F8902916E6;
        }
    }

    class FXS(ulong val) : FXR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x139A5573F5A7AC6;
        }
    }

    class FXT(ulong val) : FXS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7CC436976BD9985;
        }
    }

    class FXU(ulong val) : FXT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29276B6A2CC973F;
        }
    }

    class FXV(ulong val) : FXU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x677E6164EC27B06;
        }
    }

    class FXW(ulong val) : FXV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x51CF5F34F1DFFE2;
        }
    }

    class FXX(ulong val) : FXW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x38B47705BC1CA29;
        }
    }

    class FXY(ulong val) : FXX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50BBC3AD33DF2D7;
        }
    }

    class FXZ(ulong val) : FXY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x423E940FFBEB9F3;
        }
    }

    class FYA(ulong val) : FXZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F9935D95323A78;
        }
    }

    class FYB(ulong val) : FYA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4245FE61A3612DE;
        }
    }

    class FYC(ulong val) : FYB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4AB518EBB57A850;
        }
    }

    class FYD(ulong val) : FYC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F412705557B626;
        }
    }

    class FYE(ulong val) : FYD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57EB589F8DE4B8D;
        }
    }

    class FYF(ulong val) : FYE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3328295005BE11F;
        }
    }

    class FYG(ulong val) : FYF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8ED4EBE969CBDBA;
        }
    }

    class FYH(ulong val) : FYG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31504BFDCBC68B2;
        }
    }

    class FYI(ulong val) : FYH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x537AEB9338664AB;
        }
    }

    class FYJ(ulong val) : FYI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1ECD8722225966A;
        }
    }

    class FYK(ulong val) : FYJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x46AA58277872588;
        }
    }

    class FYL(ulong val) : FYK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2D9A16F6AFCEF5C;
        }
    }

    class FYM(ulong val) : FYL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36AC05465B95C2F;
        }
    }

    class FYN(ulong val) : FYM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x940AEC451E80593;
        }
    }

    class FYO(ulong val) : FYN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62D5ECC577C2588;
        }
    }

    class FYP(ulong val) : FYO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x176BAC8BC014427;
        }
    }

    class FYQ(ulong val) : FYP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x54AD019B48EEB0F;
        }
    }

    class FYR(ulong val) : FYQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1073AE638F8B32C;
        }
    }

    class FYS(ulong val) : FYR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3132D6F95C5D2D5;
        }
    }

    class FYT(ulong val) : FYS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43B30FDC79F375C;
        }
    }

    class FYU(ulong val) : FYT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x322CE41FE64C4A7;
        }
    }

    class FYV(ulong val) : FYU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x53EF314C71D030B;
        }
    }

    class FYW(ulong val) : FYV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x38D32FAC1E3BC52;
        }
    }

    class FYX(ulong val) : FYW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7CDB454EFE5B7FD;
        }
    }

    class FYY(ulong val) : FYX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x633137DA7264019;
        }
    }

    class FYZ(ulong val) : FYY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x786E38131D784E5;
        }
    }

    class FZA(ulong val) : FYZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x68BBE6490667C38;
        }
    }

    class FZB(ulong val) : FZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x994C6F5658B166D;
        }
    }

    class FZC(ulong val) : FZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52F4A2F83EF41AD;
        }
    }

    class FZD(ulong val) : FZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x224A4A097DBEA15;
        }
    }

    class FZE(ulong val) : FZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x96BB16733CE18BF;
        }
    }

    class FZF(ulong val) : FZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x210341307CAA952;
        }
    }

    class FZG(ulong val) : FZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x75B85D2844AF314;
        }
    }

    class FZH(ulong val) : FZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x64CBAD3137F679F;
        }
    }

    class FZI(ulong val) : FZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BA0280F576F877;
        }
    }

    class FZJ(ulong val) : FZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x62469D6E59A1B68;
        }
    }

    class FZK(ulong val) : FZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x18E160B42BCC3FD;
        }
    }

    class FZL(ulong val) : FZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x443ACAB267A54F4;
        }
    }

    class FZM(ulong val) : FZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7817E6D666889B4;
        }
    }

    class FZN(ulong val) : FZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x78C826E6CD97FB7;
        }
    }

    class FZO(ulong val) : FZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8512E0BA1BF3C20;
        }
    }

    class FZP(ulong val) : FZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x66980FA94D39348;
        }
    }

    class FZQ(ulong val) : FZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4E9DD59FD728564;
        }
    }

    class FZR(ulong val) : FZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x52E8324ED5D79B0;
        }
    }

    class FZS(ulong val) : FZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4260C7336AC7C43;
        }
    }

    class FZT(ulong val) : FZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A0E2839B4FF033;
        }
    }

    class FZU(ulong val) : FZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1D69101C17D5E41;
        }
    }

    class FZV(ulong val) : FZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x364DBCDE6B3DC4A;
        }
    }

    class FZW(ulong val) : FZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CBD36B651B5F14;
        }
    }

    class FZX(ulong val) : FZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x36CF1E6638A617A;
        }
    }

    class FZY(ulong val) : FZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x566363A49C08BEA;
        }
    }

    class FZZ(ulong val) : FZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x69DB57297193B30;
        }
    }

    class GAA(ulong val) : FZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9547A2EFF37A325;
        }
    }

    class GAB(ulong val) : GAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x15094156A8089DB;
        }
    }

    class GAC(ulong val) : GAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B0EF8A2AAAEEDD;
        }
    }

    class GAD(ulong val) : GAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x150AB972967B665;
        }
    }

    class GAE(ulong val) : GAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2DA03A43F340436;
        }
    }

    class GAF(ulong val) : GAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E8DD7B6B7F7E3B;
        }
    }

    class GAG(ulong val) : GAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56C2C417E7DF40E;
        }
    }

    class GAH(ulong val) : GAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F38E7A13A122F3;
        }
    }

    class GAI(ulong val) : GAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6BD1C1EBA62B115;
        }
    }

    class GAJ(ulong val) : GAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x72153D03AD59918;
        }
    }

    class GAK(ulong val) : GAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C34A8426D1A5F3;
        }
    }

    class GAL(ulong val) : GAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x377DC6772AAFEA9;
        }
    }

    class GAM(ulong val) : GAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47A4E0AA0514913;
        }
    }

    class GAN(ulong val) : GAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6CEF407027C1622;
        }
    }

    class GAO(ulong val) : GAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x89500752E804D2A;
        }
    }

    class GAP(ulong val) : GAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2E18BF54AA6F5D7;
        }
    }

    class GAQ(ulong val) : GAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F670C7E474CD62;
        }
    }

    class GAR(ulong val) : GAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16030C8EC1DF214;
        }
    }

    class GAS(ulong val) : GAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9962CABF8CF34BF;
        }
    }

    class GAT(ulong val) : GAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2CEBF959F5FE672;
        }
    }

    class GAU(ulong val) : GAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x238AFAC291AE21A;
        }
    }

    class GAV(ulong val) : GAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C40BB51A256C65;
        }
    }

    class GAW(ulong val) : GAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x364314BDC2CCA6C;
        }
    }

    class GAX(ulong val) : GAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x890A0E8DAE4E073;
        }
    }

    class GAY(ulong val) : GAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x84BCC353FAF21BC;
        }
    }

    class GAZ(ulong val) : GAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E0760FC2BEFFA0;
        }
    }

    class GBA(ulong val) : GAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x710D191F187EDA9;
        }
    }

    class GBB(ulong val) : GBA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x575ED6DE9F84497;
        }
    }

    class GBC(ulong val) : GBB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x493D0A0C61520D6;
        }
    }

    class GBD(ulong val) : GBC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x289FAFD3FDB481E;
        }
    }

    class GBE(ulong val) : GBD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79987FE706DADCA;
        }
    }

    class GBF(ulong val) : GBE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x244307364E8FBAC;
        }
    }

    class GBG(ulong val) : GBF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D16CD78D27B209;
        }
    }

    class GBH(ulong val) : GBG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C9303170919E2A;
        }
    }

    class GBI(ulong val) : GBH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x872B3CC4376C812;
        }
    }

    class GBJ(ulong val) : GBI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x427D526D5BFC222;
        }
    }

    class GBK(ulong val) : GBJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x72E4C2539934F1E;
        }
    }

    class GBL(ulong val) : GBK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1EEBA9F53682392;
        }
    }

    class GBM(ulong val) : GBL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B5CC8EDBBEA675;
        }
    }

    class GBN(ulong val) : GBM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6A52173B4C8BAF4;
        }
    }

    class GBO(ulong val) : GBN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x622E23026F8C9FD;
        }
    }

    class GBP(ulong val) : GBO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16769591F7C4614;
        }
    }

    class GBQ(ulong val) : GBP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x88C78AFE893618F;
        }
    }

    class GBR(ulong val) : GBQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x22DA5DCF1B0F8D1;
        }
    }

    class GBS(ulong val) : GBR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5E2F2BFFAC24F63;
        }
    }

    class GBT(ulong val) : GBS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2687EBE05FA0A00;
        }
    }

    class GBU(ulong val) : GBT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x361AF4B2C0685AC;
        }
    }

    class GBV(ulong val) : GBU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x876639350D7DA10;
        }
    }

    class GBW(ulong val) : GBV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x542763069608C2A;
        }
    }

    class GBX(ulong val) : GBW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x62667C2B4F4C0BA;
        }
    }

    class GBY(ulong val) : GBX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x283A8E05CCD7209;
        }
    }

    class GBZ(ulong val) : GBY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x309A1F42C0EB871;
        }
    }

    class GCA(ulong val) : GBZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50A2DA2C9916763;
        }
    }

    class GCB(ulong val) : GCA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BB5021E6A11DB9;
        }
    }

    class GCC(ulong val) : GCB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5021CFC69AF7948;
        }
    }

    class GCD(ulong val) : GCC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7031EC555095138;
        }
    }

    class GCE(ulong val) : GCD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1732F6A01FC682D;
        }
    }

    class GCF(ulong val) : GCE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x46EDCF87FAA56DB;
        }
    }

    class GCG(ulong val) : GCF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8964A287C33ADE0;
        }
    }

    class GCH(ulong val) : GCG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x242DBA304CDD288;
        }
    }

    class GCI(ulong val) : GCH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x441D693101ED9D8;
        }
    }

    class GCJ(ulong val) : GCI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x128DB9225F461EE;
        }
    }

    class GCK(ulong val) : GCJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x173083FBF1B71F1;
        }
    }

    class GCL(ulong val) : GCK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x50AA955533BA68E;
        }
    }

    class GCM(ulong val) : GCL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x713B4279820C6FC;
        }
    }

    class GCN(ulong val) : GCM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4826367BFCB1DB1;
        }
    }

    class GCO(ulong val) : GCN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x993CF883F2CD21E;
        }
    }

    class GCP(ulong val) : GCO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x875F57CA96E5CE7;
        }
    }

    class GCQ(ulong val) : GCP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AADAB6980F237B;
        }
    }

    class GCR(ulong val) : GCQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x586C94C75847668;
        }
    }

    class GCS(ulong val) : GCR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4EE221025BCCD1A;
        }
    }

    class GCT(ulong val) : GCS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x98912783E7756B2;
        }
    }

    class GCU(ulong val) : GCT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6A11BEDC850BB92;
        }
    }

    class GCV(ulong val) : GCU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5B78E8CD90B3D42;
        }
    }

    class GCW(ulong val) : GCV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7F9B72F7CEDE473;
        }
    }

    class GCX(ulong val) : GCW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61F0176D03BC18B;
        }
    }

    class GCY(ulong val) : GCX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C7AE02DCB2FB59;
        }
    }

    class GCZ(ulong val) : GCY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4313D14B9AF07B7;
        }
    }

    class GDA(ulong val) : GCZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5E27EFAD869254E;
        }
    }

    class GDB(ulong val) : GDA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x990FD5D425020D9;
        }
    }

    class GDC(ulong val) : GDB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6340C7CDD595D8E;
        }
    }

    class GDD(ulong val) : GDC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A97C043FF3A604;
        }
    }

    class GDE(ulong val) : GDD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4009B18EB769C28;
        }
    }

    class GDF(ulong val) : GDE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E7B6BA3F87CA98;
        }
    }

    class GDG(ulong val) : GDF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3C82DF5E2E99674;
        }
    }

    class GDH(ulong val) : GDG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x361842F405CC693;
        }
    }

    class GDI(ulong val) : GDH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5F0B07974B82849;
        }
    }

    class GDJ(ulong val) : GDI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x18261D30F0B257C;
        }
    }

    class GDK(ulong val) : GDJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x18413C69B521AC6;
        }
    }

    class GDL(ulong val) : GDK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1C11488BC071F8B;
        }
    }

    class GDM(ulong val) : GDL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3BC458E7897FCE0;
        }
    }

    class GDN(ulong val) : GDM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2959CD22121CC4D;
        }
    }

    class GDO(ulong val) : GDN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x66C6A3AC00D7E66;
        }
    }

    class GDP(ulong val) : GDO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23F0295A7267239;
        }
    }

    class GDQ(ulong val) : GDP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3BB7F6DEC287359;
        }
    }

    class GDR(ulong val) : GDQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x231C753A1CD0DEC;
        }
    }

    class GDS(ulong val) : GDR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36491FBC0FA6512;
        }
    }

    class GDT(ulong val) : GDS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5562D4DC47C020D;
        }
    }

    class GDU(ulong val) : GDT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68899479B7B8C16;
        }
    }

    class GDV(ulong val) : GDU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2DC63E0A548A899;
        }
    }

    class GDW(ulong val) : GDV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7F05F56922CF04F;
        }
    }

    class GDX(ulong val) : GDW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x887AC593FB6CFDD;
        }
    }

    class GDY(ulong val) : GDX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31D26D90AA29D1F;
        }
    }

    class GDZ(ulong val) : GDY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AEA04DF8E0E401;
        }
    }

    class GEA(ulong val) : GDZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9358CBE317BC7D5;
        }
    }

    class GEB(ulong val) : GEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x31DED8294A28F48;
        }
    }

    class GEC(ulong val) : GEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x280631013B629F6;
        }
    }

    class GED(ulong val) : GEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7BCCDCA08467354;
        }
    }

    class GEE(ulong val) : GED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C8754F0EF3B525;
        }
    }

    class GEF(ulong val) : GEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x81BA1A988482465;
        }
    }

    class GEG(ulong val) : GEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8F13CB21A9DE227;
        }
    }

    class GEH(ulong val) : GEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88C6B8445B75092;
        }
    }

    class GEI(ulong val) : GEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6590BC7CFA2B208;
        }
    }

    class GEJ(ulong val) : GEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1AB7B68A28602E2;
        }
    }

    class GEK(ulong val) : GEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2D11B964E7009A2;
        }
    }

    class GEL(ulong val) : GEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2A32A867E9232CF;
        }
    }

    class GEM(ulong val) : GEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x43C77373B0B1239;
        }
    }

    class GEN(ulong val) : GEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5696803AB86FD3D;
        }
    }

    class GEO(ulong val) : GEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6781DB275530354;
        }
    }

    class GEP(ulong val) : GEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1CAAC4EBA1EA483;
        }
    }

    class GEQ(ulong val) : GEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3716A53FB1886AB;
        }
    }

    class GER(ulong val) : GEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x711C549C21B9840;
        }
    }

    class GES(ulong val) : GER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x708A2FEB2B1FCD8;
        }
    }

    class GET(ulong val) : GES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5D1EFA3A47D9A32;
        }
    }

    class GEU(ulong val) : GET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1A5015AC709C840;
        }
    }

    class GEV(ulong val) : GEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x990CB33D15919CD;
        }
    }

    class GEW(ulong val) : GEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3480C043E4130E9;
        }
    }

    class GEX(ulong val) : GEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x99206C2E7138892;
        }
    }

    class GEY(ulong val) : GEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53282DE85943152;
        }
    }

    class GEZ(ulong val) : GEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4F314CA5A599F20;
        }
    }

    class GFA(ulong val) : GEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x67A15A36DBFE291;
        }
    }

    class GFB(ulong val) : GFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12338214B13D26E;
        }
    }

    class GFC(ulong val) : GFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27E8FBD39480F5C;
        }
    }

    class GFD(ulong val) : GFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4D46B53AF8DE701;
        }
    }

    class GFE(ulong val) : GFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x42EB14BE51B5C14;
        }
    }

    class GFF(ulong val) : GFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C55819DBACEA42;
        }
    }

    class GFG(ulong val) : GFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4EFC48C0D471D44;
        }
    }

    class GFH(ulong val) : GFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50C25DBBFFD526F;
        }
    }

    class GFI(ulong val) : GFH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x97652F9A9DCC7A6;
        }
    }

    class GFJ(ulong val) : GFI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x81996291C5271CF;
        }
    }

    class GFK(ulong val) : GFJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8014DE1054BFFC5;
        }
    }

    class GFL(ulong val) : GFK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63E330AACD81927;
        }
    }

    class GFM(ulong val) : GFL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x13984EADC7128B5;
        }
    }

    class GFN(ulong val) : GFM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F985D047C76CAA;
        }
    }

    class GFO(ulong val) : GFN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2F353345492D270;
        }
    }

    class GFP(ulong val) : GFO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x10F8D8D539D4CFE;
        }
    }

    class GFQ(ulong val) : GFP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35890042C4F0E8D;
        }
    }

    class GFR(ulong val) : GFQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x421A3F0AA6DC036;
        }
    }

    class GFS(ulong val) : GFR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x113E184D2FCA57E;
        }
    }

    class GFT(ulong val) : GFS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8E5C919993BB8B0;
        }
    }

    class GFU(ulong val) : GFT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x716F063CD9C7763;
        }
    }

    class GFV(ulong val) : GFU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E3DBADA7741BDF;
        }
    }

    class GFW(ulong val) : GFV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x90CC77F5ECAB002;
        }
    }

    class GFX(ulong val) : GFW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82E23CE068B214B;
        }
    }

    class GFY(ulong val) : GFX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x46EFF20FF022A5F;
        }
    }

    class GFZ(ulong val) : GFY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8B18112A92C397D;
        }
    }

    class GGA(ulong val) : GFZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D2F28F8BA62D57;
        }
    }

    class GGB(ulong val) : GGA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3DB2911210486D1;
        }
    }

    class GGC(ulong val) : GGB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B7B3B7230200FC;
        }
    }

    class GGD(ulong val) : GGC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4327695F2BBEC47;
        }
    }

    class GGE(ulong val) : GGD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2AB9F824C222238;
        }
    }

    class GGF(ulong val) : GGE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34C1A655EF5A635;
        }
    }

    class GGG(ulong val) : GGF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47EE5C930A975FB;
        }
    }

    class GGH(ulong val) : GGG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7C345E2975020FB;
        }
    }

    class GGI(ulong val) : GGH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6B824E8030A4FB2;
        }
    }

    class GGJ(ulong val) : GGI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3FD2726612D2D6A;
        }
    }

    class GGK(ulong val) : GGJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2FE7B39FF812B4F;
        }
    }

    class GGL(ulong val) : GGK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x145ECD89CCC064E;
        }
    }

    class GGM(ulong val) : GGL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34D524709447184;
        }
    }

    class GGN(ulong val) : GGM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x363615C0C1B30B4;
        }
    }

    class GGO(ulong val) : GGN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7FA0AE59C46E1A4;
        }
    }

    class GGP(ulong val) : GGO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x62CA0DAA4A9C231;
        }
    }

    class GGQ(ulong val) : GGP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7ED58E7E4D66A06;
        }
    }

    class GGR(ulong val) : GGQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34A7EA09A7352E2;
        }
    }

    class GGS(ulong val) : GGR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x416F0094EC390EF;
        }
    }

    class GGT(ulong val) : GGS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D39D7B30C3BDF6;
        }
    }

    class GGU(ulong val) : GGT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x465E1CE6C2FBC54;
        }
    }

    class GGV(ulong val) : GGU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x645A570F85A2DB2;
        }
    }

    class GGW(ulong val) : GGV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x38A86030F2AD711;
        }
    }

    class GGX(ulong val) : GGW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x22C366E53238AD6;
        }
    }

    class GGY(ulong val) : GGX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x33D29F04EED23D9;
        }
    }

    class GGZ(ulong val) : GGY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x482C537114F6236;
        }
    }

    class GHA(ulong val) : GGZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8CD158E6BD05AB9;
        }
    }

    class GHB(ulong val) : GHA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F860A4A01275F6;
        }
    }

    class GHC(ulong val) : GHB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5AA4E0B13B68CE9;
        }
    }

    class GHD(ulong val) : GHC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1F45611141196DB;
        }
    }

    class GHE(ulong val) : GHD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x762ECB1EC8CCE34;
        }
    }

    class GHF(ulong val) : GHE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15FC5184F6DC4C4;
        }
    }

    class GHG(ulong val) : GHF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3AF4627F00CA823;
        }
    }

    class GHH(ulong val) : GHG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x77A5CD198809C20;
        }
    }

    class GHI(ulong val) : GHH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9383EBB8D34CF85;
        }
    }

    class GHJ(ulong val) : GHI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6869191A052D6ED;
        }
    }

    class GHK(ulong val) : GHJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1DF0BDAAA71F2F5;
        }
    }

    class GHL(ulong val) : GHK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x405A9CE1FD78BE3;
        }
    }

    class GHM(ulong val) : GHL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x52BCFBAB0A7A62E;
        }
    }

    class GHN(ulong val) : GHM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1405CD6A3F497F1;
        }
    }

    class GHO(ulong val) : GHN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8FB915BEADCBABB;
        }
    }

    class GHP(ulong val) : GHO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7350C0302216DBE;
        }
    }

    class GHQ(ulong val) : GHP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x13414DADF93F6D6;
        }
    }

    class GHR(ulong val) : GHQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x24A4789F0929DBE;
        }
    }

    class GHS(ulong val) : GHR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C4DA4166565823;
        }
    }

    class GHT(ulong val) : GHS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26578027A204946;
        }
    }

    class GHU(ulong val) : GHT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73D10057DD988EA;
        }
    }

    class GHV(ulong val) : GHU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C612736BFA956D;
        }
    }

    class GHW(ulong val) : GHV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6EBB8053A650E30;
        }
    }

    class GHX(ulong val) : GHW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6D65A2831321BFC;
        }
    }

    class GHY(ulong val) : GHX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A253DB5D274986;
        }
    }

    class GHZ(ulong val) : GHY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4F2F059F19059EE;
        }
    }

    class GIA(ulong val) : GHZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5D4FA11B4935FCC;
        }
    }

    class GIB(ulong val) : GIA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x210D020F2F5462B;
        }
    }

    class GIC(ulong val) : GIB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x845322179514D0A;
        }
    }

    class GID(ulong val) : GIC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3702878C96F6478;
        }
    }

    class GIE(ulong val) : GID(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8857F4D132FDBE8;
        }
    }

    class GIF(ulong val) : GIE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85808A2607734C3;
        }
    }

    class GIG(ulong val) : GIF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x712408971C71D62;
        }
    }

    class GIH(ulong val) : GIG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x65A89DDA0E8B727;
        }
    }

    class GII(ulong val) : GIH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A68C5F8CE06CF9;
        }
    }

    class GIJ(ulong val) : GII(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2791FFF32D4743C;
        }
    }

    class GIK(ulong val) : GIJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x841D12916E9719E;
        }
    }

    class GIL(ulong val) : GIK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2EE2A032B58FA5D;
        }
    }

    class GIM(ulong val) : GIL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94440529F8D10E3;
        }
    }

    class GIN(ulong val) : GIM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x16048B444E68B05;
        }
    }

    class GIO(ulong val) : GIN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8B2604E93518521;
        }
    }

    class GIP(ulong val) : GIO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2EA3BE7799F4942;
        }
    }

    class GIQ(ulong val) : GIP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x953AAC174E708E3;
        }
    }

    class GIR(ulong val) : GIQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x325EFD6CE3C7054;
        }
    }

    class GIS(ulong val) : GIR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53EBB96E64CC58E;
        }
    }

    class GIT(ulong val) : GIS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x965E41ED400F7D3;
        }
    }

    class GIU(ulong val) : GIT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x845716862505C67;
        }
    }

    class GIV(ulong val) : GIU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2C799F0629C1895;
        }
    }

    class GIW(ulong val) : GIV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5115B82DDB2F2EA;
        }
    }

    class GIX(ulong val) : GIW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1AD7C42E0EAF82F;
        }
    }

    class GIY(ulong val) : GIX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x912E359A9622219;
        }
    }

    class GIZ(ulong val) : GIY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20D12DF61A2D0C3;
        }
    }

    class GJA(ulong val) : GIZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2106EB42E867267;
        }
    }

    class GJB(ulong val) : GJA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x35A7BD7622F038A;
        }
    }

    class GJC(ulong val) : GJB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x505C2360FC431B0;
        }
    }

    class GJD(ulong val) : GJC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x905424E28B20663;
        }
    }

    class GJE(ulong val) : GJD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x112C8A8635F3FC3;
        }
    }

    class GJF(ulong val) : GJE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2595B81F6318DEB;
        }
    }

    class GJG(ulong val) : GJF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49AB77C294CB0F7;
        }
    }

    class GJH(ulong val) : GJG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88D9CA752BF32F0;
        }
    }

    class GJI(ulong val) : GJH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E3CD99F07F780A;
        }
    }

    class GJJ(ulong val) : GJI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x71FF0EB6B3BE38E;
        }
    }

    class GJK(ulong val) : GJJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x24548D955ABE9C9;
        }
    }

    class GJL(ulong val) : GJK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2B3223E4E96D872;
        }
    }

    class GJM(ulong val) : GJL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56619CD7C540C0C;
        }
    }

    class GJN(ulong val) : GJM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8520B3F9691605D;
        }
    }

    class GJO(ulong val) : GJN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x51B50135B2AC834;
        }
    }

    class GJP(ulong val) : GJO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x32085D1A146DBF7;
        }
    }

    class GJQ(ulong val) : GJP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x28567A588FBB4DB;
        }
    }

    class GJR(ulong val) : GJQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17F22185D96261B;
        }
    }

    class GJS(ulong val) : GJR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55049E48014896B;
        }
    }

    class GJT(ulong val) : GJS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F9486A3F9383E9;
        }
    }

    class GJU(ulong val) : GJT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3054061D2E02403;
        }
    }

    class GJV(ulong val) : GJU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x22A2CE5D37E516A;
        }
    }

    class GJW(ulong val) : GJV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8158DA890F3A4BD;
        }
    }

    class GJX(ulong val) : GJW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x243FB4CF9D2664B;
        }
    }

    class GJY(ulong val) : GJX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x889B9ADA64820F0;
        }
    }

    class GJZ(ulong val) : GJY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8FF6087158F2A29;
        }
    }

    class GKA(ulong val) : GJZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1EECE8AC24D29EB;
        }
    }

    class GKB(ulong val) : GKA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B1B5F5B6A58248;
        }
    }

    class GKC(ulong val) : GKB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23BA37E1D83063F;
        }
    }

    class GKD(ulong val) : GKC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x41963678B4D393C;
        }
    }

    class GKE(ulong val) : GKD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6333E2C817686E5;
        }
    }

    class GKF(ulong val) : GKE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8C034FD141F27D8;
        }
    }

    class GKG(ulong val) : GKF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B57C53FA27A769;
        }
    }

    class GKH(ulong val) : GKG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92052B74556AC88;
        }
    }

    class GKI(ulong val) : GKH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x51BECB01389FCFE;
        }
    }

    class GKJ(ulong val) : GKI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6313C4D1F07FD3B;
        }
    }

    class GKK(ulong val) : GKJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x60135C91A013721;
        }
    }

    class GKL(ulong val) : GKK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2284D242BFDF541;
        }
    }

    class GKM(ulong val) : GKL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63B2B414918E3F9;
        }
    }

    class GKN(ulong val) : GKM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7A243EB99895E82;
        }
    }

    class GKO(ulong val) : GKN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7CCC5075FC17B7A;
        }
    }

    class GKP(ulong val) : GKO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4F5313D42B5A6BC;
        }
    }

    class GKQ(ulong val) : GKP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21A771D83B58CF7;
        }
    }

    class GKR(ulong val) : GKQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6B54449B287DF58;
        }
    }

    class GKS(ulong val) : GKR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78D51718F234F4D;
        }
    }

    class GKT(ulong val) : GKS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x65E5C31DDF35247;
        }
    }

    class GKU(ulong val) : GKT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6017F7429D12394;
        }
    }

    class GKV(ulong val) : GKU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5C124C1CF03F842;
        }
    }

    class GKW(ulong val) : GKV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42D061BF0715927;
        }
    }

    class GKX(ulong val) : GKW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56B4647A2634411;
        }
    }

    class GKY(ulong val) : GKX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5BB8F3017EE6930;
        }
    }

    class GKZ(ulong val) : GKY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x327781E565D941F;
        }
    }

    class GLA(ulong val) : GKZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x535D1780732ECE2;
        }
    }

    class GLB(ulong val) : GLA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x890264CD28CABBA;
        }
    }

    class GLC(ulong val) : GLB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x171AE208DBE8D04;
        }
    }

    class GLD(ulong val) : GLC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x417E6D8D4813518;
        }
    }

    class GLE(ulong val) : GLD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x152DBC89D329C3E;
        }
    }

    class GLF(ulong val) : GLE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x83941C1E3058766;
        }
    }

    class GLG(ulong val) : GLF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3EA17A2AA397381;
        }
    }

    class GLH(ulong val) : GLG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x64A48F130B809AF;
        }
    }

    class GLI(ulong val) : GLH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6A2F4DDDACB31D2;
        }
    }

    class GLJ(ulong val) : GLI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x38B441815D4797A;
        }
    }

    class GLK(ulong val) : GLJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3CE4FDB6A0CAF3D;
        }
    }

    class GLL(ulong val) : GLK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D56CB1463D89BE;
        }
    }

    class GLM(ulong val) : GLL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x89527C1EBFE4F50;
        }
    }

    class GLN(ulong val) : GLM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x47860BE3529643D;
        }
    }

    class GLO(ulong val) : GLN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x655CDE7ADAF1505;
        }
    }

    class GLP(ulong val) : GLO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7B5256108F2D26A;
        }
    }

    class GLQ(ulong val) : GLP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3CEC5D25BD6E920;
        }
    }

    class GLR(ulong val) : GLQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x352A96CF15AE322;
        }
    }

    class GLS(ulong val) : GLR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x22542EBEAD12B7A;
        }
    }

    class GLT(ulong val) : GLS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x170D6127B4066BD;
        }
    }

    class GLU(ulong val) : GLT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B537CD1814BEF3;
        }
    }

    class GLV(ulong val) : GLU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x534C5C85FE7AC1F;
        }
    }

    class GLW(ulong val) : GLV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x63B6BAC55C25178;
        }
    }

    class GLX(ulong val) : GLW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x964D08868E37399;
        }
    }

    class GLY(ulong val) : GLX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x675127C23473261;
        }
    }

    class GLZ(ulong val) : GLY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D981A213FC20CF;
        }
    }

    class GMA(ulong val) : GLZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11A4AF43A7AC22D;
        }
    }

    class GMB(ulong val) : GMA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x438638E58222EA8;
        }
    }

    class GMC(ulong val) : GMB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x703658A826B69B1;
        }
    }

    class GMD(ulong val) : GMC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x503EFBD4438E917;
        }
    }

    class GME(ulong val) : GMD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x677E83CF42236BC;
        }
    }

    class GMF(ulong val) : GME(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x741D9FB28EEC50A;
        }
    }

    class GMG(ulong val) : GMF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4EF89CA3F9DCF9F;
        }
    }

    class GMH(ulong val) : GMG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9141A533B598469;
        }
    }

    class GMI(ulong val) : GMH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B2DCDE9DF6F4F3;
        }
    }

    class GMJ(ulong val) : GMI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x61C862357FA8914;
        }
    }

    class GMK(ulong val) : GMJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x44C99D4B5B1148F;
        }
    }

    class GML(ulong val) : GMK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4028E1F34FD764F;
        }
    }

    class GMM(ulong val) : GML(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9829C14CB1C8AB5;
        }
    }

    class GMN(ulong val) : GMM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x827267A0F3A0AEC;
        }
    }

    class GMO(ulong val) : GMN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8A695EA5280E005;
        }
    }

    class GMP(ulong val) : GMO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B59582856D7385;
        }
    }

    class GMQ(ulong val) : GMP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x802FF734DE7A64C;
        }
    }

    class GMR(ulong val) : GMQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7B5C66119F5C5C1;
        }
    }

    class GMS(ulong val) : GMR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77060DDE2D18563;
        }
    }

    class GMT(ulong val) : GMS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x310D0DED91FF7E5;
        }
    }

    class GMU(ulong val) : GMT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x863BD8578069542;
        }
    }

    class GMV(ulong val) : GMU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D78EDE9CB15849;
        }
    }

    class GMW(ulong val) : GMV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2DFFD360BD2D03E;
        }
    }

    class GMX(ulong val) : GMW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x167A0C5DF6D9814;
        }
    }

    class GMY(ulong val) : GMX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1F44C36E6E323E9;
        }
    }

    class GMZ(ulong val) : GMY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F63DF86F141DA0;
        }
    }

    class GNA(ulong val) : GMZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x498A04D7DC4A1EC;
        }
    }

    class GNB(ulong val) : GNA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5117AE78B0C1ACF;
        }
    }

    class GNC(ulong val) : GNB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C24065C6AF5F45;
        }
    }

    class GND(ulong val) : GNC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6BDA3DB51C252DA;
        }
    }

    class GNE(ulong val) : GND(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29C04D6AC2131A6;
        }
    }

    class GNF(ulong val) : GNE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1DE1F0BB0A2BE34;
        }
    }

    class GNG(ulong val) : GNF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3502971084242B1;
        }
    }

    class GNH(ulong val) : GNG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42F374F86170895;
        }
    }

    class GNI(ulong val) : GNH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x59C937336ADAAED;
        }
    }

    class GNJ(ulong val) : GNI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8C422125446BF0E;
        }
    }

    class GNK(ulong val) : GNJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82DB10D623A6649;
        }
    }

    class GNL(ulong val) : GNK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x43B050E056760FA;
        }
    }

    class GNM(ulong val) : GNL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5FD51707E1734CE;
        }
    }

    class GNN(ulong val) : GNM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D2AFED2381517C;
        }
    }

    class GNO(ulong val) : GNN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4564BF6D59F356C;
        }
    }

    class GNP(ulong val) : GNO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x32A520445A13117;
        }
    }

    class GNQ(ulong val) : GNP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x58EBC624C3126DB;
        }
    }

    class GNR(ulong val) : GNQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7994ECAF8D0F610;
        }
    }

    class GNS(ulong val) : GNR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85B724E9E5BD2C7;
        }
    }

    class GNT(ulong val) : GNS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C5EE11858636E3;
        }
    }

    class GNU(ulong val) : GNT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x38CC5501A5270EA;
        }
    }

    class GNV(ulong val) : GNU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4B49064BFADE34E;
        }
    }

    class GNW(ulong val) : GNV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3D108D5EE87F427;
        }
    }

    class GNX(ulong val) : GNW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5203A3C983062EC;
        }
    }

    class GNY(ulong val) : GNX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7779B96232F14EE;
        }
    }

    class GNZ(ulong val) : GNY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x421492C344C5EA8;
        }
    }

    class GOA(ulong val) : GNZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x32F1B1A065BC7C7;
        }
    }

    class GOB(ulong val) : GOA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16F112EA8FB892A;
        }
    }

    class GOC(ulong val) : GOB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x48A4CAF3AE25F3F;
        }
    }

    class GOD(ulong val) : GOC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5F1DEE66543E81D;
        }
    }

    class GOE(ulong val) : GOD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86BF3D1B7A207A1;
        }
    }

    class GOF(ulong val) : GOE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x153A7035F330AF8;
        }
    }

    class GOG(ulong val) : GOF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3D038F5FA29479A;
        }
    }

    class GOH(ulong val) : GOG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8129B80C9E1EA95;
        }
    }

    class GOI(ulong val) : GOH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x727AED1F74CF2A0;
        }
    }

    class GOJ(ulong val) : GOI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x109099BFAE93BF8;
        }
    }

    class GOK(ulong val) : GOJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x35A7920ADE32D0A;
        }
    }

    class GOL(ulong val) : GOK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x916F39F50A38870;
        }
    }

    class GOM(ulong val) : GOL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x56ABD468A494794;
        }
    }

    class GON(ulong val) : GOM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x783CB533E3C7B1B;
        }
    }

    class GOO(ulong val) : GON(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4BB660B4917497A;
        }
    }

    class GOP(ulong val) : GOO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1B9280C8EA35837;
        }
    }

    class GOQ(ulong val) : GOP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7946BCEA7FF1251;
        }
    }

    class GOR(ulong val) : GOQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x62BF73EB8948EAF;
        }
    }

    class GOS(ulong val) : GOR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3A67A110F56CF43;
        }
    }

    class GOT(ulong val) : GOS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x95307408EDEC908;
        }
    }

    class GOU(ulong val) : GOT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x11DA69435BF00D9;
        }
    }

    class GOV(ulong val) : GOU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9276468AD0DDD4D;
        }
    }

    class GOW(ulong val) : GOV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x77F1048C21368CC;
        }
    }

    class GOX(ulong val) : GOW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5467E07CAE0BA2B;
        }
    }

    class GOY(ulong val) : GOX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x837ADA27708A897;
        }
    }

    class GOZ(ulong val) : GOY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8130DCD756DBA48;
        }
    }

    class GPA(ulong val) : GOZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29DB203A113900C;
        }
    }

    class GPB(ulong val) : GPA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x551E87B9E48BF2C;
        }
    }

    class GPC(ulong val) : GPB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x56A69B8552918E5;
        }
    }

    class GPD(ulong val) : GPC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39FB494370A48F1;
        }
    }

    class GPE(ulong val) : GPD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8F276E2006AC452;
        }
    }

    class GPF(ulong val) : GPE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1086571E69FF535;
        }
    }

    class GPG(ulong val) : GPF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x619FA57D69707EE;
        }
    }

    class GPH(ulong val) : GPG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6DCA7AA0300BD72;
        }
    }

    class GPI(ulong val) : GPH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x9047635AD8936AD;
        }
    }

    class GPJ(ulong val) : GPI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x13C894E19FA03E1;
        }
    }

    class GPK(ulong val) : GPJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6535D965B69CB60;
        }
    }

    class GPL(ulong val) : GPK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1E6C113072B4BDE;
        }
    }

    class GPM(ulong val) : GPL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x53AC25461420BD5;
        }
    }

    class GPN(ulong val) : GPM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x91FAC837C20A7F5;
        }
    }

    class GPO(ulong val) : GPN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x997DDBCFB3A3216;
        }
    }

    class GPP(ulong val) : GPO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DE324BA6E35C58;
        }
    }

    class GPQ(ulong val) : GPP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x761305CA2E1B086;
        }
    }

    class GPR(ulong val) : GPQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x906AFCFE3826D7E;
        }
    }

    class GPS(ulong val) : GPR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x516B92F879A6841;
        }
    }

    class GPT(ulong val) : GPS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1695303FB49CD14;
        }
    }

    class GPU(ulong val) : GPT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x649CAFB55E919B2;
        }
    }

    class GPV(ulong val) : GPU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x38F787359E63BF3;
        }
    }

    class GPW(ulong val) : GPV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2368CA82408D62D;
        }
    }

    class GPX(ulong val) : GPW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1CABFA5EAFC7A20;
        }
    }

    class GPY(ulong val) : GPX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9047741E0142441;
        }
    }

    class GPZ(ulong val) : GPY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x929C5881E48A86E;
        }
    }

    class GQA(ulong val) : GPZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3521EC110E5FD39;
        }
    }

    class GQB(ulong val) : GQA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79A725333E43155;
        }
    }

    class GQC(ulong val) : GQB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86411C0C4184A35;
        }
    }

    class GQD(ulong val) : GQC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x851CB5B6A35381E;
        }
    }

    class GQE(ulong val) : GQD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62003E1D4BA8FF1;
        }
    }

    class GQF(ulong val) : GQE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x57039989DBBB3DC;
        }
    }

    class GQG(ulong val) : GQF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7DE6D5613296693;
        }
    }

    class GQH(ulong val) : GQG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6FB46457483FF28;
        }
    }

    class GQI(ulong val) : GQH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8B1C7CABF6FB6D9;
        }
    }

    class GQJ(ulong val) : GQI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x48A875E3CFC827B;
        }
    }

    class GQK(ulong val) : GQJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x61BBF9685AEA3C8;
        }
    }

    class GQL(ulong val) : GQK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B6056F74456FBF;
        }
    }

    class GQM(ulong val) : GQL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x381ED4D7462B17C;
        }
    }

    class GQN(ulong val) : GQM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x523E79AF5816F03;
        }
    }

    class GQO(ulong val) : GQN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x47508E9931EE4CB;
        }
    }

    class GQP(ulong val) : GQO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F7372DC5C936BD;
        }
    }

    class GQQ(ulong val) : GQP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1293F277635F78A;
        }
    }

    class GQR(ulong val) : GQQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8BFD2866FBE0582;
        }
    }

    class GQS(ulong val) : GQR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x44727DB9CA327FF;
        }
    }

    class GQT(ulong val) : GQS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61D49A1320DBC44;
        }
    }

    class GQU(ulong val) : GQT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2100F61ED33FEBC;
        }
    }

    class GQV(ulong val) : GQU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B899A4129C540D;
        }
    }

    class GQW(ulong val) : GQV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35C4F9DD56AB79D;
        }
    }

    class GQX(ulong val) : GQW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x33AD7CF642ABAAF;
        }
    }

    class GQY(ulong val) : GQX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1D51E35CA09FA3E;
        }
    }

    class GQZ(ulong val) : GQY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17060C3BF6A992B;
        }
    }

    class GRA(ulong val) : GQZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x911E5510805D04C;
        }
    }

    class GRB(ulong val) : GRA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x943148E4D84ADD6;
        }
    }

    class GRC(ulong val) : GRB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x51B5656D61E3719;
        }
    }

    class GRD(ulong val) : GRC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x806FD19F15A1180;
        }
    }

    class GRE(ulong val) : GRD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54BA453CAAE59FD;
        }
    }

    class GRF(ulong val) : GRE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x691C2BF7BB821A7;
        }
    }

    class GRG(ulong val) : GRF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3F5C3942D669B71;
        }
    }

    class GRH(ulong val) : GRG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x93215F90928F30F;
        }
    }

    class GRI(ulong val) : GRH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x35C3D82B9E5DA6B;
        }
    }

    class GRJ(ulong val) : GRI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x773C2C7E219D181;
        }
    }

    class GRK(ulong val) : GRJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5DA51203F468564;
        }
    }

    class GRL(ulong val) : GRK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8EABB72EF36A8E2;
        }
    }

    class GRM(ulong val) : GRL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3E0D6233A361E3D;
        }
    }

    class GRN(ulong val) : GRM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7BD84C5A4358D5D;
        }
    }

    class GRO(ulong val) : GRN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x35A7208AEF2C435;
        }
    }

    class GRP(ulong val) : GRO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x815CE3369FADF0B;
        }
    }

    class GRQ(ulong val) : GRP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6D2A4196512A65F;
        }
    }

    class GRR(ulong val) : GRQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x990C4C79083DF63;
        }
    }

    class GRS(ulong val) : GRR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x738B5AD39C52238;
        }
    }

    class GRT(ulong val) : GRS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6602A0ED2ABCB2B;
        }
    }

    class GRU(ulong val) : GRT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43310C48FFE9735;
        }
    }

    class GRV(ulong val) : GRU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x39E3E773B43E57B;
        }
    }

    class GRW(ulong val) : GRV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x10828A685087986;
        }
    }

    class GRX(ulong val) : GRW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x86A936ED8A1FB28;
        }
    }

    class GRY(ulong val) : GRX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x680B79796C14455;
        }
    }

    class GRZ(ulong val) : GRY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x40C55808669B301;
        }
    }

    class GSA(ulong val) : GRZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x77CA86218CC2FC7;
        }
    }

    class GSB(ulong val) : GSA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E7F644ABEA6871;
        }
    }

    class GSC(ulong val) : GSB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4C6F24E53538064;
        }
    }

    class GSD(ulong val) : GSC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7010CCC745AF328;
        }
    }

    class GSE(ulong val) : GSD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x42D45A0DBB851FE;
        }
    }

    class GSF(ulong val) : GSE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68D99E41666886A;
        }
    }

    class GSG(ulong val) : GSF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1BD4216299C79C7;
        }
    }

    class GSH(ulong val) : GSG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6E7D6DCD8BCD6B6;
        }
    }

    class GSI(ulong val) : GSH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x84DF6A43550D779;
        }
    }

    class GSJ(ulong val) : GSI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x542A5C3CB52D116;
        }
    }

    class GSK(ulong val) : GSJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68999A5A0EEBBE1;
        }
    }

    class GSL(ulong val) : GSK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8006CDE37E7BD5B;
        }
    }

    class GSM(ulong val) : GSL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6AA7B6639068B53;
        }
    }

    class GSN(ulong val) : GSM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C47C8BADD840F2;
        }
    }

    class GSO(ulong val) : GSN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x43427B445508BEC;
        }
    }

    class GSP(ulong val) : GSO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x53E971AAD738689;
        }
    }

    class GSQ(ulong val) : GSP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x52934DE68834450;
        }
    }

    class GSR(ulong val) : GSQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x93F18EFE5865494;
        }
    }

    class GSS(ulong val) : GSR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x82589E2C7F61AC6;
        }
    }

    class GST(ulong val) : GSS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2193EDD870E11CF;
        }
    }

    class GSU(ulong val) : GST(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2BCE7523C6CC7C8;
        }
    }

    class GSV(ulong val) : GSU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2EDD0967AF3486D;
        }
    }

    class GSW(ulong val) : GSV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61612A46B7687F4;
        }
    }

    class GSX(ulong val) : GSW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7DF99B28676575E;
        }
    }

    class GSY(ulong val) : GSX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x181353513FC22F1;
        }
    }

    class GSZ(ulong val) : GSY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B5924532D66F3C;
        }
    }

    class GTA(ulong val) : GSZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x523F9319A354C25;
        }
    }

    class GTB(ulong val) : GTA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x77DDE9D8DFA39FF;
        }
    }

    class GTC(ulong val) : GTB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F3393EDCBA46FE;
        }
    }

    class GTD(ulong val) : GTC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x11184338FE145EF;
        }
    }

    class GTE(ulong val) : GTD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6018F9C458B8834;
        }
    }

    class GTF(ulong val) : GTE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x53FA1D7CF9DB60A;
        }
    }

    class GTG(ulong val) : GTF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6C2457D0506B075;
        }
    }

    class GTH(ulong val) : GTG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x790A33CB3706510;
        }
    }

    class GTI(ulong val) : GTH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87677F97E81C9EB;
        }
    }

    class GTJ(ulong val) : GTI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D71704636A2588;
        }
    }

    class GTK(ulong val) : GTJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x18A5DD2FBDFB706;
        }
    }

    class GTL(ulong val) : GTK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x76D8A4AAE96A6BF;
        }
    }

    class GTM(ulong val) : GTL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20E2C19159439F5;
        }
    }

    class GTN(ulong val) : GTM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73F9A40B1393E7C;
        }
    }

    class GTO(ulong val) : GTN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17D5846771955DB;
        }
    }

    class GTP(ulong val) : GTO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5166186D8711FE4;
        }
    }

    class GTQ(ulong val) : GTP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x217FB142395DA72;
        }
    }

    class GTR(ulong val) : GTQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5DD421075B18192;
        }
    }

    class GTS(ulong val) : GTR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x133EA1755525796;
        }
    }

    class GTT(ulong val) : GTS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x968A580DADA9C21;
        }
    }

    class GTU(ulong val) : GTT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x86BA5BB97FB25AC;
        }
    }

    class GTV(ulong val) : GTU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x805BC00EC7AD18E;
        }
    }

    class GTW(ulong val) : GTV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x74C780146DA8C5B;
        }
    }

    class GTX(ulong val) : GTW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x506788FDE1DB423;
        }
    }

    class GTY(ulong val) : GTX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7133D842FE96FDD;
        }
    }

    class GTZ(ulong val) : GTY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x282E35ACF7A129D;
        }
    }

    class GUA(ulong val) : GTZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x709C46FA08E2505;
        }
    }

    class GUB(ulong val) : GUA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23B5007FF605890;
        }
    }

    class GUC(ulong val) : GUB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x26CDE4984E4DE45;
        }
    }

    class GUD(ulong val) : GUC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x86D005A2757FBE3;
        }
    }

    class GUE(ulong val) : GUD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1CFE689AC21D3EB;
        }
    }

    class GUF(ulong val) : GUE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x448BD3A194DAA4A;
        }
    }

    class GUG(ulong val) : GUF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x71A5B18670CA13F;
        }
    }

    class GUH(ulong val) : GUG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15B72271993FBF6;
        }
    }

    class GUI(ulong val) : GUH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x12238ACDB906FC9;
        }
    }

    class GUJ(ulong val) : GUI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6A9FA343783A077;
        }
    }

    class GUK(ulong val) : GUJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8D4CBBC227F4A7B;
        }
    }

    class GUL(ulong val) : GUK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7BED969B23CC04A;
        }
    }

    class GUM(ulong val) : GUL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6FB34F316A2F708;
        }
    }

    class GUN(ulong val) : GUM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x73F2C8BBE1C5190;
        }
    }

    class GUO(ulong val) : GUN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x93746744FF53AC0;
        }
    }

    class GUP(ulong val) : GUO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20661DD5FB14A74;
        }
    }

    class GUQ(ulong val) : GUP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C7E6D58A0C0171;
        }
    }

    class GUR(ulong val) : GUQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x124FEC18026A753;
        }
    }

    class GUS(ulong val) : GUR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x41EC885A464563D;
        }
    }

    class GUT(ulong val) : GUS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7FBEDB0E0EF5F1D;
        }
    }

    class GUU(ulong val) : GUT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6F84C0C899DFAFB;
        }
    }

    class GUV(ulong val) : GUU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x564203B6964F544;
        }
    }

    class GUW(ulong val) : GUV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x83F79A83C21862F;
        }
    }

    class GUX(ulong val) : GUW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x85D5D81F9B9FB7D;
        }
    }

    class GUY(ulong val) : GUX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x625D609C50094F7;
        }
    }

    class GUZ(ulong val) : GUY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x415E34338D6132B;
        }
    }

    class GVA(ulong val) : GUZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x925F83368845B5E;
        }
    }

    class GVB(ulong val) : GVA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x50943BA8CBF743A;
        }
    }

    class GVC(ulong val) : GVB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C4EBCBCDFE2FBE;
        }
    }

    class GVD(ulong val) : GVC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4AB2DE928EF5535;
        }
    }

    class GVE(ulong val) : GVD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5B3EA67BC94E9F4;
        }
    }

    class GVF(ulong val) : GVE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x517009037471302;
        }
    }

    class GVG(ulong val) : GVF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x83FAE0376E06258;
        }
    }

    class GVH(ulong val) : GVG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21DA2B4D1C1EEC4;
        }
    }

    class GVI(ulong val) : GVH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x170176A1FC7CEFE;
        }
    }

    class GVJ(ulong val) : GVI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3B3B7B30A03031A;
        }
    }

    class GVK(ulong val) : GVJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x49D0D853E95EE25;
        }
    }

    class GVL(ulong val) : GVK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x27E2761E18633B6;
        }
    }

    class GVM(ulong val) : GVL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B34DCE7570920A;
        }
    }

    class GVN(ulong val) : GVM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x69611E338A9325E;
        }
    }

    class GVO(ulong val) : GVN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6227164F5CD0E12;
        }
    }

    class GVP(ulong val) : GVO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x20914F88830D297;
        }
    }

    class GVQ(ulong val) : GVP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x916FF90D2E368D1;
        }
    }

    class GVR(ulong val) : GVQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x147F821D1F29739;
        }
    }

    class GVS(ulong val) : GVR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x51A7470CF5F10B2;
        }
    }

    class GVT(ulong val) : GVS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E8C0FABC375937;
        }
    }

    class GVU(ulong val) : GVT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D094466B626875;
        }
    }

    class GVV(ulong val) : GVU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8021D4415485630;
        }
    }

    class GVW(ulong val) : GVV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23B51BF940BF7EB;
        }
    }

    class GVX(ulong val) : GVW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x56A4C5D980CBB6F;
        }
    }

    class GVY(ulong val) : GVX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1251C8D10EB776E;
        }
    }

    class GVZ(ulong val) : GVY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5CAE6FEFF078320;
        }
    }

    class GWA(ulong val) : GVZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7CB93B1444EB7BA;
        }
    }

    class GWB(ulong val) : GWA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8F367985E07B1CD;
        }
    }

    class GWC(ulong val) : GWB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x9615AA75E4072A5;
        }
    }

    class GWD(ulong val) : GWC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95BAA8FED2A6A2A;
        }
    }

    class GWE(ulong val) : GWD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x76EF76DF2FEF38F;
        }
    }

    class GWF(ulong val) : GWE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x230C0A2B0863ABA;
        }
    }

    class GWG(ulong val) : GWF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x237ED5575942CF4;
        }
    }

    class GWH(ulong val) : GWG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2605E7BD33A94C8;
        }
    }

    class GWI(ulong val) : GWH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8473194178F1E67;
        }
    }

    class GWJ(ulong val) : GWI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3062BC441C0E421;
        }
    }

    class GWK(ulong val) : GWJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x23BDB69907798E7;
        }
    }

    class GWL(ulong val) : GWK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2148F122F11DC99;
        }
    }

    class GWM(ulong val) : GWL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4527F68BFC44F80;
        }
    }

    class GWN(ulong val) : GWM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x504E795B57C8206;
        }
    }

    class GWO(ulong val) : GWN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2A490229587BE7F;
        }
    }

    class GWP(ulong val) : GWO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x63201ADF1B42575;
        }
    }

    class GWQ(ulong val) : GWP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6F61BA1A519BB84;
        }
    }

    class GWR(ulong val) : GWQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x95AA9B7BFC1A348;
        }
    }

    class GWS(ulong val) : GWR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x90D2C8204668511;
        }
    }

    class GWT(ulong val) : GWS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x80CA33A5FEC7B82;
        }
    }

    class GWU(ulong val) : GWT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x677B792A22CB2ED;
        }
    }

    class GWV(ulong val) : GWU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7956D37D7C84E16;
        }
    }

    class GWW(ulong val) : GWV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2E9CB6866B63E63;
        }
    }

    class GWX(ulong val) : GWW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1650FBC8894AC2F;
        }
    }

    class GWY(ulong val) : GWX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x28D27690438838B;
        }
    }

    class GWZ(ulong val) : GWY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29DB52BC01BA59E;
        }
    }

    class GXA(ulong val) : GWZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x10365BE85C76D69;
        }
    }

    class GXB(ulong val) : GXA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8076295F85D07F4;
        }
    }

    class GXC(ulong val) : GXB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71D09153EF897B6;
        }
    }

    class GXD(ulong val) : GXC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6C649F94A9A1553;
        }
    }

    class GXE(ulong val) : GXD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95055C6EA4D809D;
        }
    }

    class GXF(ulong val) : GXE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8526BE5C66C0089;
        }
    }

    class GXG(ulong val) : GXF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8DFE03CC280F15B;
        }
    }

    class GXH(ulong val) : GXG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x71542970AE0B947;
        }
    }

    class GXI(ulong val) : GXH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x122F158E74172DD;
        }
    }

    class GXJ(ulong val) : GXI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7685701DCB29C6F;
        }
    }

    class GXK(ulong val) : GXJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4B1CDB23E58E61E;
        }
    }

    class GXL(ulong val) : GXK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6910900766B0C10;
        }
    }

    class GXM(ulong val) : GXL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x334CDD798168D65;
        }
    }

    class GXN(ulong val) : GXM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2AA8E21DE24BB0F;
        }
    }

    class GXO(ulong val) : GXN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x914356A19C86D44;
        }
    }

    class GXP(ulong val) : GXO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7ABE2A00395DDCB;
        }
    }

    class GXQ(ulong val) : GXP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x785FD4EA3D3889A;
        }
    }

    class GXR(ulong val) : GXQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x55F937B80946281;
        }
    }

    class GXS(ulong val) : GXR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x536BD859A624CA4;
        }
    }

    class GXT(ulong val) : GXS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x95821276CE89567;
        }
    }

    class GXU(ulong val) : GXT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4C1553E700BA9D6;
        }
    }

    class GXV(ulong val) : GXU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4992A3E14DFC8E5;
        }
    }

    class GXW(ulong val) : GXV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x512EEEECE6E4837;
        }
    }

    class GXX(ulong val) : GXW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x66FD8341166EA58;
        }
    }

    class GXY(ulong val) : GXX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2914606A3D9206D;
        }
    }

    class GXZ(ulong val) : GXY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x677CE3EAC460DEF;
        }
    }

    class GYA(ulong val) : GXZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x8208E16A42E0B53;
        }
    }

    class GYB(ulong val) : GYA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E12C7044A59179;
        }
    }

    class GYC(ulong val) : GYB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x21F1F7E328CF64C;
        }
    }

    class GYD(ulong val) : GYC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x51769D4D40F38A5;
        }
    }

    class GYE(ulong val) : GYD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x23D31D43E4DC9A8;
        }
    }

    class GYF(ulong val) : GYE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x584D25B6CE1E39B;
        }
    }

    class GYG(ulong val) : GYF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x20859C1FF8E70C0;
        }
    }

    class GYH(ulong val) : GYG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x246CF0FD318C2BF;
        }
    }

    class GYI(ulong val) : GYH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1ADFDF7368765BD;
        }
    }

    class GYJ(ulong val) : GYI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11E3D4EB2F37572;
        }
    }

    class GYK(ulong val) : GYJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x7E59969C31A3208;
        }
    }

    class GYL(ulong val) : GYK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x79C735E7ADC5F4C;
        }
    }

    class GYM(ulong val) : GYL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x88CEF4D15DB8D57;
        }
    }

    class GYN(ulong val) : GYM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3C1A51C979737F6;
        }
    }

    class GYO(ulong val) : GYN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1482FC0CDC0EFA8;
        }
    }

    class GYP(ulong val) : GYO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2FD47E33F148095;
        }
    }

    class GYQ(ulong val) : GYP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x25ECF4E951F8C50;
        }
    }

    class GYR(ulong val) : GYQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x392DCB979E97DF0;
        }
    }

    class GYS(ulong val) : GYR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x286B4F17840E73E;
        }
    }

    class GYT(ulong val) : GYS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x477CB676345F15A;
        }
    }

    class GYU(ulong val) : GYT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x67C3174D95860FF;
        }
    }

    class GYV(ulong val) : GYU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x16850C736FE5DEC;
        }
    }

    class GYW(ulong val) : GYV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1325F010ABDEBFC;
        }
    }

    class GYX(ulong val) : GYW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x469FFD9F5B5CAD4;
        }
    }

    class GYY(ulong val) : GYX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x132DA7C81D8DDB1;
        }
    }

    class GYZ(ulong val) : GYY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6A6E71A2C09BDCC;
        }
    }

    class GZA(ulong val) : GYZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x9741407C8A256B1;
        }
    }

    class GZB(ulong val) : GZA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26B66455E492210;
        }
    }

    class GZC(ulong val) : GZB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x753F9832B7F493C;
        }
    }

    class GZD(ulong val) : GZC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x26B87DCF40B6989;
        }
    }

    class GZE(ulong val) : GZD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x504217D81761436;
        }
    }

    class GZF(ulong val) : GZE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1AB35B7F5D38C33;
        }
    }

    class GZG(ulong val) : GZF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x292B0D0D0E60F63;
        }
    }

    class GZH(ulong val) : GZG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70C51E46D31AAF4;
        }
    }

    class GZI(ulong val) : GZH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F9C30576651EA0;
        }
    }

    class GZJ(ulong val) : GZI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1585334DAAF442F;
        }
    }

    class GZK(ulong val) : GZJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8590E84C693DB81;
        }
    }

    class GZL(ulong val) : GZK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4F697C8FEE5F2D4;
        }
    }

    class GZM(ulong val) : GZL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x92456990ABF7CDE;
        }
    }

    class GZN(ulong val) : GZM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x789E667D4F5A56F;
        }
    }

    class GZO(ulong val) : GZN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x61D415B06299E27;
        }
    }

    class GZP(ulong val) : GZO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3BB0DF05A34812A;
        }
    }

    class GZQ(ulong val) : GZP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x888106D4F034103;
        }
    }

    class GZR(ulong val) : GZQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1517F8EB313B02B;
        }
    }

    class GZS(ulong val) : GZR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x754D70DDD7FC90A;
        }
    }

    class GZT(ulong val) : GZS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2AA8C1144C6EFD6;
        }
    }

    class GZU(ulong val) : GZT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x32F554EF1297DCA;
        }
    }

    class GZV(ulong val) : GZU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2C0ADAEC795985D;
        }
    }

    class GZW(ulong val) : GZV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x215FB9AF7952090;
        }
    }

    class GZX(ulong val) : GZW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2E81246CD7E418C;
        }
    }

    class GZY(ulong val) : GZX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x71FD4BA96AC78A5;
        }
    }

    class GZZ(ulong val) : GZY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2089CF62B947B3B;
        }
    }

    class HAA(ulong val) : GZZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x17EAE79CA1880A2;
        }
    }

    class HAB(ulong val) : HAA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2BB5E07D4DDE216;
        }
    }

    class HAC(ulong val) : HAB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1B606BB24F3F2B6;
        }
    }

    class HAD(ulong val) : HAC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x69F9FF38CBD491B;
        }
    }

    class HAE(ulong val) : HAD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6708ACF5A2197FD;
        }
    }

    class HAF(ulong val) : HAE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7402E328714B4D4;
        }
    }

    class HAG(ulong val) : HAF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x797C1CD30EB931D;
        }
    }

    class HAH(ulong val) : HAG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x34A808B8EC06BFF;
        }
    }

    class HAI(ulong val) : HAH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3BB5B1F16E20550;
        }
    }

    class HAJ(ulong val) : HAI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x770ECD0F864C99E;
        }
    }

    class HAK(ulong val) : HAJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x500A67E005380A8;
        }
    }

    class HAL(ulong val) : HAK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6AF7F3F1D1807BA;
        }
    }

    class HAM(ulong val) : HAL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x900E4BADAF96B4D;
        }
    }

    class HAN(ulong val) : HAM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1E44EA548ED7A38;
        }
    }

    class HAO(ulong val) : HAN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x87FD80D42EE50EA;
        }
    }

    class HAP(ulong val) : HAO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8D41FA9F7601C55;
        }
    }

    class HAQ(ulong val) : HAP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x280B763A94A28EB;
        }
    }

    class HAR(ulong val) : HAQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3BB6F8F973A69F9;
        }
    }

    class HAS(ulong val) : HAR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x36BCDE3E5E4875F;
        }
    }

    class HAT(ulong val) : HAS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1EA2EA4BFF4DCB7;
        }
    }

    class HAU(ulong val) : HAT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3C7FC36680D28AC;
        }
    }

    class HAV(ulong val) : HAU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C7E5679BFA1722;
        }
    }

    class HAW(ulong val) : HAV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8BB39EE80D7AC4C;
        }
    }

    class HAX(ulong val) : HAW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5A7CC63127A6099;
        }
    }

    class HAY(ulong val) : HAX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61EE5C5788C0AAC;
        }
    }

    class HAZ(ulong val) : HAY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x937ECE9AA45D1A8;
        }
    }

    class HBA(ulong val) : HAZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E0739F659E7478;
        }
    }

    class HBB(ulong val) : HBA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1345C8172F1A5EB;
        }
    }

    class HBC(ulong val) : HBB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x32A754F6051CAC6;
        }
    }

    class HBD(ulong val) : HBC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8191324D7BBD8B2;
        }
    }

    class HBE(ulong val) : HBD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FD2B0B47B82112;
        }
    }

    class HBF(ulong val) : HBE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x6BE6C829B47A540;
        }
    }

    class HBG(ulong val) : HBF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x75AC88F0A26A802;
        }
    }

    class HBH(ulong val) : HBG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3B5B1D4B74E9878;
        }
    }

    class HBI(ulong val) : HBH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x89F1FC5F4B4D6A9;
        }
    }

    class HBJ(ulong val) : HBI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3BD1B0F34B70637;
        }
    }

    class HBK(ulong val) : HBJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x917AAFC07EC9B68;
        }
    }

    class HBL(ulong val) : HBK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x59C40AB3C207C02;
        }
    }

    class HBM(ulong val) : HBL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6FC8EB17B320B14;
        }
    }

    class HBN(ulong val) : HBM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x688FC9DF05CF998;
        }
    }

    class HBO(ulong val) : HBN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x51F99BA52E5C539;
        }
    }

    class HBP(ulong val) : HBO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x29F33F21CAF533A;
        }
    }

    class HBQ(ulong val) : HBP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2627AA11EFA68FF;
        }
    }

    class HBR(ulong val) : HBQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x82E2DE8EA0087BF;
        }
    }

    class HBS(ulong val) : HBR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8B6F0AB28874E18;
        }
    }

    class HBT(ulong val) : HBS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x25814ECD342A129;
        }
    }

    class HBU(ulong val) : HBT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x70E5ED05E9A65C3;
        }
    }

    class HBV(ulong val) : HBU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7734F1962516EBC;
        }
    }

    class HBW(ulong val) : HBV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x4F7634DA7CE9F9A;
        }
    }

    class HBX(ulong val) : HBW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x19BEFC7BFF51703;
        }
    }

    class HBY(ulong val) : HBX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8CF6CB8360B8AE0;
        }
    }

    class HBZ(ulong val) : HBY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x52BBA1D686B1585;
        }
    }

    class HCA(ulong val) : HBZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6F1304B187B6B80;
        }
    }

    class HCB(ulong val) : HCA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x83AFD71366B1700;
        }
    }

    class HCC(ulong val) : HCB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7E99AE179AEDCC9;
        }
    }

    class HCD(ulong val) : HCC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8380C837F40CC5D;
        }
    }

    class HCE(ulong val) : HCD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x49B7276837866C9;
        }
    }

    class HCF(ulong val) : HCE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2664979E0C926ED;
        }
    }

    class HCG(ulong val) : HCF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x434EF3A0F2B5938;
        }
    }

    class HCH(ulong val) : HCG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x73682FDEB15E954;
        }
    }

    class HCI(ulong val) : HCH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x27738F740BE7934;
        }
    }

    class HCJ(ulong val) : HCI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x61A53F19D83391D;
        }
    }

    class HCK(ulong val) : HCJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1FF0BEBD4D4515A;
        }
    }

    class HCL(ulong val) : HCK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x921A6F1B291FA8B;
        }
    }

    class HCM(ulong val) : HCL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4D07845F2887C5F;
        }
    }

    class HCN(ulong val) : HCM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7625E8F66823D66;
        }
    }

    class HCO(ulong val) : HCN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3992E0C17E4BB31;
        }
    }

    class HCP(ulong val) : HCO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8501D53D536A938;
        }
    }

    class HCQ(ulong val) : HCP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x995D91686DC23F5;
        }
    }

    class HCR(ulong val) : HCQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1826A03ACD39260;
        }
    }

    class HCS(ulong val) : HCR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x78EE1F84426EF14;
        }
    }

    class HCT(ulong val) : HCS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x2DBCA07EF372520;
        }
    }

    class HCU(ulong val) : HCT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3276E85046CA1C3;
        }
    }

    class HCV(ulong val) : HCU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x182BFF7926CF4D2;
        }
    }

    class HCW(ulong val) : HCV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x57E0F84F69EBE6D;
        }
    }

    class HCX(ulong val) : HCW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3D7DA1F2108CD52;
        }
    }

    class HCY(ulong val) : HCX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x62C006BE0AE0F35;
        }
    }

    class HCZ(ulong val) : HCY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x64AFE4E11742269;
        }
    }

    class HDA(ulong val) : HCZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x5ABA9497D3EC227;
        }
    }

    class HDB(ulong val) : HDA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A243B152B2B57A;
        }
    }

    class HDC(ulong val) : HDB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x54142F11E81BC5C;
        }
    }

    class HDD(ulong val) : HDC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8AF9B4689FF4C5B;
        }
    }

    class HDE(ulong val) : HDD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3B395E340498449;
        }
    }

    class HDF(ulong val) : HDE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x6F6460C9580A376;
        }
    }

    class HDG(ulong val) : HDF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7C2D38A7F3F7BB5;
        }
    }

    class HDH(ulong val) : HDG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x11058263A5F06AE;
        }
    }

    class HDI(ulong val) : HDH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x91DCF1B365DE186;
        }
    }

    class HDJ(ulong val) : HDI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1A8269925D3D8F3;
        }
    }

    class HDK(ulong val) : HDJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x96F8F7369038E8A;
        }
    }

    class HDL(ulong val) : HDK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x391B160320EF1D8;
        }
    }

    class HDM(ulong val) : HDL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x7D5B8610EDC92BA;
        }
    }

    class HDN(ulong val) : HDM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x518EBB597737078;
        }
    }

    class HDO(ulong val) : HDN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3A69101377DE1AC;
        }
    }

    class HDP(ulong val) : HDO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x74783784B6098C0;
        }
    }

    class HDQ(ulong val) : HDP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x8149D78DA1F7497;
        }
    }

    class HDR(ulong val) : HDQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x3AD2297F6996D3D;
        }
    }

    class HDS(ulong val) : HDR(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x39CFD9432BEF14C;
        }
    }

    class HDT(ulong val) : HDS(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x912F96892DE8FCB;
        }
    }

    class HDU(ulong val) : HDT(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x1FD2F072BA6F98B;
        }
    }

    class HDV(ulong val) : HDU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1CC1DDDB099ABBF;
        }
    }

    class HDW(ulong val) : HDV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x28D50B161DC403A;
        }
    }

    class HDX(ulong val) : HDW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x98DDC23F3EB4A43;
        }
    }

    class HDY(ulong val) : HDX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5D13B3630EF7436;
        }
    }

    class HDZ(ulong val) : HDY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x41E36D95F5D7FF4;
        }
    }

    class HEA(ulong val) : HDZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4A9C8DFFE404245;
        }
    }

    class HEB(ulong val) : HEA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x997F398B5DD9FAC;
        }
    }

    class HEC(ulong val) : HEB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x589A2FC0422FBBC;
        }
    }

    class HED(ulong val) : HEC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8C21E4EDCE52FBE;
        }
    }

    class HEE(ulong val) : HED(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x63ECE742BB17768;
        }
    }

    class HEF(ulong val) : HEE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x297172A9120CA89;
        }
    }

    class HEG(ulong val) : HEF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x5542AE8C3C6A362;
        }
    }

    class HEH(ulong val) : HEG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x1013746AD801CCD;
        }
    }

    class HEI(ulong val) : HEH(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x2F9C0C7AA018F4C;
        }
    }

    class HEJ(ulong val) : HEI(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x802E2EBE948FAB2;
        }
    }

    class HEK(ulong val) : HEJ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x646CE4DB1F8B512;
        }
    }

    class HEL(ulong val) : HEK(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x8E3FB3F0023CA9D;
        }
    }

    class HEM(ulong val) : HEL(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x649625025FD2336;
        }
    }

    class HEN(ulong val) : HEM(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1D6E55D749BC60E;
        }
    }

    class HEO(ulong val) : HEN(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x2141F066E5F3C30;
        }
    }

    class HEP(ulong val) : HEO(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x5997785C6F898C7;
        }
    }

    class HEQ(ulong val) : HEP(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x68BAE69ECA2D749;
        }
    }

    class HER(ulong val) : HEQ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x94B7590BA0486B1;
        }
    }

    class HES(ulong val) : HER(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x36613654965FD6E;
        }
    }

    class HET(ulong val) : HES(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x3BE6B85F3D6A9DB;
        }
    }

    class HEU(ulong val) : HET(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x3500248D33F22AC;
        }
    }

    class HEV(ulong val) : HEU(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x1C4F226F84285DA;
        }
    }

    class HEW(ulong val) : HEV(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x4B62C9F35E0D938;
        }
    }

    class HEX(ulong val) : HEW(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x6DE34938C6DF5F3;
        }
    }

    class HEY(ulong val) : HEX(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x92662F402E4A133;
        }
    }

    class HEZ(ulong val) : HEY(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x15AB1B2EACD0665;
        }
    }

    class HFA(ulong val) : HEZ(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x61836D09DE3D124;
        }
    }

    class HFB(ulong val) : HFA(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x116967DDA1E5E40;
        }
    }

    class HFC(ulong val) : HFB(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x83D40919D119BEB;
        }
    }

    class HFD(ulong val) : HFC(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val + 0x29BC7B36E23C6E1;
        }
    }

    class HFE(ulong val) : HFD(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x572B0738F7F1574;
        }
    }

    class HFF(ulong val) : HFE(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x277A591AD6F529B;
        }
    }

    class HFG(ulong val) : HFF(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val - 0x7D770BA2B607FA5;
        }
    }

    class HFH(ulong val) : HFG(val)
    {
        public override ulong GetVal()
        {
            base.GetVal();
            return val ^ 0x4665A58E10ED48B;
        }
    }

    class HFI(ulong val) : HFH(val)
    {
        public override ulong GetVal()
        {
        }
    }


