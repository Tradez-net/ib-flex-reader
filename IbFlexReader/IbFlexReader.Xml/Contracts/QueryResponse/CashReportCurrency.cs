namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "CashReportCurrency")]
    public class CashReportCurrency
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

        [XmlAttribute(AttributeName = "levelOfDetail")]
        public string LevelOfDetail { get; set; }

        [XmlAttribute(AttributeName = "fromDate")]
        public string FromDate { get; set; }

        [XmlAttribute(AttributeName = "toDate")]
        public string ToDate { get; set; }

        [XmlAttribute(AttributeName = "startingCash")]
        public string StartingCash { get; set; }

        [XmlAttribute(AttributeName = "startingCashSec")]
        public string StartingCashSec { get; set; }

        [XmlAttribute(AttributeName = "startingCashCom")]
        public string StartingCashCom { get; set; }

        [XmlAttribute(AttributeName = "clientFees")]
        public string ClientFees { get; set; }

        [XmlAttribute(AttributeName = "clientFeesSec")]
        public string ClientFeesSec { get; set; }

        [XmlAttribute(AttributeName = "clientFeesCom")]
        public string ClientFeesCom { get; set; }

        [XmlAttribute(AttributeName = "commissions")]
        public string Commissions { get; set; }

        [XmlAttribute(AttributeName = "commissionsSec")]
        public string CommissionsSec { get; set; }

        [XmlAttribute(AttributeName = "commissionsCom")]
        public string CommissionsCom { get; set; }

        [XmlAttribute(AttributeName = "referralFee")]
        public string ReferralFee { get; set; }

        [XmlAttribute(AttributeName = "referralFeeSec")]
        public string ReferralFeeSec { get; set; }

        [XmlAttribute(AttributeName = "referralFeeCom")]
        public string ReferralFeeCom { get; set; }

        [XmlAttribute(AttributeName = "commissionCreditsRedemption")]
        public string CommissionCreditsRedemption { get; set; }

        [XmlAttribute(AttributeName = "commissionCreditsRedemptionSec")]
        public string CommissionCreditsRedemptionSec { get; set; }

        [XmlAttribute(AttributeName = "commissionCreditsRedemptionCom")]
        public string CommissionCreditsRedemptionCom { get; set; }

        [XmlAttribute(AttributeName = "billableCommissions")]
        public string BillableCommissions { get; set; }

        [XmlAttribute(AttributeName = "billableCommissionsSec")]
        public string BillableCommissionsSec { get; set; }

        [XmlAttribute(AttributeName = "billableCommissionsCom")]
        public string BillableCommissionsCom { get; set; }

        [XmlAttribute(AttributeName = "depositWithdrawals")]
        public string DepositWithdrawals { get; set; }

        [XmlAttribute(AttributeName = "depositWithdrawalsSec")]
        public string DepositWithdrawalsSec { get; set; }

        [XmlAttribute(AttributeName = "depositWithdrawalsCom")]
        public string DepositWithdrawalsCom { get; set; }

        [XmlAttribute(AttributeName = "deposits")]
        public string Deposits { get; set; }

        [XmlAttribute(AttributeName = "depositsSec")]
        public string DepositsSec { get; set; }

        [XmlAttribute(AttributeName = "depositsCom")]
        public string DepositsCom { get; set; }

        [XmlAttribute(AttributeName = "withdrawals")]
        public string Withdrawals { get; set; }

        [XmlAttribute(AttributeName = "withdrawalsSec")]
        public string WithdrawalsSec { get; set; }

        [XmlAttribute(AttributeName = "withdrawalsCom")]
        public string WithdrawalsCom { get; set; }

        [XmlAttribute(AttributeName = "carbonCredits")]
        public string CarbonCredits { get; set; }

        [XmlAttribute(AttributeName = "carbonCreditsSec")]
        public string CarbonCreditsSec { get; set; }

        [XmlAttribute(AttributeName = "carbonCreditsCom")]
        public string CarbonCreditsCom { get; set; }

        [XmlAttribute(AttributeName = "donations")]
        public string Donations { get; set; }

        [XmlAttribute(AttributeName = "donationsSec")]
        public string DonationsSec { get; set; }

        [XmlAttribute(AttributeName = "donationsCom")]
        public string DonationsCom { get; set; }

        [XmlAttribute(AttributeName = "accountTransfers")]
        public string AccountTransfers { get; set; }

        [XmlAttribute(AttributeName = "accountTransfersSec")]
        public string AccountTransfersSec { get; set; }

        [XmlAttribute(AttributeName = "accountTransfersCom")]
        public string AccountTransfersCom { get; set; }

        [XmlAttribute(AttributeName = "linkingAdjustments")]
        public string LinkingAdjustments { get; set; }

        [XmlAttribute(AttributeName = "linkingAdjustmentsSec")]
        public string LinkingAdjustmentsSec { get; set; }

        [XmlAttribute(AttributeName = "linkingAdjustmentsCom")]
        public string LinkingAdjustmentsCom { get; set; }

        [XmlAttribute(AttributeName = "internalTransfers")]
        public string InternalTransfers { get; set; }

        [XmlAttribute(AttributeName = "internalTransfersSec")]
        public string InternalTransfersSec { get; set; }

        [XmlAttribute(AttributeName = "internalTransfersCom")]
        public string InternalTransfersCom { get; set; }

        [XmlAttribute(AttributeName = "paxosTransfers")]
        public string PaxosTransfers { get; set; }

        [XmlAttribute(AttributeName = "paxosTransfersSec")]
        public string PaxosTransfersSec { get; set; }

        [XmlAttribute(AttributeName = "paxosTransfersCom")]
        public string PaxosTransfersCom { get; set; }

        [XmlAttribute(AttributeName = "excessFundSweep")]
        public string ExcessFundSweep { get; set; }

        [XmlAttribute(AttributeName = "excessFundSweepSec")]
        public string ExcessFundSweepSec { get; set; }

        [XmlAttribute(AttributeName = "excessFundSweepCom")]
        public string ExcessFundSweepCom { get; set; }

        [XmlAttribute(AttributeName = "debitCardActivity")]
        public string DebitCardActivity { get; set; }

        [XmlAttribute(AttributeName = "debitCardActivitySec")]
        public string DebitCardActivitySec { get; set; }

        [XmlAttribute(AttributeName = "debitCardActivityCom")]
        public string DebitCardActivityCom { get; set; }

        [XmlAttribute(AttributeName = "billPay")]
        public string BillPay { get; set; }

        [XmlAttribute(AttributeName = "billPaySec")]
        public string BillPaySec { get; set; }

        [XmlAttribute(AttributeName = "billPayCom")]
        public string BillPayCom { get; set; }

        [XmlAttribute(AttributeName = "dividends")]
        public string Dividends { get; set; }

        [XmlAttribute(AttributeName = "dividendsSec")]
        public string DividendsSec { get; set; }

        [XmlAttribute(AttributeName = "dividendsCom")]
        public string DividendsCom { get; set; }

        [XmlAttribute(AttributeName = "insuredDepositInterest")]
        public string InsuredDepositInterest { get; set; }

        [XmlAttribute(AttributeName = "insuredDepositInterestSec")]
        public string InsuredDepositInterestSec { get; set; }

        [XmlAttribute(AttributeName = "insuredDepositInterestCom")]
        public string InsuredDepositInterestCom { get; set; }

        [XmlAttribute(AttributeName = "brokerInterest")]
        public string BrokerInterest { get; set; }

        [XmlAttribute(AttributeName = "brokerInterestSec")]
        public string BrokerInterestSec { get; set; }

        [XmlAttribute(AttributeName = "brokerInterestCom")]
        public string BrokerInterestCom { get; set; }

        [XmlAttribute(AttributeName = "brokerFees")]
        public string BrokerFees { get; set; }

        [XmlAttribute(AttributeName = "brokerFeesSec")]
        public string BrokerFeesSec { get; set; }

        [XmlAttribute(AttributeName = "brokerFeesCom")]
        public string BrokerFeesCom { get; set; }

        [XmlAttribute(AttributeName = "bondInterest")]
        public string BondInterest { get; set; }

        [XmlAttribute(AttributeName = "bondInterestSec")]
        public string BondInterestSec { get; set; }

        [XmlAttribute(AttributeName = "bondInterestCom")]
        public string BondInterestCom { get; set; }

        [XmlAttribute(AttributeName = "cashSettlingMtm")]
        public string CashSettlingMtm { get; set; }

        [XmlAttribute(AttributeName = "cashSettlingMtmSec")]
        public string CashSettlingMtmSec { get; set; }

        [XmlAttribute(AttributeName = "cashSettlingMtmCom")]
        public string CashSettlingMtmCom { get; set; }

        [XmlAttribute(AttributeName = "realizedVm")]
        public string RealizedVm { get; set; }

        [XmlAttribute(AttributeName = "realizedVmSec")]
        public string RealizedVmSec { get; set; }

        [XmlAttribute(AttributeName = "realizedVmCom")]
        public string RealizedVmCom { get; set; }

        [XmlAttribute(AttributeName = "realizedForexVm")]
        public string RealizedForexVm { get; set; }

        [XmlAttribute(AttributeName = "realizedForexVmSec")]
        public string RealizedForexVmSec { get; set; }

        [XmlAttribute(AttributeName = "realizedForexVmCom")]
        public string RealizedForexVmCom { get; set; }

        [XmlAttribute(AttributeName = "cfdCharges")]
        public string CfdCharges { get; set; }

        [XmlAttribute(AttributeName = "cfdChargesSec")]
        public string CfdChargesSec { get; set; }

        [XmlAttribute(AttributeName = "cfdChargesCom")]
        public string CfdChargesCom { get; set; }

        [XmlAttribute(AttributeName = "netTradesSales")]
        public string NetTradesSales { get; set; }

        [XmlAttribute(AttributeName = "netTradesSalesSec")]
        public string NetTradesSalesSec { get; set; }

        [XmlAttribute(AttributeName = "netTradesSalesCom")]
        public string NetTradesSalesCom { get; set; }

        [XmlAttribute(AttributeName = "netTradesPurchases")]
        public string NetTradesPurchases { get; set; }

        [XmlAttribute(AttributeName = "netTradesPurchasesSec")]
        public string NetTradesPurchasesSec { get; set; }

        [XmlAttribute(AttributeName = "netTradesPurchasesCom")]
        public string NetTradesPurchasesCom { get; set; }

        [XmlAttribute(AttributeName = "advisorFees")]
        public string AdvisorFees { get; set; }

        [XmlAttribute(AttributeName = "advisorFeesSec")]
        public string AdvisorFeesSec { get; set; }

        [XmlAttribute(AttributeName = "advisorFeesCom")]
        public string AdvisorFeesCom { get; set; }

        [XmlAttribute(AttributeName = "feesReceivables")]
        public string FeesReceivables { get; set; }

        [XmlAttribute(AttributeName = "feesReceivablesSec")]
        public string FeesReceivablesSec { get; set; }

        [XmlAttribute(AttributeName = "feesReceivablesCom")]
        public string FeesReceivablesCom { get; set; }

        [XmlAttribute(AttributeName = "paymentInLieu")]
        public string PaymentInLieu { get; set; }

        [XmlAttribute(AttributeName = "paymentInLieuSec")]
        public string PaymentInLieuSec { get; set; }

        [XmlAttribute(AttributeName = "paymentInLieuCom")]
        public string PaymentInLieuCom { get; set; }

        [XmlAttribute(AttributeName = "transactionTax")]
        public string TransactionTax { get; set; }

        [XmlAttribute(AttributeName = "transactionTaxSec")]
        public string TransactionTaxSec { get; set; }

        [XmlAttribute(AttributeName = "transactionTaxCom")]
        public string TransactionTaxCom { get; set; }

        [XmlAttribute(AttributeName = "taxReceivables")]
        public string TaxReceivables { get; set; }

        [XmlAttribute(AttributeName = "taxReceivablesSec")]
        public string TaxReceivablesSec { get; set; }

        [XmlAttribute(AttributeName = "taxReceivablesCom")]
        public string TaxReceivablesCom { get; set; }

        [XmlAttribute(AttributeName = "withholdingTax")]
        public string WithholdingTax { get; set; }

        [XmlAttribute(AttributeName = "withholdingTaxSec")]
        public string WithholdingTaxSec { get; set; }

        [XmlAttribute(AttributeName = "withholdingTaxCom")]
        public string WithholdingTaxCom { get; set; }

        [XmlAttribute(AttributeName = "withholding871m")]
        public string Withholding871m { get; set; }

        [XmlAttribute(AttributeName = "withholding871mSec")]
        public string Withholding871mSec { get; set; }

        [XmlAttribute(AttributeName = "withholding871mCom")]
        public string Withholding871mCom { get; set; }

        [XmlAttribute(AttributeName = "withholdingCollectedTax")]
        public string WithholdingCollectedTax { get; set; }

        [XmlAttribute(AttributeName = "withholdingCollectedTaxSec")]
        public string WithholdingCollectedTaxSec { get; set; }

        [XmlAttribute(AttributeName = "withholdingCollectedTaxCom")]
        public string WithholdingCollectedTaxCom { get; set; }

        [XmlAttribute(AttributeName = "salesTax")]
        public string SalesTax { get; set; }

        [XmlAttribute(AttributeName = "salesTaxSec")]
        public string SalesTaxSec { get; set; }

        [XmlAttribute(AttributeName = "salesTaxCom")]
        public string SalesTaxCom { get; set; }

        [XmlAttribute(AttributeName = "billableSalesTax")]
        public string BillableSalesTax { get; set; }

        [XmlAttribute(AttributeName = "billableSalesTaxSec")]
        public string BillableSalesTaxSec { get; set; }

        [XmlAttribute(AttributeName = "billableSalesTaxCom")]
        public string BillableSalesTaxCom { get; set; }

        [XmlAttribute(AttributeName = "ipoSubscription")]
        public string IpoSubscription { get; set; }

        [XmlAttribute(AttributeName = "ipoSubscriptionSec")]
        public string IpoSubscriptionSec { get; set; }

        [XmlAttribute(AttributeName = "ipoSubscriptionCom")]
        public string IpoSubscriptionCom { get; set; }

        [XmlAttribute(AttributeName = "fxTranslationGainLoss")]
        public string FxTranslationGainLoss { get; set; }

        [XmlAttribute(AttributeName = "fxTranslationGainLossSec")]
        public string FxTranslationGainLossSec { get; set; }

        [XmlAttribute(AttributeName = "fxTranslationGainLossCom")]
        public string FxTranslationGainLossCom { get; set; }

        [XmlAttribute(AttributeName = "otherFees")]
        public string OtherFees { get; set; }

        [XmlAttribute(AttributeName = "otherFeesSec")]
        public string OtherFeesSec { get; set; }

        [XmlAttribute(AttributeName = "otherFeesCom")]
        public string OtherFeesCom { get; set; }

        [XmlAttribute(AttributeName = "other")]
        public string Other { get; set; }

        [XmlAttribute(AttributeName = "otherSec")]
        public string OtherSec { get; set; }

        [XmlAttribute(AttributeName = "otherCom")]
        public string OtherCom { get; set; }

        [XmlAttribute(AttributeName = "endingCash")]
        public string EndingCash { get; set; }

        [XmlAttribute(AttributeName = "endingCashSec")]
        public string EndingCashSec { get; set; }

        [XmlAttribute(AttributeName = "endingCashCom")]
        public string EndingCashCom { get; set; }

        [XmlAttribute(AttributeName = "endingSettledCash")]
        public string EndingSettledCash { get; set; }

        [XmlAttribute(AttributeName = "endingSettledCashSec")]
        public string EndingSettledCashSec { get; set; }

        [XmlAttribute(AttributeName = "endingSettledCashCom")]
        public string EndingSettledCashCom { get; set; }

        [XmlAttribute(AttributeName = "slbStartingCashCollateral")]
        public string SlbStartingCashCollateral { get; set; }

        [XmlAttribute(AttributeName = "slbStartingCashCollateralSec")]
        public string SlbStartingCashCollateralSec { get; set; }

        [XmlAttribute(AttributeName = "slbStartingCashCollateralCom")]
        public string SlbStartingCashCollateralCom { get; set; }

        [XmlAttribute(AttributeName = "slbNetSecuritiesLentActivity")]
        public string SlbNetSecuritiesLentActivity { get; set; }

        [XmlAttribute(AttributeName = "slbNetSecuritiesLentActivitySec")]
        public string SlbNetSecuritiesLentActivitySec { get; set; }

        [XmlAttribute(AttributeName = "slbNetSecuritiesLentActivityCom")]
        public string SlbNetSecuritiesLentActivityCom { get; set; }

        [XmlAttribute(AttributeName = "slbEndingCashCollateral")]
        public string SlbEndingCashCollateral { get; set; }

        [XmlAttribute(AttributeName = "slbEndingCashCollateralSec")]
        public string SlbEndingCashCollateralSec { get; set; }

        [XmlAttribute(AttributeName = "slbEndingCashCollateralCom")]
        public string SlbEndingCashCollateralCom { get; set; }

        [XmlAttribute(AttributeName = "slbNetCash")]
        public string SlbNetCash { get; set; }

        [XmlAttribute(AttributeName = "slbNetCashSec")]
        public string SlbNetCashSec { get; set; }

        [XmlAttribute(AttributeName = "slbNetCashCom")]
        public string SlbNetCashCom { get; set; }

        [XmlAttribute(AttributeName = "slbNetSettledCash")]
        public string SlbNetSettledCash { get; set; }

        [XmlAttribute(AttributeName = "slbNetSettledCashSec")]
        public string SlbNetSettledCashSec { get; set; }

        [XmlAttribute(AttributeName = "slbNetSettledCashCom")]
        public string SlbNetSettledCashCom { get; set; }

        // added
        [XmlAttribute(AttributeName = "otherIncome")]
        public string OtherIncome { get; set; }

        [XmlAttribute(AttributeName = "otherIncomeSec")]
        public string OtherIncomeSec { get; set; }

        [XmlAttribute(AttributeName = "otherIncomeCom")]
        public string OtherIncomeCom { get; set; }

        // added 15.01.2026
        [XmlAttribute(AttributeName = "billableSalesTaxYTD")]
        public string BillableSalesTaxYtd { get; set; }

        [XmlAttribute(AttributeName = "commissionCreditsRedemptionMTD")]
        public string CommissionCreditsRedemptionMtd { get; set; }

        [XmlAttribute(AttributeName = "commissionCreditsRedemptionYTD")]
        public string CommissionCreditsRedemptionYtd { get; set; }

        [XmlAttribute(AttributeName = "referralFeeMTD")]
        public string ReferralFeeMtd { get; set; }

        [XmlAttribute(AttributeName = "referralFeeYTD")]
        public string ReferralFeeYtd { get; set; }

        [XmlAttribute(AttributeName = "commissionsYTD")]
        public string CommissionsYtd { get; set; }

        [XmlAttribute(AttributeName = "commissionsMTD")]
        public string CommissionsMtd { get; set; }

        [XmlAttribute(AttributeName = "clientFeesYTD")]
        public string ClientFeesYtd { get; set; }

        [XmlAttribute(AttributeName = "clientFeesMTD")]
        public string ClientFeesMtd { get; set; }

        [XmlAttribute(AttributeName = "otherIncomeYTD")]
        public string OtherIncomeYtd { get; set; }

        [XmlAttribute(AttributeName = "otherIncomeMTD")]
        public string OtherIncomeMtd { get; set; }

        [XmlAttribute(AttributeName = "otherFeesMTD")]
        public string OtherFeesMtd { get; set; }

        [XmlAttribute(AttributeName = "otherFeesYTD")]
        public string OtherFeesYtd { get; set; }

        [XmlAttribute(AttributeName = "ipoSubscriptionYTD")]
        public string IpoSubscriptionYtd { get; set; }

        [XmlAttribute(AttributeName = "ipoSubscriptionMTD")]
        public string IpoSubscriptionMtd { get; set; }

        [XmlAttribute(AttributeName = "billableCommissionsMTD")]
        public string BillableCommissionsMtd { get; set; }

        [XmlAttribute(AttributeName = "billableCommissionsYTD")]
        public string BillableCommissionsYtd { get; set; }

        [XmlAttribute(AttributeName = "depositWithdrawalsMTD")]
        public string DepositWithdrawalsMtd { get; set; }

        [XmlAttribute(AttributeName = "depositWithdrawalsYTD")]
        public string DepositWithdrawalsYtd { get; set; }

        [XmlAttribute(AttributeName = "depositsMTD")]
        public string DepositsMtd { get; set; }

        [XmlAttribute(AttributeName = "depositsYTD")]
        public string DepositsYtd { get; set; }

        [XmlAttribute(AttributeName = "withdrawalsMTD")]
        public string WithdrawalsMtd { get; set; }

        [XmlAttribute(AttributeName = "withdrawalsYTD")]
        public string WithdrawalsYtd { get; set; }

        [XmlAttribute(AttributeName = "carbonCreditsMTD")]
        public string CarbonCreditsMtd { get; set; }

        [XmlAttribute(AttributeName = "carbonCreditsYTD")]
        public string CarbonCreditsYtd { get; set; }

        [XmlAttribute(AttributeName = "donationsMTD")]
        public string DonationsMtd { get; set; }

        [XmlAttribute(AttributeName = "donationsYTD")]
        public string DonationsYtd { get; set; }

        [XmlAttribute(AttributeName = "accountTransfersMTD")]
        public string AccountTransfersMtd { get; set; }

        [XmlAttribute(AttributeName = "accountTransfersYTD")]
        public string AccountTransfersYtd { get; set; }

        [XmlAttribute(AttributeName = "internalTransfersMTD")]
        public string InternalTransfersMtd { get; set; }

        [XmlAttribute(AttributeName = "internalTransfersYTD")]
        public string InternalTransfersYtd { get; set; }

        [XmlAttribute(AttributeName = "paxosTransfersMTD")]
        public string PaxosTransfersMtd { get; set; }

        [XmlAttribute(AttributeName = "paxosTransfersYTD")]
        public string PaxosTransfersYtd { get; set; }

        [XmlAttribute(AttributeName = "excessFundSweepMTD")]
        public string ExcessFundSweepMtd { get; set; }

        [XmlAttribute(AttributeName = "excessFundSweepYTD")]
        public string ExcessFundSweepYtd { get; set; }

        [XmlAttribute(AttributeName = "debitCardActivityMTD")]
        public string DebitCardActivityMtd { get; set; }

        [XmlAttribute(AttributeName = "debitCardActivityYTD")]
        public string DebitCardActivityYtd { get; set; }

        [XmlAttribute(AttributeName = "billPayMTD")]
        public string BillPayMtd { get; set; }

        [XmlAttribute(AttributeName = "billPayYTD")]
        public string BillPayYtd { get; set; }

        [XmlAttribute(AttributeName = "dividendsMTD")]
        public string DividendsMtd { get; set; }

        [XmlAttribute(AttributeName = "dividendsYTD")]
        public string DividendsYtd { get; set; }

        [XmlAttribute(AttributeName = "insuredDepositInterestMTD")]
        public string InsuredDepositInterestMtd { get; set; }

        [XmlAttribute(AttributeName = "insuredDepositInterestYTD")]
        public string InsuredDepositInterestYtd { get; set; }

        [XmlAttribute(AttributeName = "brokerInterestMTD")]
        public string BrokerInterestMtd { get; set; }

        [XmlAttribute(AttributeName = "brokerInterestYTD")]
        public string BrokerInterestYtd { get; set; }

        [XmlAttribute(AttributeName = "brokerFeesMTD")]
        public string BrokerFeesMtd { get; set; }

        [XmlAttribute(AttributeName = "brokerFeesYTD")]
        public string BrokerFeesYtd { get; set; }

        [XmlAttribute(AttributeName = "bondInterestMTD")]
        public string BondInterestMtd { get; set; }

        [XmlAttribute(AttributeName = "bondInterestYTD")]
        public string BondInterestYtd { get; set; }

        [XmlAttribute(AttributeName = "cashSettlingMtmMTD")]
        public string CashSettlingMtmMtd { get; set; }

        [XmlAttribute(AttributeName = "cashSettlingMtmYTD")]
        public string CashSettlingMtmYtd { get; set; }

        [XmlAttribute(AttributeName = "realizedVmMTD")]
        public string RealizedVmMtd { get; set; }

        [XmlAttribute(AttributeName = "realizedVmYTD")]
        public string RealizedVmYtd { get; set; }

        [XmlAttribute(AttributeName = "realizedForexVmMTD")]
        public string RealizedForexVmMtd { get; set; }

        [XmlAttribute(AttributeName = "realizedForexVmYTD")]
        public string RealizedForexVmYtd { get; set; }

        [XmlAttribute(AttributeName = "cfdChargesMTD")]
        public string CfdChargesMtd { get; set; }

        [XmlAttribute(AttributeName = "cfdChargesYTD")]
        public string CfdChargesYtd { get; set; }

        [XmlAttribute(AttributeName = "netTradesSalesMTD")]
        public string NetTradesSalesMtd { get; set; }

        [XmlAttribute(AttributeName = "netTradesSalesYTD")]
        public string NetTradesSalesYtd { get; set; }

        [XmlAttribute(AttributeName = "netTradesPurchasesMTD")]
        public string NetTradesPurchasesMtd { get; set; }

        [XmlAttribute(AttributeName = "netTradesPurchasesYTD")]
        public string NetTradesPurchasesYtd { get; set; }

        [XmlAttribute(AttributeName = "advisorFeesMTD")]
        public string AdvisorFeesMtd { get; set; }

        [XmlAttribute(AttributeName = "advisorFeesYTD")]
        public string AdvisorFeesYtd { get; set; }

        [XmlAttribute(AttributeName = "feesReceivablesMTD")]
        public string FeesReceivablesMtd { get; set; }

        [XmlAttribute(AttributeName = "feesReceivablesYTD")]
        public string FeesReceivablesYtd { get; set; }

        [XmlAttribute(AttributeName = "paymentInLieuMTD")]
        public string PaymentInLieuMtd { get; set; }

        [XmlAttribute(AttributeName = "paymentInLieuYTD")]
        public string PaymentInLieuYtd { get; set; }

        [XmlAttribute(AttributeName = "transactionTaxMTD")]
        public string TransactionTaxMtd { get; set; }

        [XmlAttribute(AttributeName = "transactionTaxYTD")]
        public string TransactionTaxYtd { get; set; }

        [XmlAttribute(AttributeName = "taxReceivablesMTD")]
        public string TaxReceivablesMtd { get; set; }

        [XmlAttribute(AttributeName = "taxReceivablesYTD")]
        public string TaxReceivablesYtd { get; set; }

        [XmlAttribute(AttributeName = "withholdingTaxMTD")]
        public string WithholdingTaxMtd { get; set; }

        [XmlAttribute(AttributeName = "withholdingTaxYTD")]
        public string WithholdingTaxYtd { get; set; }

        [XmlAttribute(AttributeName = "withholding871mMTD")]
        public string Withholding871mMtd { get; set; }

        [XmlAttribute(AttributeName = "withholding871mYTD")]
        public string Withholding871mYtd { get; set; }

        [XmlAttribute(AttributeName = "withholdingCollectedTaxMTD")]
        public string WithholdingCollectedTaxMtd { get; set; }

        [XmlAttribute(AttributeName = "withholdingCollectedTaxYTD")]
        public string WithholdingCollectedTaxYtd { get; set; }

        [XmlAttribute(AttributeName = "salesTaxMTD")]
        public string SalesTaxMtd { get; set; }

        [XmlAttribute(AttributeName = "salesTaxYTD")]
        public string SalesTaxYtd { get; set; }

        [XmlAttribute(AttributeName = "billableSalesTaxMTD")]
        public string BillableSalesTaxMtd { get; set; }
    }
}
