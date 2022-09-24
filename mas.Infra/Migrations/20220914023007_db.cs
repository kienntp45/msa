using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace msa.Infra.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TradingCashs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ClientCode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CashAmount = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Advance = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    RemainSecuritiesPower = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    FSavingPower = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Adhoc = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MatchedBuy = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    PendingBuy = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    IntradayDebt = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    PendingBuyDebt = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MatchedBuyFee = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    PendingBuyFee = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    InternalTransfer = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ExternalTransfer = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    FeeSum = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    CreditLine = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    RemainDebt = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DebtInterest = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableT0 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableT1 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableT2 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableDividend = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableMatureCW = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableOddlot = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    FSaving = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    FSavingForPower = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    BankSaving = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradingCashs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradingFeeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ClientCode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FeeType = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Value = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradingFeeItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradingSecuritiesItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    StockCode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ClientCode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TradingAvail = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    TradingAvail_Mar = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    PendingSell = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    PendingSell_Mar = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MatchedSellIntraday = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MatchedSellIntraday_Mar = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Dividend = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Restricted = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MortgageAtBank = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Holding = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ESOP = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MarproSuspend = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MatchedBuyIntraday = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableT1 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableT2 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ReceivableRight = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    RestrictedWaiting = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    MortgageAtBankWaiting = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    HoldingWaiting = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    TradingWaiting = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    WaitingFromCustody = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ESOPWaiting = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    OddlotSellIntraday = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradingSecuritiesItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TradingCashs");

            migrationBuilder.DropTable(
                name: "TradingFeeItems");

            migrationBuilder.DropTable(
                name: "TradingSecuritiesItem");
        }
    }
}
