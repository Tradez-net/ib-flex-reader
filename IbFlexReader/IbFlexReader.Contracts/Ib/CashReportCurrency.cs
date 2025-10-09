namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Enums;

    public class CashReportCurrency
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public string LevelOfDetail { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public double? StartingCash { get; set; }

        public double? StartingCashSec { get; set; }

        public double? StartingCashCom { get; set; }

        public double? ClientFees { get; set; }

        public double? ClientFeesSec { get; set; }

        public double? ClientFeesCom { get; set; }

        public double? Commissions { get; set; }

        public double? CommissionsSec { get; set; }

        public double? CommissionsCom { get; set; }

        public double? ReferralFee { get; set; }

        public double? ReferralFeeSec { get; set; }

        public double? ReferralFeeCom { get; set; }

        public double? CommissionCreditsRedemption { get; set; }

        public double? CommissionCreditsRedemptionSec { get; set; }

        public double? CommissionCreditsRedemptionCom { get; set; }

        public double? BillableCommissions { get; set; }

        public double? BillableCommissionsSec { get; set; }

        public double? BillableCommissionsCom { get; set; }

        public double? DepositWithdrawals { get; set; }

        public double? DepositWithdrawalsSec { get; set; }

        public double? DepositWithdrawalsCom { get; set; }

        public double? Deposits { get; set; }

        public double? DepositsSec { get; set; }

        public double? DepositsCom { get; set; }

        public double? Withdrawals { get; set; }

        public double? WithdrawalsSec { get; set; }

        public double? WithdrawalsCom { get; set; }

        public double? CarbonCredits { get; set; }

        public double? CarbonCreditsSec { get; set; }

        public double? CarbonCreditsCom { get; set; }

        public double? Donations { get; set; }

        public double? DonationsSec { get; set; }

        public double? DonationsCom { get; set; }

        public double? AccountTransfers { get; set; }

        public double? AccountTransfersSec { get; set; }

        public double? AccountTransfersCom { get; set; }

        public double? LinkingAdjustments { get; set; }

        public double? LinkingAdjustmentsSec { get; set; }

        public double? LinkingAdjustmentsCom { get; set; }

        public double? InternalTransfers { get; set; }

        public double? InternalTransfersSec { get; set; }

        public double? InternalTransfersCom { get; set; }

        public double? PaxosTransfers { get; set; }

        public double? PaxosTransfersSec { get; set; }

        public double? PaxosTransfersCom { get; set; }

        public double? ExcessFundSweep { get; set; }

        public double? ExcessFundSweepSec { get; set; }

        public double? ExcessFundSweepCom { get; set; }

        public double? DebitCardActivity { get; set; }

        public double? DebitCardActivitySec { get; set; }

        public double? DebitCardActivityCom { get; set; }

        public double? BillPay { get; set; }

        public double? BillPaySec { get; set; }

        public double? BillPayCom { get; set; }

        public double? Dividends { get; set; }

        public double? DividendsSec { get; set; }

        public double? DividendsCom { get; set; }

        public double? InsuredDepositdoubleerest { get; set; }

        public double? InsuredDepositdoubleerestSec { get; set; }

        public double? InsuredDepositdoubleerestCom { get; set; }

        public double? Brokerdoubleerest { get; set; }

        public double? BrokerdoubleerestSec { get; set; }

        public double? BrokerdoubleerestCom { get; set; }

        public double? BrokerFees { get; set; }

        public double? BrokerFeesSec { get; set; }

        public double? BrokerFeesCom { get; set; }

        public double? Bonddoubleerest { get; set; }

        public double? BonddoubleerestSec { get; set; }

        public double? BonddoubleerestCom { get; set; }

        public double? CashSettlingMtm { get; set; }

        public double? CashSettlingMtmSec { get; set; }

        public double? CashSettlingMtmCom { get; set; }

        public double? RealizedVm { get; set; }

        public double? RealizedVmSec { get; set; }

        public double? RealizedVmCom { get; set; }

        public double? RealizedForexVm { get; set; }

        public double? RealizedForexVmSec { get; set; }

        public double? RealizedForexVmCom { get; set; }

        public double? CfdCharges { get; set; }

        public double? CfdChargesSec { get; set; }

        public double? CfdChargesCom { get; set; }

        public double? NetTradesSales { get; set; }

        public double? NetTradesSalesSec { get; set; }

        public double? NetTradesSalesCom { get; set; }

        public double? NetTradesPurchases { get; set; }

        public double? NetTradesPurchasesSec { get; set; }

        public double? NetTradesPurchasesCom { get; set; }

        public double? AdvisorFees { get; set; }

        public double? AdvisorFeesSec { get; set; }

        public double? AdvisorFeesCom { get; set; }

        public double? FeesReceivables { get; set; }

        public double? FeesReceivablesSec { get; set; }

        public double? FeesReceivablesCom { get; set; }

        public double? PaymentInLieu { get; set; }

        public double? PaymentInLieuSec { get; set; }

        public double? PaymentInLieuCom { get; set; }

        public double? TransactionTax { get; set; }

        public double? TransactionTaxSec { get; set; }

        public double? TransactionTaxCom { get; set; }

        public double? TaxReceivables { get; set; }

        public double? TaxReceivablesSec { get; set; }

        public double? TaxReceivablesCom { get; set; }

        public double? WithholdingTax { get; set; }

        public double? WithholdingTaxSec { get; set; }

        public double? WithholdingTaxCom { get; set; }

        public double? Withholding871m { get; set; }

        public double? Withholding871mSec { get; set; }

        public double? Withholding871mCom { get; set; }

        public double? WithholdingCollectedTax { get; set; }

        public double? WithholdingCollectedTaxSec { get; set; }

        public double? WithholdingCollectedTaxCom { get; set; }

        public double? SalesTax { get; set; }

        public double? SalesTaxSec { get; set; }

        public double? SalesTaxCom { get; set; }

        public double? BillableSalesTax { get; set; }

        public double? BillableSalesTaxSec { get; set; }

        public double? BillableSalesTaxCom { get; set; }

        public double? IpoSubscription { get; set; }

        public double? IpoSubscriptionSec { get; set; }

        public double? IpoSubscriptionCom { get; set; }

        public double? FxTranslationGainLoss { get; set; }

        public double? FxTranslationGainLossSec { get; set; }

        public double? FxTranslationGainLossCom { get; set; }

        public double? OtherFees { get; set; }

        public double? OtherFeesSec { get; set; }

        public double? OtherFeesCom { get; set; }

        public double? Other { get; set; }

        public double? OtherSec { get; set; }

        public double? OtherCom { get; set; }

        public double? EndingCash { get; set; }

        public double? EndingCashSec { get; set; }

        public double? EndingCashCom { get; set; }

        public double? EndingSettledCash { get; set; }

        public double? EndingSettledCashSec { get; set; }

        public double? EndingSettledCashCom { get; set; }

        public double? SlbStartingCashCollateral { get; set; }

        public double? SlbStartingCashCollateralSec { get; set; }

        public double? SlbStartingCashCollateralCom { get; set; }

        public double? SlbNetSecuritiesLentActivity { get; set; }

        public double? SlbNetSecuritiesLentActivitySec { get; set; }

        public double? SlbNetSecuritiesLentActivityCom { get; set; }

        public double? SlbEndingCashCollateral { get; set; }

        public double? SlbEndingCashCollateralSec { get; set; }

        public double? SlbEndingCashCollateralCom { get; set; }

        public double? SlbNetCash { get; set; }

        public double? SlbNetCashSec { get; set; }

        public double? SlbNetCashCom { get; set; }

        public double? SlbNetSettledCash { get; set; }

        public double? SlbNetSettledCashSec { get; set; }

        public double? SlbNetSettledCashCom { get; set; }

        public double? InsuredDepositInterest { get; set; }

        public double? InsuredDepositInterestSec { get; set; }

        public double? InsuredDepositInterestCom { get; set; }

        public double? BrokerInterest { get; set; }

        public double? BrokerInterestSec { get; set; }

        public double? BrokerInterestCom { get; set; }

        public double? BondInterest { get; set; }

        public double? BondInterestSec { get; set; }

        public double? BondInterestCom { get; set; }


        public double? OtherIncome { get; set; }
        public double? OtherIncomeSec { get; set; }
        public double? OtherIncomeCom { get; set; }
    }
}
