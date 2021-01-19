using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NltransController : ControllerBase
    {
        //private readonly IService _service;

        //public NltransController(IService service)
        //{
        //    _service = service;
        //}

        private readonly WRI6283Context _context;

        public NltransController(WRI6283Context context)
        {
            _context = context;
        }

        //public async Task<int> SaveChangesAsync()
        //{
        //    return await _context.SaveChangesAsync();
        //}


        // GET: api/Nltrans
        [HttpGet("GetAllSaleInvoices")]
        public async Task<ActionResult<IEnumerable<Nltran>>> GetAllSaleInvoices()
        {
            return await _context.Nltrans.Take(20).Where(x => x.NltSource == "SI").OrderByDescending(x => x.NltDate).ToArrayAsync();
        }

        [HttpGet("GetAllPurchaseInvoices")]
        public async Task<ActionResult<IEnumerable<Nltran>>> GetAllPurchaseInvoices()
        {
            return await _context.Nltrans.Take(20).Where(x => x.NltSource == "PI").OrderByDescending(x => x.NltDate).ToArrayAsync();
        }

        [HttpGet("GetByInvoiceNumberandSource")]
        public async Task<ActionResult<IEnumerable<Nltran>>> GetByInvoiceNumberandSource(string invNo, string source)
        {
            return await _context.Nltrans.Where(x => x.NltSource == source && x.NltInvNo == invNo).OrderByDescending(x => x.NltDate).ToArrayAsync();
        }

        //// GET: api/Nltrans/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Nltran>> GetNltran(long id)
        //{
        //    var nltran = await _context.Nltrans.FindAsync(id);

        //    if (nltran == null)
        //    {
        //        return NotFound();
        //    }

        //    return nltran;
        //}

        //// PUT: api/Nltrans/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutNltran(long id, Nltran nltran)
        //{
        //    if (id != nltran.NltKey)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(nltran).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!NltranExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        /// <summary>
        /// Use this to add  one or more rows to a purchase invoice
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Nltran>> SavePI(List<InputData> data)
        {


            foreach (var single in data)
            {
                // get intPeriod using datDate,companyData
                string stock = single.stock;
                string detail = single.detail;
                double qty = 0;
                double.TryParse(single.quantity, out qty);
                double price = 0;
                double.TryParse(single.price, out price);
                double disc = 0;
                double.TryParse(single.disc, out disc);
                string vatcode = single.vatcode;
                double vat = 0;
                double.TryParse(single.vat, out vat);
                double net = price * qty;
                // double.TryParse(, out net);
                string nominal = single.nominal;
                string costing = single.costing;
                string location = single.location;
                double packsize = 0;
                double.TryParse(single.packsize, out packsize);
                double exchRate = 1;
                double.TryParse(single.exrate, out exchRate);
                DateTime datYE = Convert.ToDateTime(DateTime.Now.AddYears(1));
                DateTime datDate = DateTime.Now;
                string Audit = "";
                int intPeriod = single.intPeriod;

                string InvNo = single.invNo;

                // returns the last lineNumber of the invoice that matches the given invoiceNo
                //line = await _context.Nltrans.OrderByDescending(x => x.NltDate).Select(x=>x.NltLineNo).SingleAsync();


                //int? lineno = await _context.Nltrans.OrderByDescending(x => x.NltDate).Where(x => x.NltInvNo == InvNo && x.NltSource == "PI")
                //   .Select(x => x.NltLineNo).Take(1).SingleAsync();

                //int line = 0;
                //int.TryParse(lineno.ToString(), out line);

                int line = 0;
                line += 1;
                Transactions purchases = new Transactions();


                purchases.DR_Control = single.DRControl;
                purchases.VAT_Control = single.VATControl;
                purchases.NLT_Audit = "PI/" + InvNo + "/" + line.ToString();
                purchases.NLT_Costing = costing;
                purchases.NLT_CurrNet = net;
                purchases.NLT_CurrVAT = vat;
                purchases.NLT_Detail = detail.Replace("'", "").Replace("&", "");
                purchases.NLT_InvNo = InvNo;
                purchases.NLT_LineNo = line;
                purchases.NLT_Location = location;
                purchases.NLT_Net = Math.Round(net / exchRate, 2);
                purchases.NLT_VAT = Math.Round(vat / exchRate, 2);
                purchases.NLT_VAT_Code = vatcode;
                purchases.NLT_Period = intPeriod;
                purchases.NLT_Price = price;
                purchases.NLT_Qty = qty;
                purchases.NLT_Packs = qty;
                purchases.NLT_Ref = single.Ref;
                purchases.NLT_Source = "PI";
                purchases.NLT_StockCode = stock;
                purchases.NLT_Units = packsize;
                purchases.NLT_YearEnd = datYE;
                double linedisc = 0;
                purchases.NL_Code = single.nominal;

                string invoicedate = DateTime.Now.ToString();
                DateTime invdate;
                DateTime.TryParse(invoicedate, out invdate);
                string ddate = DateTime.Now.ToString();
                DateTime dDate;
                DateTime.TryParse(ddate, out dDate);
                string settledate = DateTime.Now.AddDays(2).ToString();
                DateTime setdate;
                DateTime.TryParse(settledate, out setdate);
                string currency = single.currency;
                string exchrate = single.exrate;
                string orderno = single.orderNo;
                string deliveryadd = single.deliveryAdd;
                string invoiceref = single.invRef;
                string enteredby = single.enteredBy;
                string notes = single.notes;
                string description = single.description;
                string salesagent = "";

                // and is also PI transaction


                // creates a purchases object 



                // create stockTracking using session values


                string stockTracking = "StockTracking";
                if (stockTracking == "StockTracking")
                {
                    bool chkIsSerial = true;
                    String TrackingNumber = single.TrackingNumber;
                    string TrackingEntryDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    TrackingNumber = TrackingNumber == "" ? stock + "/NoTracking" : TrackingNumber;

                    if (TrackingNumber != "")
                    {
                        var sTK = new StockTracking
                        {
                            TrackingEntryDate = Convert.ToDateTime(TrackingEntryDate),
                            IsSerial = chkIsSerial,
                            TrackingNo = TrackingNumber,
                            TrackingTypeId = single.TrackingTypeID,
                            TrackingReference = purchases.NLT_Audit,
                            StockItem = stock,
                            Qty = qty,
                            LocationCode = single.LocationCode

                        };

                        await _context.StockTrackings.AddAsync(sTK);
                        int SID = await _context.SaveChangesAsync();

                        int UID = 0;

                        if (SID > 0)
                        {
                            if (TrackingNumber != stock + "/NoTracking")
                            {
                                if (chkIsSerial)
                                {
                                    var SN = await _context.SerialNumbers.Where(x => x.SerialNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                    SN.StatusId = 3;
                                    _context.SerialNumbers.Update(SN);
                                    await _context.SaveChangesAsync();
                                }

                                else
                                {
                                    var BN = await _context.BatchNumbers.Where(x => x.BatchNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                    BN.StatusId = 3;
                                    _context.BatchNumbers.Update(BN);
                                    await _context.SaveChangesAsync();
                                }



                            }


                        }



                    }
                }



                // string 

                // create stockTracking object

                //trackingnumber is "0000+id"
                //trackingRef = purchases.NLT_Audit




                // save stock trading 

                // save nltran with 3 diifferent vat values


                var firstTran = new Nltran
                {
                    NltLineNo = purchases.NLT_LineNo,
                    NltStockCode = purchases.NLT_StockCode,
                    NltDetail = purchases.NLT_Detail,
                    NltUnits = (decimal?)purchases.NLT_Units,
                    NltQty = (decimal?)purchases.NLT_Qty,
                    NltPrice = (decimal?)purchases.NLT_Price,
                    NltNet = (decimal?)purchases.NLT_Net,
                    NltVatCode = purchases.NLT_VAT_Code,
                    NltVat = (decimal?)purchases.NLT_VAT,
                    NlCode = "Original Transaction",
                    NltPaid = (decimal?)purchases.NLT_Paid,
                    NltRef = purchases.NLT_Ref,
                    NltSource = purchases.NLT_Source,
                    NltAudit = purchases.NLT_Audit,
                    NltCurrNet = (decimal?)purchases.NLT_CurrNet,
                    NltCurrVat = (decimal?)purchases.NLT_CurrVAT,
                    NltInvNo = purchases.NLT_InvNo,
                    NltLocation = purchases.NLT_Location,
                    NltYearEnd = purchases.NLT_YearEnd,
                    NltPeriod = purchases.NLT_Period,
                    NltCosting = purchases.NLT_Costing,
                    LineDiscount = (decimal?)linedisc,
                    NltPacks = (decimal?)purchases.NLT_Packs
                };


                var secTran = new Nltran
                {
                    NltLineNo = purchases.NLT_LineNo,
                    NltStockCode = purchases.NLT_StockCode,
                    NltDetail = purchases.NLT_Detail,
                    NltUnits = (decimal?)purchases.NLT_Units,
                    NltQty = (decimal?)purchases.NLT_Qty * -1,
                    NltPrice = (decimal?)purchases.NLT_Price,
                    NltNet = (decimal?)((purchases.NLT_Net + purchases.NLT_VAT) * -1),
                    NltVatCode = purchases.NLT_VAT_Code,
                    NltVat = (decimal?)purchases.NLT_VAT * -1,
                    NlCode = "DECTRL",
                    NltPaid = 0,
                    NltRef = purchases.NLT_Ref,
                    NltSource = purchases.NLT_Source,
                    NltAudit = purchases.NLT_Audit,
                    NltCurrNet = (decimal?)((purchases.NLT_CurrNet + purchases.NLT_CurrVAT) * -1),
                    NltCurrVat = (decimal?)purchases.NLT_CurrVAT,
                    NltInvNo = purchases.NLT_InvNo,
                    NltLocation = purchases.NLT_Location,
                    NltYearEnd = purchases.NLT_YearEnd,
                    NltPeriod = purchases.NLT_Period,
                    NltCosting = purchases.NLT_Costing,
                    LineDiscount = (decimal?)linedisc,
                    NltPacks = (decimal?)purchases.NLT_Packs
                };
                var thirdTran = new Nltran
                {
                    NltLineNo = purchases.NLT_LineNo,
                    NltStockCode = purchases.NLT_StockCode,
                    NltDetail = purchases.NLT_Detail,
                    NltUnits = (decimal?)purchases.NLT_Units,
                    NltQty = (decimal?)purchases.NLT_Qty,
                    NltPrice = (decimal?)purchases.NLT_Price,
                    NltNet = (decimal?)(purchases.NLT_VAT),
                    NltVatCode = purchases.NLT_VAT_Code,
                    NltVat = (decimal?)purchases.NLT_Net,
                    NlCode = "VATCRTL",
                    NltPaid = 0,
                    NltRef = purchases.NLT_Ref,
                    NltSource = purchases.NLT_Source,
                    NltAudit = purchases.NLT_Audit,
                    NltCurrNet = (decimal?)(purchases.NLT_CurrNet),
                    NltCurrVat = (decimal?)purchases.NLT_CurrVAT,
                    NltInvNo = purchases.NLT_InvNo,
                    NltLocation = purchases.NLT_Location,
                    NltYearEnd = purchases.NLT_YearEnd,
                    NltPeriod = purchases.NLT_Period,
                    NltCosting = purchases.NLT_Costing,
                    LineDiscount = (decimal?)linedisc,
                    NltPacks = (decimal?)purchases.NLT_Packs
                };


                // await _context.Nltrans.AddAsync(firstTran);
                var transList = new Nltran[] { firstTran, secTran, thirdTran };

                //await _context.Nltrans.AddAsync(firstTran);

                //await _context.Nltrans.AddAsync(secTran);

                //await _context.Nltrans.AddAsync(thirdTran);

                //try
                //{
                //    await _context.SaveChangesAsync();
                //}
                //catch(Exception ex)
                //{
                //    throw ex;
                //}


                //var transList = new Nltran[] { firstTran, secTran, thirdTran };
                await _context.Nltrans.AddRangeAsync(transList);
                await _context.SaveChangesAsync();

                Audit = Audit + "Line: " + line.ToString() + Environment.NewLine;
                Audit = Audit + "Stock/Item: " + purchases.NLT_StockCode + Environment.NewLine;
                Audit = Audit + "Detail: " + detail.Replace("'", "").Replace("&", "") + Environment.NewLine;
                Audit = Audit + "Qty: " + purchases.NLT_Qty.ToString("N") + Environment.NewLine;
                Audit = Audit + "Location: " + purchases.NLT_Location + Environment.NewLine;
                Audit = Audit + "Pack Size: " + purchases.NLT_Units + Environment.NewLine;
                Audit = Audit + "Unit Price: " + purchases.NLT_Price.ToString("N") + Environment.NewLine;
                Audit = Audit + "Net in Currency: " + net.ToString("N") + Environment.NewLine;
                Audit = Audit + "Vat in Currency: " + vat.ToString("N") + Environment.NewLine;
                Audit = Audit + "Net: " + purchases.NLT_Net.ToString("N") + Environment.NewLine;
                Audit = Audit + "Vat: " + purchases.NLT_VAT.ToString("N") + Environment.NewLine;
                Audit = Audit + "Vat Code: " + purchases.NLT_VAT_Code + Environment.NewLine;
                Audit = Audit + "Date: " + invdate.ToShortDateString() + Environment.NewLine;
                Audit = Audit + "Due Date: " + dDate.ToShortDateString() + Environment.NewLine;
                Audit = Audit + "Settle Date: " + setdate.ToShortDateString() + Environment.NewLine;
                Audit = Audit + "Currency: " + currency.ToString() + Environment.NewLine;
                Audit = Audit + "Exch Rate: " + exchrate.ToString() + Environment.NewLine;
                Audit = Audit + "Order: " + orderno.ToString() + Environment.NewLine;
                Audit = Audit + "description: " + description.ToString() + Environment.NewLine;
                Audit = Audit + "notes: " + notes.ToString() + Environment.NewLine;
                if (costing.Trim() != "")
                {
                    Audit = Audit + "Costing: " + costing + Environment.NewLine;
                }
                if (salesagent.Trim() != "")
                {
                    Audit = Audit + "Sales Agent: " + salesagent + Environment.NewLine;
                }






                //update ntran where nlt_souurce='PI',NLT_InvNo=NLT_InvNo
                //nlt_ref=NLT_Ref  for the invoice header props


                var nlTrans = await _context.Nltrans.
                                            Where(x => x.NltSource == single.Source && x.NltInvNo == single.invNo && x.NltRef == single.Ref).
                                            ToArrayAsync();

                float.TryParse(exchrate, out float exRate);
                foreach (var tran in nlTrans)
                {
                    tran.NltDate = invdate;
                    tran.NltCurrCode = currency;
                    tran.NltExchRate = exRate;
                    tran.NltDueDate = dDate;
                    tran.NltDeliverDate = setdate;
                    tran.NltNotes = notes;
                    tran.NltOrderNo = orderno;
                    tran.NltDelAdd = deliveryadd;
                    tran.Salesman = salesagent;
                    tran.NltTheirRef = invoiceref;
                    tran.NltContra = "";
                    tran.NltEnteredBy = enteredby;
                    tran.NltInvoiceRef = description;

                    _context.Nltrans.Update(tran);
                    await _context.SaveChangesAsync();

                }

                try
                {


                    // assuming costingTypeID > 1
                    int costingTypeID = 3;
                    if (costingTypeID > 1)
                    {
                        var stkCosting = new StockCosting
                        {
                            CostingEntryDate = DateTime.Now,
                            CostingTypeId = 2,
                            CostingReference = purchases.NLT_Audit,
                            StockItem = stock,
                            UnitCost = Convert.ToDecimal(price),
                            Qty = qty,
                            LocationCode = single.LocationCode

                        };

                        await _context.StockCostings.AddAsync(stkCosting);
                    }

                    var aud = new Audit
                    {
                        Date = DateTime.Now,
                        AuditRef = purchases.NLT_Audit,
                        UserId = 1,
                        Action = "Insert",
                        Changes = Audit
                    };

                    await _context.Audits.AddAsync(aud);




                }
                catch { }

                // if the above action is not succesful ,return

                //else, save stock_costing and save audit
            }

            //_context.Nltrans.Add(nltran);
            //await _context.SaveChangesAsync();

            return Ok();
        }



        /// <summary>
        /// Use this to update a one or more rows in purchase invoice
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost("UpdatePI")]
        public async Task<ActionResult<Nltran>> UpdatePI(List<InputData> data)
        {
            foreach (var single in data)
            {
                // get intPeriod using datDate,companyData
                string stock = single.stock;
                string detail = single.detail;
                double qty = 0;
                double.TryParse(single.quantity, out qty);
                double price = 0;
                double.TryParse(single.price, out price);
                double disc = 0;
                double.TryParse(single.disc, out disc);
                string vatcode = single.vatcode;
                double vat = 0;
                double.TryParse(single.vat, out vat);
                double net = price * qty;
                // double.TryParse(, out net);
                string nominal = single.nominal;
                string costing = single.costing;
                string location = single.location;
                double packsize = 0;
                double.TryParse(single.packsize, out packsize);
                double exchRate = 1;
                double.TryParse(single.exrate, out exchRate);
                DateTime datYE = Convert.ToDateTime(DateTime.Now.AddYears(1));
                DateTime datDate = DateTime.Now;
                string Audit = "";
                int intPeriod = single.intPeriod;

                string InvNo = single.invNo;

                // returns the last lineNumber of the invoice that matches the given invoiceNo
                //line = await _context.Nltrans.OrderByDescending(x => x.NltDate).Select(x=>x.NltLineNo).SingleAsync();


                //int? lineno = await _context.Nltrans.OrderByDescending(x => x.NltDate).Where(x => x.NltInvNo == InvNo && x.NltSource == "PI")
                //   .Select(x => x.NltLineNo).Take(1).SingleAsync();

                //int line = 0;
                //int.TryParse(lineno.ToString(), out line);

                int line = 0;


                // CHECK IF LINE IS GREATER THAN 1 , THEN CONTINUE

                var lineno = _context.Nltrans.Where(x => x.NltInvNo == InvNo).Select(x => x.NltLineNo).FirstOrDefault().ToString();

                int.TryParse(lineno, out line);

                if (line > 0)
                {
                    Transactions purchases = new Transactions();


                    purchases.DR_Control = single.DRControl;
                    purchases.VAT_Control = single.VATControl;
                    purchases.NLT_Audit = "PI/" + InvNo + "/" + line.ToString();
                    purchases.NLT_Costing = costing;
                    purchases.NLT_CurrNet = net;
                    purchases.NLT_CurrVAT = vat;
                    purchases.NLT_Detail = detail.Replace("'", "").Replace("&", "");
                    purchases.NLT_InvNo = InvNo;
                    purchases.NLT_LineNo = line;
                    purchases.NLT_Location = location;
                    purchases.NLT_Net = Math.Round(net / exchRate, 2);
                    purchases.NLT_VAT = Math.Round(vat / exchRate, 2);
                    purchases.NLT_VAT_Code = vatcode;
                    purchases.NLT_Period = intPeriod;
                    purchases.NLT_Price = price;
                    purchases.NLT_Qty = qty;
                    purchases.NLT_Packs = qty;
                    purchases.NLT_Ref = single.Ref;
                    purchases.NLT_Source = "PI";
                    purchases.NLT_StockCode = stock;
                    purchases.NLT_Units = packsize;
                    purchases.NLT_YearEnd = datYE;
                    double linedisc = 0;
                    purchases.NL_Code = single.nominal;

                    string invoicedate = DateTime.Now.ToString();
                    DateTime invdate;
                    DateTime.TryParse(invoicedate, out invdate);
                    string ddate = DateTime.Now.ToString();
                    DateTime dDate;
                    DateTime.TryParse(ddate, out dDate);
                    string settledate = DateTime.Now.AddDays(2).ToString();
                    DateTime setdate;
                    DateTime.TryParse(settledate, out setdate);
                    string currency = single.currency;
                    string exchrate = single.exrate;
                    string orderno = single.orderNo;
                    string deliveryadd = single.deliveryAdd;
                    string invoiceref = single.invRef;
                    string enteredby = single.enteredBy;
                    string notes = single.notes;
                    string description = single.description;
                    string salesagent = "";

                    // and is also PI transaction


                    // creates a purchases object 



                    // create stockTracking using session values


                    string stockTracking = "StockTracking";
                    if (stockTracking == "StockTracking")
                    {
                        bool chkIsSerial = true;
                        String TrackingNumber = single.TrackingNumber;
                        string TrackingEntryDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        TrackingNumber = TrackingNumber == "" ? stock + "/NoTracking" : TrackingNumber;

                        if (TrackingNumber != "")
                        {
                            var sTK = new StockTracking
                            {
                                TrackingEntryDate = Convert.ToDateTime(TrackingEntryDate),
                                IsSerial = chkIsSerial,
                                TrackingNo = TrackingNumber,
                                TrackingTypeId = single.TrackingTypeID,
                                TrackingReference = purchases.NLT_Audit,
                                StockItem = stock,
                                Qty = qty,
                                LocationCode = single.LocationCode

                            };

                            await _context.StockTrackings.AddAsync(sTK);
                            int SID = await _context.SaveChangesAsync();

                            int UID = 0;

                            if (SID > 0)
                            {
                                if (TrackingNumber != stock + "/NoTracking")
                                {
                                    if (chkIsSerial)
                                    {
                                        var SN = await _context.SerialNumbers.Where(x => x.SerialNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                        SN.StatusId = 3;
                                        _context.SerialNumbers.Update(SN);
                                        await _context.SaveChangesAsync();
                                    }

                                    else
                                    {
                                        var BN = await _context.BatchNumbers.Where(x => x.BatchNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                        BN.StatusId = 3;
                                        _context.BatchNumbers.Update(BN);
                                        await _context.SaveChangesAsync();
                                    }



                                }


                            }



                        }
                    }



                    // string 

                    // create stockTracking object

                    //trackingnumber is "0000+id"
                    //trackingRef = purchases.NLT_Audit




                    // save stock trading 

                    // save nltran with 3 diifferent vat values

                    //UPDATE NLTRAN USING(NLT_Source = 'PI') AND(NLT_InvNo = @NLT_InvNo) AND(NLT_LineNo = @NLT_LineNo) AND(NL_Code = @VAT_Control) and nlt_ref = @NLT_Ref


                    var firstTran = await _context.Nltrans.Where(x => x.NltSource == purchases.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == purchases.NLT_LineNo && x.NlCode == "Original Transaction").SingleOrDefaultAsync();

                    var secTran = await _context.Nltrans.Where(x => x.NltSource == purchases.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == purchases.NLT_LineNo && x.NlCode == "DECTRL").SingleOrDefaultAsync();

                    var thirdTran = await _context.Nltrans.Where(x => x.NltSource == purchases.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == purchases.NLT_LineNo && x.NlCode == "VATCRTL").SingleOrDefaultAsync();

                    firstTran.NltStockCode = purchases.NLT_StockCode;
                    firstTran.NltDetail = purchases.NLT_Detail;
                    firstTran.NltUnits = (decimal?)purchases.NLT_Units;
                    firstTran.NltQty = (decimal?)purchases.NLT_Qty;
                    firstTran.NltPrice = (decimal?)purchases.NLT_Price;
                    firstTran.NltNet = (decimal?)purchases.NLT_Net;
                    firstTran.NltVatCode = purchases.NLT_VAT_Code;
                    firstTran.NltVat = (decimal?)purchases.NLT_VAT;
                    firstTran.NltPaid = (decimal?)purchases.NLT_Paid;
                    firstTran.NltCurrNet = (decimal?)purchases.NLT_CurrNet;
                    firstTran.NltCurrVat = (decimal?)purchases.NLT_CurrVAT;
                    firstTran.NltLocation = purchases.NLT_Location;
                    firstTran.NltYearEnd = purchases.NLT_YearEnd;
                    firstTran.NltPeriod = purchases.NLT_Period;
                    firstTran.NltCosting = purchases.NLT_Costing;
                    firstTran.LineDiscount = (decimal?)linedisc;
                    firstTran.NltPacks = (decimal?)purchases.NLT_Packs;


                    secTran.NltStockCode = purchases.NLT_StockCode;
                    secTran.NltDetail = purchases.NLT_Detail;
                    secTran.NltUnits = (decimal?)purchases.NLT_Units;
                    secTran.NltQty = (decimal?)purchases.NLT_Qty * -1;
                    secTran.NltPrice = (decimal?)purchases.NLT_Price;
                    secTran.NltNet = (decimal?)((purchases.NLT_Net + purchases.NLT_VAT) * -1);
                    secTran.NltVatCode = purchases.NLT_VAT_Code;
                    secTran.NltVat = (decimal?)purchases.NLT_VAT * -1;
                    secTran.NltPaid = (decimal?)purchases.NLT_Paid;
                    secTran.NltCurrNet = (decimal?)(-purchases.NLT_CurrNet - purchases.NLT_CurrVAT);
                    secTran.NltCurrVat = (decimal?)purchases.NLT_CurrVAT;
                    secTran.NltLocation = purchases.NLT_Location;
                    secTran.NltYearEnd = purchases.NLT_YearEnd;
                    secTran.NltPeriod = purchases.NLT_Period;
                    secTran.NltCosting = purchases.NLT_Costing;
                    secTran.LineDiscount = (decimal?)linedisc;
                    secTran.NltPacks = (decimal?)purchases.NLT_Packs;


                    thirdTran.NltStockCode = purchases.NLT_StockCode;
                    thirdTran.NltDetail = purchases.NLT_Detail;
                    thirdTran.NltUnits = (decimal?)purchases.NLT_Units;
                    thirdTran.NltQty = (decimal?)purchases.NLT_Qty;
                    thirdTran.NltPrice = (decimal?)purchases.NLT_Price;
                    thirdTran.NltNet = (decimal?)purchases.NLT_VAT;
                    thirdTran.NltVatCode = purchases.NLT_VAT_Code;
                    thirdTran.NltVat = (decimal?)purchases.NLT_Net;
                    thirdTran.NltPaid = (decimal?)purchases.NLT_Paid;
                    thirdTran.NltCurrNet = (decimal?)(purchases.NLT_CurrNet);
                    thirdTran.NltYearEnd = purchases.NLT_YearEnd;
                    thirdTran.NltPeriod = purchases.NLT_Period;
                    thirdTran.NltCurrVat = (decimal?)purchases.NLT_CurrVAT;
                    thirdTran.NltLocation = purchases.NLT_Location;
                    thirdTran.NltCosting = purchases.NLT_Costing;
                    thirdTran.LineDiscount = (decimal?)linedisc;
                    thirdTran.NltPacks = (decimal?)purchases.NLT_Packs;






                    // await _context.Nltrans.AddAsync(firstTran);
                    var transList = new Nltran[] { firstTran, secTran, thirdTran };

                    //await _context.Nltrans.AddAsync(firstTran);

                    //await _context.Nltrans.AddAsync(secTran);

                    //await _context.Nltrans.AddAsync(thirdTran);

                    //try
                    //{
                    //    await _context.SaveChangesAsync();
                    //}
                    //catch(Exception ex)
                    //{
                    //    throw ex;
                    //}

                    // UPDATE NLTRAN USING (NLT_Source = 'PI') AND (NLT_InvNo = @NLT_InvNo) AND (NLT_LineNo = @NLT_LineNo) AND (NL_Code = @VAT_Control) and nlt_ref=@NLT_Ref

                    //var transList = new Nltran[] { firstTran, secTran, thirdTran };
                    _context.Nltrans.UpdateRange(transList);
                    await _context.SaveChangesAsync();

                    Audit = Audit + "Line: " + line.ToString() + Environment.NewLine;
                    Audit = Audit + "Stock/Item: " + purchases.NLT_StockCode + Environment.NewLine;
                    Audit = Audit + "Detail: " + detail.Replace("'", "").Replace("&", "") + Environment.NewLine;
                    Audit = Audit + "Qty: " + purchases.NLT_Qty.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Location: " + purchases.NLT_Location + Environment.NewLine;
                    Audit = Audit + "Pack Size: " + purchases.NLT_Units + Environment.NewLine;
                    Audit = Audit + "Unit Price: " + purchases.NLT_Price.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Net in Currency: " + net.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Vat in Currency: " + vat.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Net: " + purchases.NLT_Net.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Vat: " + purchases.NLT_VAT.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Vat Code: " + purchases.NLT_VAT_Code + Environment.NewLine;
                    Audit = Audit + "Date: " + invdate.ToShortDateString() + Environment.NewLine;
                    Audit = Audit + "Due Date: " + dDate.ToShortDateString() + Environment.NewLine;
                    Audit = Audit + "Settle Date: " + setdate.ToShortDateString() + Environment.NewLine;
                    Audit = Audit + "Currency: " + currency.ToString() + Environment.NewLine;
                    Audit = Audit + "Exch Rate: " + exchrate.ToString() + Environment.NewLine;
                    Audit = Audit + "Order: " + orderno.ToString() + Environment.NewLine;
                    Audit = Audit + "description: " + description.ToString() + Environment.NewLine;
                    Audit = Audit + "notes: " + notes.ToString() + Environment.NewLine;
                    if (costing.Trim() != "")
                    {
                        Audit = Audit + "Costing: " + costing + Environment.NewLine;
                    }
                    if (salesagent.Trim() != "")
                    {
                        Audit = Audit + "Sales Agent: " + salesagent + Environment.NewLine;
                    }






                    //update ntran where nlt_souurce='PI',NLT_InvNo=NLT_InvNo
                    //nlt_ref=NLT_Ref  for the invoice header props


                    var nlTrans = await _context.Nltrans.
                                                Where(x => x.NltSource == single.Source && x.NltInvNo == single.invNo && x.NltRef == single.Ref).
                                                ToArrayAsync();

                    float.TryParse(exchrate, out float exRate);
                    foreach (var tran in nlTrans)
                    {
                        tran.NltDate = invdate;
                        tran.NltCurrCode = currency;
                        tran.NltExchRate = exRate;
                        tran.NltDueDate = dDate;
                        tran.NltDeliverDate = setdate;
                        tran.NltNotes = notes;
                        tran.NltOrderNo = orderno;
                        tran.NltDelAdd = deliveryadd;
                        tran.Salesman = salesagent;
                        tran.NltTheirRef = invoiceref;
                        tran.NltContra = "";
                        tran.NltEnteredBy = enteredby;
                        tran.NltInvoiceRef = description;

                        _context.Nltrans.Update(tran);
                        await _context.SaveChangesAsync();

                    }

                    try
                    {


                        // assuming costingTypeID > 1
                        int costingTypeID = 3;
                        if (costingTypeID > 1)
                        {
                            var stkCosting = new StockCosting
                            {
                                CostingEntryDate = DateTime.Now,
                                CostingTypeId = 2,
                                CostingReference = purchases.NLT_Audit,
                                StockItem = stock,
                                UnitCost = Convert.ToDecimal(price),
                                Qty = qty,
                                LocationCode = single.LocationCode

                            };

                            await _context.StockCostings.AddAsync(stkCosting);
                        }

                        var aud = new Audit
                        {
                            Date = DateTime.Now,
                            AuditRef = purchases.NLT_Audit,
                            UserId = 1,
                            Action = "Insert",
                            Changes = Audit
                        };

                        await _context.Audits.AddAsync(aud);




                    }
                    catch
                    { }

                }


                // if the above action is not succesful ,return

                //else, save stock_costing and save audit
            }

            return Ok();
        }


        /// <summary>
        /// Use this to update a one or more rows in sale invoice
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost("UpdateSI")]
        public async Task<ActionResult<Nltran>> UpdateSI(List<SaleInput> data)
        {
            foreach (var single in data)
            {
                // get intPeriod using datDate,companyData
                string stock = single.stock;
                string detail = single.detail;
                double qty = 0;
                double.TryParse(single.quantity, out qty);
                double price = 0;
                double.TryParse(single.price, out price);
                double disc = 0;
                double.TryParse(single.disc, out disc);
                string vatcode = single.vatcode;
                double vat = 0;
                double.TryParse(single.vat, out vat);
                double net = price * qty;
                double currcost = 0;
                double.TryParse(single.currcost, out currcost);
                double saleCostPrice = 0;
                double.TryParse(single.saleCostPrice, out saleCostPrice);

                // double.TryParse(, out net);
                string nominal = single.nominal;
                string costing = single.costing;
                string location = single.location;
                double packsize = 0;
                double.TryParse(single.packsize, out packsize);
                double exchRate = 1;
                double.TryParse(single.exrate, out exchRate);
                currcost = saleCostPrice.ToString() != "" ? (saleCostPrice * exchRate) : currcost;
                DateTime datYE = Convert.ToDateTime(DateTime.Now.AddYears(1));
                DateTime datDate = DateTime.Now;
                string Audit = "";
                int intPeriod = single.intPeriod;

                string InvNo = single.invNo;

                // returns the last lineNumber of the invoice that matches the given invoiceNo
                //line = await _context.Nltrans.OrderByDescending(x => x.NltDate).Select(x=>x.NltLineNo).SingleAsync();


                //int? lineno = await _context.Nltrans.OrderByDescending(x => x.NltDate).Where(x => x.NltInvNo == InvNo && x.NltSource == "PI")
                //   .Select(x => x.NltLineNo).Take(1).SingleAsync();

                //int line = 0;
                //int.TryParse(lineno.ToString(), out line);

                int line = 0;


                // CHECK IF LINE IS GREATER THAN 1 , THEN CONTINUE

                var lineno = _context.Nltrans.Where(x => x.NltInvNo == InvNo).Select(x => x.NltLineNo).FirstOrDefault().ToString();

                int.TryParse(lineno, out line);

                if (line > 0)
                {
                    Transactions sales = new Transactions();


                    sales.DR_Control = single.DRControl;
                    sales.VAT_Control = single.VATControl;
                    sales.NLT_Audit = "SI/" + InvNo + "/" + line.ToString();
                    sales.NLT_Costing = costing;
                    sales.NLT_CurrNet = net;
                    sales.NLT_CurrVAT = vat;
                    sales.NLT_Detail = detail.Replace("'", "").Replace("&", "");
                    sales.NLT_InvNo = InvNo;
                    sales.NLT_LineNo = line;
                    sales.NLT_Location = location;
                    sales.NLT_Net = Math.Round(net / exchRate, 2);
                    sales.NLT_VAT = Math.Round(vat / exchRate, 2);
                    sales.NLT_VAT_Code = vatcode;
                    sales.NLT_Period = intPeriod;
                    sales.NLT_Price = price;
                    sales.NLT_Qty = qty;
                    sales.NLT_Packs = qty;
                    sales.NLT_Ref = single.Ref;
                    sales.NLT_Source = "SI";
                    sales.NLT_StockCode = stock;
                    sales.NLT_Units = packsize;
                    sales.NLT_YearEnd = datYE;
                    double linedisc = 0;
                    sales.NL_Code = single.nominal;

                    string invoicedate = DateTime.Now.ToString();
                    DateTime invdate;
                    DateTime.TryParse(invoicedate, out invdate);
                    string ddate = DateTime.Now.ToString();
                    DateTime dDate;
                    DateTime.TryParse(ddate, out dDate);
                    string settledate = DateTime.Now.AddDays(2).ToString();
                    DateTime setdate;
                    DateTime.TryParse(settledate, out setdate);
                    string currency = single.currency;
                    string exchrate = single.exrate;
                    string orderno = single.orderNo;
                    string deliveryadd = single.deliveryAdd;
                    string invoiceref = single.invRef;
                    string enteredby = single.enteredBy;
                    string notes = single.notes;
                    string description = single.description;
                    string salesagent = "";

                    // and is also PI transaction


                    // creates a sales object 



                    // create stockTracking using session values


                    string stockTracking = "StockTracking";
                    if (stockTracking == "StockTracking")
                    {
                        bool chkIsSerial = true;
                        String TrackingNumber = single.TrackingNumber;
                        string TrackingEntryDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        TrackingNumber = TrackingNumber == "" ? stock + "/NoTracking" : TrackingNumber;

                        if (TrackingNumber != "")
                        {
                            var sTK = new StockTracking
                            {
                                TrackingEntryDate = Convert.ToDateTime(TrackingEntryDate),
                                IsSerial = chkIsSerial,
                                TrackingNo = TrackingNumber,
                                TrackingTypeId = single.TrackingTypeID,
                                TrackingReference = sales.NLT_Audit,
                                StockItem = stock,
                                Qty = qty,
                                LocationCode = single.LocationCode

                            };

                            await _context.StockTrackings.AddAsync(sTK);
                            int SID = await _context.SaveChangesAsync();

                            int UID = 0;

                            if (SID > 0)
                            {
                                if (TrackingNumber != stock + "/NoTracking")
                                {
                                    if (chkIsSerial)
                                    {
                                        var SN = await _context.SerialNumbers.Where(x => x.SerialNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                        SN.StatusId = 3;
                                        _context.SerialNumbers.Update(SN);
                                        await _context.SaveChangesAsync();
                                    }

                                    else
                                    {
                                        var BN = await _context.BatchNumbers.Where(x => x.BatchNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                        BN.StatusId = 3;
                                        _context.BatchNumbers.Update(BN);
                                        await _context.SaveChangesAsync();
                                    }



                                }


                            }



                        }
                    }



                    // string 

                    // create stockTracking object

                    //trackingnumber is "0000+id"
                    //trackingRef = sales.NLT_Audit




                    // save stock trading 

                    // save nltran with 3 diifferent vat values

                    //UPDATE NLTRAN USING(NLT_Source = 'PI') AND(NLT_InvNo = @NLT_InvNo) AND(NLT_LineNo = @NLT_LineNo) AND(NL_Code = @VAT_Control) and nlt_ref = @NLT_Ref


                    var firstTran = await _context.Nltrans.Where(x => x.NltSource == sales.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == sales.NLT_LineNo && x.NlCode == "Original Transaction").SingleOrDefaultAsync();

                    var secTran = await _context.Nltrans.Where(x => x.NltSource == sales.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == sales.NLT_LineNo && x.NlCode == "DECTRL").SingleOrDefaultAsync();

                    var thirdTran = await _context.Nltrans.Where(x => x.NltSource == sales.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == sales.NLT_LineNo && x.NlCode == "VATCRTL").SingleOrDefaultAsync();

                    //firstTran.NltStockCode = sales.NLT_StockCode;
                    //firstTran.NltDetail = sales.NLT_Detail;
                    //firstTran.NltUnits = (decimal?)sales.NLT_Units;
                    //firstTran.NltQty = (decimal?)sales.NLT_Qty;
                    //firstTran.NltPrice = (decimal?)sales.NLT_Price;
                    //firstTran.NltNet = (decimal?)sales.NLT_Net;
                    //firstTran.NltVatCode = sales.NLT_VAT_Code;
                    //firstTran.NltVat = (decimal?)sales.NLT_VAT;
                    //firstTran.NltPaid = (decimal?)sales.NLT_Paid;
                    //firstTran.NltCurrNet = (decimal?)sales.NLT_CurrNet;
                    //firstTran.NltCurrVat = (decimal?)sales.NLT_CurrVAT;
                    //firstTran.NltLocation = sales.NLT_Location;
                    //firstTran.NltYearEnd = sales.NLT_YearEnd;
                    //firstTran.NltPeriod = sales.NLT_Period;
                    //firstTran.NltCosting = sales.NLT_Costing;
                    //firstTran.LineDiscount = (decimal?)linedisc;
                    //firstTran.NltPacks = (decimal?)sales.NLT_Packs;


                    //secTran.NltStockCode = sales.NLT_StockCode;
                    //secTran.NltDetail = sales.NLT_Detail;
                    //secTran.NltUnits = (decimal?)sales.NLT_Units;
                    //secTran.NltQty = (decimal?)sales.NLT_Qty * -1;
                    //secTran.NltPrice = (decimal?)sales.NLT_Price;
                    //secTran.NltNet = (decimal?)((sales.NLT_Net + sales.NLT_VAT) * -1);
                    //secTran.NltVatCode = sales.NLT_VAT_Code;
                    //secTran.NltVat = (decimal?)sales.NLT_VAT * -1;
                    //secTran.NltPaid = (decimal?)sales.NLT_Paid;
                    //secTran.NltCurrNet = (decimal?)(-sales.NLT_CurrNet - sales.NLT_CurrVAT);
                    //secTran.NltCurrVat = (decimal?)sales.NLT_CurrVAT;
                    //secTran.NltLocation = sales.NLT_Location;
                    //secTran.NltYearEnd = sales.NLT_YearEnd;
                    //secTran.NltPeriod = sales.NLT_Period;
                    //secTran.NltCosting = sales.NLT_Costing;
                    //secTran.LineDiscount = (decimal?)linedisc;
                    //secTran.NltPacks = (decimal?)sales.NLT_Packs;


                    //thirdTran.NltStockCode = sales.NLT_StockCode;
                    //thirdTran.NltDetail = sales.NLT_Detail;
                    //thirdTran.NltUnits = (decimal?)sales.NLT_Units;
                    //thirdTran.NltQty = (decimal?)sales.NLT_Qty;
                    //thirdTran.NltPrice = (decimal?)sales.NLT_Price;
                    //thirdTran.NltNet = (decimal?)sales.NLT_VAT;
                    //thirdTran.NltVatCode = sales.NLT_VAT_Code;
                    //thirdTran.NltVat = (decimal?)sales.NLT_Net;
                    //thirdTran.NltPaid = (decimal?)sales.NLT_Paid;
                    //thirdTran.NltCurrNet = (decimal?)(sales.NLT_CurrNet);
                    //thirdTran.NltYearEnd = sales.NLT_YearEnd;
                    //thirdTran.NltPeriod = sales.NLT_Period;
                    //thirdTran.NltCurrVat = (decimal?)sales.NLT_CurrVAT;
                    //thirdTran.NltLocation = sales.NLT_Location;
                    //thirdTran.NltCosting = sales.NLT_Costing;
                    //thirdTran.LineDiscount = (decimal?)linedisc;
                    //thirdTran.NltPacks = (decimal?)sales.NLT_Packs;




                    firstTran.NltLineNo = sales.NLT_LineNo;
                    firstTran.NltStockCode = sales.NLT_StockCode;
                    firstTran.NltDetail = sales.NLT_Detail;
                    firstTran.NltUnits = (decimal?)sales.NLT_Units;
                    firstTran.NltQty = -(decimal?)sales.NLT_Qty;
                    firstTran.NltPrice = (decimal?)sales.NLT_Price;
                    firstTran.NltNet = -(decimal?)sales.NLT_Net;
                    firstTran.NltVatCode = sales.NLT_VAT_Code;
                    firstTran.NltVat = -(decimal?)sales.NLT_VAT;
                    firstTran.NlCode = "Original Transaction";
                    firstTran.NltPaid = (decimal?)sales.NLT_Paid;
                    firstTran.NltRef = sales.NLT_Ref;
                    firstTran.NltSource = sales.NLT_Source;
                    firstTran.NltAudit = sales.NLT_Audit;
                    firstTran.NltCurrNet = -(decimal?)sales.NLT_CurrNet;
                    firstTran.NltCurrVat = -(decimal?)sales.NLT_CurrVAT;
                    firstTran.NltInvNo = sales.NLT_InvNo;
                    firstTran.NltLocation = sales.NLT_Location;
                    firstTran.NltYearEnd = sales.NLT_YearEnd;
                    firstTran.NltPeriod = sales.NLT_Period;
                    firstTran.NltCosting = sales.NLT_Costing;
                    firstTran.LineDiscount = (decimal?)linedisc;
                    firstTran.NltPacks = (decimal?)sales.NLT_Packs;




                    secTran.NltLineNo = sales.NLT_LineNo;
                    secTran.NltStockCode = sales.NLT_StockCode;
                    secTran.NltDetail = sales.NLT_Detail;
                    secTran.NltUnits = (decimal?)sales.NLT_Units;
                    secTran.NltQty = (decimal?)sales.NLT_Qty * -1;
                    secTran.NltPrice = (decimal?)sales.NLT_Price;
                    secTran.NltNet = (decimal?)(sales.NLT_Net + sales.NLT_VAT);
                    secTran.NltVatCode = sales.NLT_VAT_Code;
                    secTran.NltVat = (decimal?)sales.NLT_VAT;
                    secTran.NlCode = "DECTRL";
                    secTran.NltPaid = 0;
                    secTran.NltRef = sales.NLT_Ref;
                    secTran.NltSource = sales.NLT_Source;
                    secTran.NltAudit = sales.NLT_Audit;
                    secTran.NltCurrNet = (decimal?)(sales.NLT_CurrNet + sales.NLT_CurrVAT);
                    secTran.NltCurrVat = -(decimal?)sales.NLT_CurrVAT;
                    secTran.NltInvNo = sales.NLT_InvNo;
                    secTran.NltLocation = sales.NLT_Location;
                    secTran.NltYearEnd = sales.NLT_YearEnd;
                    secTran.NltPeriod = sales.NLT_Period;
                    secTran.NltCosting = sales.NLT_Costing;
                    secTran.LineDiscount = (decimal?)linedisc;
                    secTran.NltPacks = (decimal?)sales.NLT_Packs;


                    thirdTran.NltLineNo = sales.NLT_LineNo;
                    thirdTran.NltStockCode = sales.NLT_StockCode;
                    thirdTran.NltDetail = sales.NLT_Detail;
                    thirdTran.NltUnits = (decimal?)sales.NLT_Units;
                    thirdTran.NltQty = -(decimal?)sales.NLT_Qty;
                    thirdTran.NltPrice = (decimal?)sales.NLT_Price;
                    thirdTran.NltNet = -(decimal?)(sales.NLT_VAT);
                    thirdTran.NltVatCode = sales.NLT_VAT_Code;
                    thirdTran.NltVat = -(decimal?)sales.NLT_Net;
                    thirdTran.NlCode = "VATCRTL";
                    thirdTran.NltPaid = 0;
                    thirdTran.NltRef = sales.NLT_Ref;
                    thirdTran.NltSource = sales.NLT_Source;
                    thirdTran.NltAudit = sales.NLT_Audit;
                    thirdTran.NltCurrNet = -(decimal?)(sales.NLT_CurrNet);
                    thirdTran.NltCurrVat = -(decimal?)sales.NLT_CurrVAT;
                    thirdTran.NltInvNo = sales.NLT_InvNo;
                    thirdTran.NltLocation = sales.NLT_Location;
                    thirdTran.NltYearEnd = sales.NLT_YearEnd;
                    thirdTran.NltPeriod = sales.NLT_Period;
                    thirdTran.NltCosting = sales.NLT_Costing;
                    thirdTran.LineDiscount = (decimal?)linedisc;
                    thirdTran.NltPacks = (decimal?)sales.NLT_Packs;





                    // await _context.Nltrans.AddAsync(firstTran);
                    var transList = new Nltran[] { firstTran, secTran, thirdTran };

                    //await _context.Nltrans.AddAsync(firstTran);

                    //await _context.Nltrans.AddAsync(secTran);

                    //await _context.Nltrans.AddAsync(thirdTran);

                    //try
                    //{
                    //    await _context.SaveChangesAsync();
                    //}
                    //catch(Exception ex)
                    //{
                    //    throw ex;
                    //}

                    // UPDATE NLTRAN USING (NLT_Source = 'PI') AND (NLT_InvNo = @NLT_InvNo) AND (NLT_LineNo = @NLT_LineNo) AND (NL_Code = @VAT_Control) and nlt_ref=@NLT_Ref

                    //var transList = new Nltran[] { firstTran, secTran, thirdTran };
                    _context.Nltrans.UpdateRange(transList);
                    await _context.SaveChangesAsync();

                    Audit = Audit + "Line: " + line.ToString() + Environment.NewLine;
                    Audit = Audit + "Stock/Item: " + sales.NLT_StockCode + Environment.NewLine;
                    Audit = Audit + "Detail: " + detail.Replace("'", "").Replace("&", "") + Environment.NewLine;
                    Audit = Audit + "Qty: " + sales.NLT_Qty.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Location: " + sales.NLT_Location + Environment.NewLine;
                    Audit = Audit + "Pack Size: " + sales.NLT_Units + Environment.NewLine;
                    Audit = Audit + "Unit Price: " + sales.NLT_Price.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Net in Currency: " + net.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Vat in Currency: " + vat.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Net: " + sales.NLT_Net.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Vat: " + sales.NLT_VAT.ToString("N") + Environment.NewLine;
                    Audit = Audit + "Vat Code: " + sales.NLT_VAT_Code + Environment.NewLine;
                    Audit = Audit + "Date: " + invdate.ToShortDateString() + Environment.NewLine;
                    Audit = Audit + "Due Date: " + dDate.ToShortDateString() + Environment.NewLine;
                    Audit = Audit + "Settle Date: " + setdate.ToShortDateString() + Environment.NewLine;
                    Audit = Audit + "Currency: " + currency.ToString() + Environment.NewLine;
                    Audit = Audit + "Exch Rate: " + exchrate.ToString() + Environment.NewLine;
                    Audit = Audit + "Order: " + orderno.ToString() + Environment.NewLine;
                    Audit = Audit + "description: " + description.ToString() + Environment.NewLine;
                    Audit = Audit + "notes: " + notes.ToString() + Environment.NewLine;
                    if (costing.Trim() != "")
                    {
                        Audit = Audit + "Costing: " + costing + Environment.NewLine;
                    }
                    if (salesagent.Trim() != "")
                    {
                        Audit = Audit + "Sales Agent: " + salesagent + Environment.NewLine;
                    }






                    //update ntran where nlt_souurce='PI',NLT_InvNo=NLT_InvNo
                    //nlt_ref=NLT_Ref  for the invoice header props


                    var nlTrans = await _context.Nltrans.
                                                Where(x => x.NltSource == single.Source && x.NltInvNo == single.invNo && x.NltRef == single.Ref).
                                                ToArrayAsync();

                    float.TryParse(exchrate, out float exRate);
                    foreach (var tran in nlTrans)
                    {
                        tran.NltDate = invdate;
                        tran.NltCurrCode = currency;
                        tran.NltExchRate = exRate;
                        tran.NltDueDate = dDate;
                        tran.NltDeliverDate = setdate;
                        tran.NltNotes = notes;
                        tran.NltOrderNo = orderno;
                        tran.NltDelAdd = deliveryadd;
                        tran.Salesman = salesagent;
                        tran.NltTheirRef = invoiceref;
                        tran.NltContra = "";
                        tran.NltEnteredBy = enteredby;
                        tran.NltInvoiceRef = description;

                        _context.Nltrans.Update(tran);
                        await _context.SaveChangesAsync();

                    }

                    try
                    {


                        // assuming costingTypeID > 1
                        int costingTypeID = 3;
                        if (costingTypeID > 1)
                        {
                            var stkCosting = new StockCosting
                            {
                                CostingEntryDate = DateTime.Now,
                                CostingTypeId = 2,
                                CostingReference = sales.NLT_Audit,
                                StockItem = stock,
                                UnitCost = Convert.ToDecimal(price),
                                Qty = qty,
                                LocationCode = single.LocationCode

                            };

                            await _context.StockCostings.AddAsync(stkCosting);
                        }

                        var aud = new Audit
                        {
                            Date = DateTime.Now,
                            AuditRef = sales.NLT_Audit,
                            UserId = 1,
                            Action = "Insert",
                            Changes = Audit
                        };

                        await _context.Audits.AddAsync(aud);




                    }
                    catch
                    { }

                }


                // if the above action is not succesful ,return

                //else, save stock_costing and save audit
            }

            return Ok();
        }


        [HttpPost("SaveSI")]
        public async Task<ActionResult<Nltran>> SaveSI(List<SaleInput> data)
        {


            foreach (var single in data)
            {
                // get intPeriod using datDate,companyData
                string stock = single.stock;
                string detail = single.detail;
                double qty = 0;
                double.TryParse(single.quantity, out qty);
                double price = 0;
                double.TryParse(single.price, out price);
                double disc = 0;
                double.TryParse(single.disc, out disc);
                string vatcode = single.vatcode;
                double vat = 0;
                double.TryParse(single.vat, out vat);
                double net = price * qty;
                // double.TryParse(, out net);
                string nominal = single.nominal;
                string costing = single.costing;
                string location = single.location;
                double packsize = 0;
                double.TryParse(single.packsize, out packsize);
                double exchRate = 1;
                double.TryParse(single.exrate, out exchRate);
                double saleCostPrice = 0;
                double.TryParse(single.saleCostPrice, out saleCostPrice);
                //Costing Changes
                double currcost = 0;
                double.TryParse(single.currcost, out currcost);
                currcost = saleCostPrice.ToString() != "" ? (saleCostPrice * exchRate) : currcost;
                DateTime datYE = Convert.ToDateTime(DateTime.Now.AddYears(1));
                DateTime datDate = DateTime.Now;
                string Audit = "";
                int intPeriod = single.intPeriod;

                string InvNo = single.invNo;



                int line = 0;
                line += 1;
                Transactions sales = new Transactions();


                sales.DR_Control = single.DRControl;
                sales.VAT_Control = single.VATControl;
                sales.NLT_Audit = "SI/" + InvNo + "/" + line.ToString();
                sales.NLT_Costing = costing;
                sales.NLT_CurrNet = net;
                sales.NLT_CurrVAT = vat;
                sales.NLT_Detail = detail.Replace("'", "").Replace("&", "");
                sales.NLT_InvNo = InvNo;
                sales.NLT_LineNo = line;
                sales.NLT_Location = location;
                sales.NLT_Net = Math.Round(net / exchRate, 2);
                sales.NLT_VAT = Math.Round(vat / exchRate, 2);
                sales.NLT_VAT_Code = vatcode;
                sales.NLT_Period = intPeriod;
                sales.NLT_Price = price;
                sales.NLT_Qty = qty;
                sales.NLT_Packs = qty;
                //   sales.NLT_Ref = single.Ref;
                sales.NLT_Source = "SI";
                sales.NLT_StockCode = stock;
                sales.NLT_Units = packsize;
                sales.NLT_YearEnd = datYE;
                double linedisc = 0;
                double.TryParse(single.LineDiscount, out linedisc);
                sales.NL_Code = single.nominal;

                string invoicedate = DateTime.Now.ToString();
                DateTime invdate;
                DateTime.TryParse(invoicedate, out invdate);
                string ddate = DateTime.Now.ToString();
                DateTime dDate;
                DateTime.TryParse(ddate, out dDate);
                string settledate = DateTime.Now.AddDays(2).ToString();
                DateTime setdate;
                DateTime.TryParse(settledate, out setdate);
                string currency = "$";
                string exchrate = single.exrate;
                string orderno = single.orderNo;
                string deliveryadd = single.deliveryAdd;
                string invoiceref = single.invRef;
                string enteredby = single.enteredBy;
                string notes = single.notes;
                string description = single.description;
                string salesagent = single.salesAgent;




                // and is also PI transaction


                // creates a sales object 



                // create stockTracking using session values


                string stockTracking = "StockTracking";
                if (stockTracking == "StockTracking")
                {
                    bool chkIsSerial = true;
                    String TrackingNumber = single.TrackingNumber;
                    string TrackingEntryDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    TrackingNumber = TrackingNumber == "" ? stock + "/NoTracking" : TrackingNumber;

                    if (TrackingNumber != "")
                    {
                        var sTK = new StockTracking
                        {
                            TrackingEntryDate = Convert.ToDateTime(TrackingEntryDate),
                            IsSerial = chkIsSerial,
                            TrackingNo = TrackingNumber,
                            TrackingTypeId = single.TrackingTypeID,
                            TrackingReference = sales.NLT_Audit,
                            StockItem = stock,
                            Qty = qty,
                            LocationCode = single.LocationCode

                        };

                        await _context.StockTrackings.AddAsync(sTK);
                        int SID = await _context.SaveChangesAsync();

                        int UID = 0;

                        if (SID > 0)
                        {
                            if (TrackingNumber != stock + "/NoTracking")
                            {
                                if (chkIsSerial)
                                {
                                    var SN = await _context.SerialNumbers.Where(x => x.SerialNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                    SN.StatusId = 3;
                                    _context.SerialNumbers.Update(SN);
                                    await _context.SaveChangesAsync();
                                }

                                else
                                {
                                    var BN = await _context.BatchNumbers.Where(x => x.BatchNumber1 == TrackingNumber).SingleOrDefaultAsync();
                                    BN.StatusId = 3;
                                    _context.BatchNumbers.Update(BN);
                                    await _context.SaveChangesAsync();
                                }



                            }


                        }



                    }
                }



                // string 

                // create stockTracking object

                //trackingnumber is "0000+id"
                //trackingRef = purchases.NLT_Audit




                // save stock trading 

                // save nltran with 3 diifferent vat values


                var firstTran = new Nltran
                {
                    NltLineNo = sales.NLT_LineNo,
                    NltStockCode = sales.NLT_StockCode,
                    NltDetail = sales.NLT_Detail,
                    NltUnits = (decimal?)sales.NLT_Units,
                    NltQty = -(decimal?)sales.NLT_Qty,
                    NltPrice = (decimal?)sales.NLT_Price,
                    NltNet = -(decimal?)sales.NLT_Net,
                    NltVatCode = sales.NLT_VAT_Code,
                    NltVat = -(decimal?)sales.NLT_VAT,
                    NlCode = "Original Transaction",
                    NltPaid = (decimal?)sales.NLT_Paid,
                    NltRef = sales.NLT_Ref,
                    NltSource = sales.NLT_Source,
                    NltAudit = sales.NLT_Audit,
                    NltCurrNet = -(decimal?)sales.NLT_CurrNet,
                    NltCurrVat = -(decimal?)sales.NLT_CurrVAT,
                    NltInvNo = sales.NLT_InvNo,
                    NltLocation = sales.NLT_Location,
                    NltYearEnd = sales.NLT_YearEnd,
                    NltPeriod = sales.NLT_Period,
                    NltCosting = sales.NLT_Costing,
                    LineDiscount = (decimal?)linedisc,
                    NltPacks = (decimal?)sales.NLT_Packs
                };


                var secTran = new Nltran
                {
                    NltLineNo = sales.NLT_LineNo,
                    NltStockCode = sales.NLT_StockCode,
                    NltDetail = sales.NLT_Detail,
                    NltUnits = (decimal?)sales.NLT_Units,
                    NltQty = (decimal?)sales.NLT_Qty * -1,
                    NltPrice = (decimal?)sales.NLT_Price,
                    NltNet = (decimal?)(sales.NLT_Net + sales.NLT_VAT),
                    NltVatCode = sales.NLT_VAT_Code,
                    NltVat = (decimal?)sales.NLT_VAT,
                    NlCode = "DECTRL",
                    NltPaid = 0,
                    NltRef = sales.NLT_Ref,
                    NltSource = sales.NLT_Source,
                    NltAudit = sales.NLT_Audit,
                    NltCurrNet = (decimal?)(sales.NLT_CurrNet + sales.NLT_CurrVAT),
                    NltCurrVat = -(decimal?)sales.NLT_CurrVAT,
                    NltInvNo = sales.NLT_InvNo,
                    NltLocation = sales.NLT_Location,
                    NltYearEnd = sales.NLT_YearEnd,
                    NltPeriod = sales.NLT_Period,
                    NltCosting = sales.NLT_Costing,
                    LineDiscount = (decimal?)linedisc,
                    NltPacks = (decimal?)sales.NLT_Packs
                };
                var thirdTran = new Nltran
                {
                    NltLineNo = sales.NLT_LineNo,
                    NltStockCode = sales.NLT_StockCode,
                    NltDetail = sales.NLT_Detail,
                    NltUnits = (decimal?)sales.NLT_Units,
                    NltQty = -(decimal?)sales.NLT_Qty,
                    NltPrice = (decimal?)sales.NLT_Price,
                    NltNet = -(decimal?)(sales.NLT_VAT),
                    NltVatCode = sales.NLT_VAT_Code,
                    NltVat = -(decimal?)sales.NLT_Net,
                    NlCode = "VATCRTL",
                    NltPaid = 0,
                    NltRef = sales.NLT_Ref,
                    NltSource = sales.NLT_Source,
                    NltAudit = sales.NLT_Audit,
                    NltCurrNet = -(decimal?)(sales.NLT_CurrNet),
                    NltCurrVat = -(decimal?)sales.NLT_CurrVAT,
                    NltInvNo = sales.NLT_InvNo,
                    NltLocation = sales.NLT_Location,
                    NltYearEnd = sales.NLT_YearEnd,
                    NltPeriod = sales.NLT_Period,
                    NltCosting = sales.NLT_Costing,
                    LineDiscount = (decimal?)linedisc,
                    NltPacks = (decimal?)sales.NLT_Packs
                };


                // await _context.Nltrans.AddAsync(firstTran);
                var transList = new Nltran[] { firstTran, secTran, thirdTran };

                //await _context.Nltrans.AddAsync(firstTran);

                //await _context.Nltrans.AddAsync(secTran);

                //await _context.Nltrans.AddAsync(thirdTran);

                //try
                //{
                //    await _context.SaveChangesAsync();
                //}
                //catch(Exception ex)
                //{
                //    throw ex;
                //}


                //var transList = new Nltran[] { firstTran, secTran, thirdTran };
                await _context.Nltrans.AddRangeAsync(transList);
                await _context.SaveChangesAsync();

                Audit = Audit + "Line: " + line.ToString() + Environment.NewLine;
                Audit = Audit + "Stock/Item: " + sales.NLT_StockCode + Environment.NewLine;
                Audit = Audit + "Detail: " + detail.Replace("'", "").Replace("&", "") + Environment.NewLine;
                Audit = Audit + "Qty: " + sales.NLT_Qty.ToString("N") + Environment.NewLine;
                Audit = Audit + "Location: " + sales.NLT_Location + Environment.NewLine;
                Audit = Audit + "Pack Size: " + sales.NLT_Units + Environment.NewLine;
                Audit = Audit + "Unit Price: " + sales.NLT_Price.ToString("N") + Environment.NewLine;
                Audit = Audit + "Net in Currency: " + net.ToString("N") + Environment.NewLine;
                Audit = Audit + "Vat in Currency: " + vat.ToString("N") + Environment.NewLine;
                Audit = Audit + "Net: " + sales.NLT_Net.ToString("N") + Environment.NewLine;
                Audit = Audit + "Vat: " + sales.NLT_VAT.ToString("N") + Environment.NewLine;
                Audit = Audit + "Vat Code: " + sales.NLT_VAT_Code + Environment.NewLine;
                Audit = Audit + "Date: " + invdate.ToShortDateString() + Environment.NewLine;
                Audit = Audit + "Due Date: " + dDate.ToShortDateString() + Environment.NewLine;
                Audit = Audit + "Settle Date: " + setdate.ToShortDateString() + Environment.NewLine;
                Audit = Audit + "Currency: " + currency.ToString() + Environment.NewLine;
                Audit = Audit + "Exch Rate: " + exchrate.ToString() + Environment.NewLine;
                Audit = Audit + "Order: " + orderno.ToString() + Environment.NewLine;
                Audit = Audit + "description: " + description.ToString() + Environment.NewLine;
                Audit = Audit + "notes: " + notes.ToString() + Environment.NewLine;
                if (costing.Trim() != "")
                {
                    Audit = Audit + "Costing: " + costing + Environment.NewLine;
                }
                if (salesagent.Trim() != "")
                {
                    Audit = Audit + "Sales Agent: " + salesagent + Environment.NewLine;
                }






                //update ntran where nlt_souurce='PI',NLT_InvNo=NLT_InvNo
                //nlt_ref=NLT_Ref  for the invoice header props


                var nlTrans = await _context.Nltrans.
                                            Where(x => x.NltSource == single.Source && x.NltInvNo == single.invNo && x.NltRef == single.Ref).
                                            ToArrayAsync();

                float.TryParse(exchrate, out float exRate);
                foreach (var tran in nlTrans)
                {
                    tran.NltDate = invdate;
                    tran.NltCurrCode = currency;
                    tran.NltExchRate = exRate;
                    tran.NltDueDate = dDate;
                    tran.NltDeliverDate = setdate;
                    tran.NltNotes = notes;
                    tran.NltOrderNo = orderno;
                    tran.NltDelAdd = deliveryadd;
                    tran.Salesman = salesagent;
                    tran.NltTheirRef = invoiceref;
                    tran.NltContra = "";
                    tran.NltEnteredBy = enteredby;
                    tran.NltInvoiceRef = description;

                    _context.Nltrans.Update(tran);
                    await _context.SaveChangesAsync();

                }

                try
                {


                    // assuming costingTypeID > 1
                    int costingTypeID = 3;
                    if (costingTypeID > 1)
                    {
                        var stkCosting = new StockCosting
                        {
                            CostingEntryDate = DateTime.Now,
                            CostingTypeId = 2,
                            CostingReference = sales.NLT_Audit,
                            StockItem = stock,
                            UnitCost = Convert.ToDecimal(price),
                            Qty = qty,
                            LocationCode = single.LocationCode

                        };

                        await _context.StockCostings.AddAsync(stkCosting);
                    }

                    var aud = new Audit
                    {
                        Date = DateTime.Now,
                        AuditRef = sales.NLT_Audit,
                        UserId = 1,
                        Action = "Insert",
                        Changes = Audit
                    };

                    await _context.Audits.AddAsync(aud);




                }
                catch (Exception ex)
                {
                    throw ex;
                }

                // if the above action is not succesful ,return

                //else, save stock_costing and save audit
            }

            //_context.Nltrans.Add(nltran);
            //await _context.SaveChangesAsync();

            return Ok();
        }













        //public async void btnGet(PayInput data)
        //{
        //    var retValue = 0;

        //    foreach (var single in data.AllPayments)
        //    {
        //        double topay = 0;
        //        double exchrate = 1;
        //        double topaycurr = 0;

        //        double dbl6 = 0;
        //        double dbl7 = 0;
        //        double dbl8 = 0;
        //        double dbl9 = 0;
        //        double dbl11 = 0;
        //        double.TryParse(r.Cells[6].Text, out dbl6);
        //        double.TryParse(r.Cells[7].Text, out dbl7);
        //        double.TryParse(r.Cells[8].Text, out dbl8);
        //        double.TryParse(r.Cells[9].Text, out dbl9);
        //        double.TryParse(r.Cells[11].Text, out dbl11);

        //        double.TryParse(data.toPayCurrValue, out topaycurr);
        //        if (topaycurr != 0)
        //        {
        //            topay = topaycurr / exchrate;
        //        }
        //        else
        //        {
        //            topay = 0;
        //            dbl11Summ -= dbl11;
        //        }



        //        var topTrans = await _context.Nltrans.Take(1).Where(x => x.NltInvNo == single.invNo && x.NltSource == single.Source)
        //                                            .OrderBy(x => x.NltKey).SingleOrDefaultAsync();

        //        String topRecord = topTrans.NltKey.ToString();
        //        int topRec = 0;
        //        int.TryParse(topRecord, out topRec);

        //        var tran = await _context.Nltrans.Where(x => x.NltKey == topRec).SingleOrDefaultAsync();


        //        tran.NltToPay = Convert.ToDecimal(topay);
        //        tran.NltToPayCurr = Convert.ToDecimal(topaycurr);


        //        _context.Nltrans.Update(tran);
        //        retValue = await _context.SaveChangesAsync();

        //    }
        //    if (retValue > 0)
        //    {
        //        DateTime dFrom = DateTime.Today.AddDays(-(DateTime.Today.Day - 1));
        //        DateTime dto = DateTime.Today;
        //        DateTime.TryParse(data.dFrom.ToString(), out dFrom);
        //        DateTime.TryParse(data.toFrom.ToString(), out dto);
        //        string strQ = "SELECT SUM(ISNULL(NLT_ToPayCurr,0)) As ToPayCurr, SUM(ISNULL(NLT_ToPay,0)) As ToPay ";


        //        var transaction = await _context.Nltrans.Where(x => x.NltDate >= dFrom && x.NltDate <= dto
        //                                                        && x.NltRef == "" && x.NlCode == "").ToListAsync();

        //        string toPay = transaction.Sum(x => x.NltToPay ?? 0).ToString();
        //        string toPayCurr = transaction.Sum(x => x.NltToPayCurr ?? 0).ToString();


        //        double dblToPayCurr = 0;
        //        double dblToPay = 0;
        //        if (transaction.Count > 0)
        //        {
        //            double.TryParse(toPay, out dblToPayCurr);
        //            double.TryParse(toPayCurr, out dblToPay);
        //        }

        //        double existDisc = 0;
        //        double.TryParse(data.Discount, out existDisc);
        //        if (existDisc == 0)
        //        {

        //            data.Discount = Convert.ToDecimal("dbl11Summ").ToString();
        //        }
        //        else
        //        {
        //            data.Discount = Convert.ToDecimal("dbl11Summ").ToString();
        //            data.Discount = Math.Round((-existDisc - "dbl11Summ") + dbl11Summ, 2).ToString();
        //        }
        //        if (dblToPay == 0 && dblToPayCurr == 0)
        //        {
        //            txtDiscount.Enabled = false;
        //            txtDiscount.Text = "0";
        //        }
        //        else
        //        {
        //            txtDiscount.Enabled = true;
        //        }

        //    }

        //}

        //public async void bnCalculate(PayInput data)
        //{
        //    bnCalculate(data);
        //    Compute();
        //}

        //protected void Compute(double bankValue = 0)
        //{



        //    DateTime datePay = DateTime.Today;

        //    string defaultCurr = "£";

        //    lblnetCurr.Text = defaultCurr;
        //    lblbankcurr.Text = accountdb.GeneralQuery("SELECT isnull(BankAcct.CurrCode,'" + defaultCurr + "') FROM nominal RIGHT OUTER JOIN BankAcct ON nominal.NL_Code = BankAcct.ReceiptsControl where ReceiptsControl='" + ddBank.SelectedValue + "'");

        //    double dblOnAcct = 0; // cf.CNo(tbOnAcct.Text);
        //    double dblCurrOnAcct = 0; // cf.CNo(tbCurrOnAcct.Text);

        //    double dblRate = 0;
        //    if (accountdb.GVGet("ECBRate") != "True")
        //    {
        //        dblRate = Math.Round(accountdb.GetExchRate(lblbankcurr.Text.Trim(), datePay, "", defaultCurr), 4);
        //    }
        //    else
        //    {
        //        dblRate = Math.Round(accountdb.GetECBRates(lblbankcurr.Text.Trim(), datePay, "", defaultCurr), 4);
        //    }

        //    if (dblRate <= 0) { dblRate = 1; lblexchrate.Text = "1"; }
        //    lblexchrate.Text = dblRate.ToString();

        //    double dblAlloc = 0; double.TryParse(lblTotals.Text, out dblAlloc);
        //    double dblCurrAlloc = 0; dblCurrAlloc = Math.Round((dblRate * dblAlloc), 2);
        //    double dblrealCurrValue = 0; double.TryParse(lblCurTotals.Text, out dblrealCurrValue);
        //    if (lblnetCurr.Text.Trim() != lblbankcurr.Text.Trim())
        //    {
        //        double realdiff = dblrealCurrValue - dblCurrAlloc;
        //        if (realdiff < 0.5 && realdiff > 0)
        //        {
        //            dblCurrAlloc = dblrealCurrValue;
        //        }
        //        if (lblCurSel.Text.Trim() == lblbankcurr.Text.Trim())
        //        {
        //            dblCurrAlloc = dblrealCurrValue;
        //        }
        //    }
        //    double dblEV = 0;
        //    dblEV = (dblCurrAlloc / dblRate) - dblAlloc;
        //    double dblExchVar = 0.00;
        //    Double.TryParse(txtexchVar.Text, out dblExchVar);
        //    if (dblExchVar != 0 || dblEV != 0)
        //    {
        //        txtexchVar.Text = Math.Round(dblEV, 2).ToString();
        //        dblExchVar = dblEV;
        //    }

        //    double dblDisc = 0; double.TryParse(txtDiscount.Text, out dblDisc);
        //    double dblCurrDisc = 0; dblCurrDisc = Math.Round((dblRate * dblDisc), 2);

        //    double dblCIS = 0;// double.TryParse(txtCIS.Text, out dblCIS);
        //    double dblCurrCIS = 0; dblCurrCIS = Math.Round((dblRate * dblCIS), 2);

        //    double debitnote = 0; //double.TryParse(txtDebitNote.Text, out debitnote);
        //    double dblCurrdebitnote = 0; dblCurrdebitnote = Math.Round((dblRate * debitnote), 2);
        //    if (dblDisc < 0)
        //    {
        //        dblDisc = -dblDisc;
        //    }
        //    if (dblCurrDisc < 0)
        //    {
        //        dblCurrDisc = -dblCurrDisc;
        //    }
        //    double dblTotal = dblAlloc + dblOnAcct - (dblCIS + dblDisc + debitnote);
        //    double dblCurrTotal = dblCurrAlloc + dblCurrOnAcct - (dblCurrCIS + dblCurrDisc + dblCurrdebitnote);

        //    dblTotal = dblTotal + dblEV;

        //    lblTranValue.Text = Math.Round(dblTotal, 2).ToString();
        //    if (bankValue != 0 || isBankValueEdit)
        //    {

        //        txtexchVar.Text = Math.Round(dblCurrTotal - bankValue, 2).ToString();
        //        double exchR = AccountsDBMethods.CNo(lblexchrate.Text) == 0 ? 1 : AccountsDBMethods.CNo(lblexchrate.Text);
        //        txtexchVar.Text = Math.Round((bankValue / exchR) - dblTotal, 2).ToString();
        //        lblBankValue.Text = Math.Round(bankValue, 2).ToString();

        //        IF recalcualte echange rate is active
        //        double exchR = Math.Round(bankValue / dblTotal, 2);
        //        lblexchrate.Text = exchR.ToString();
        //        txtexchVar.Text = Math.Round(dblTotal - (bankValue / exchR), 2).ToString();

        //        isBankValueEdit = false;

        //    }
        //    else
        //    {
        //        lblBankValue.Text = Math.Round(dblCurrTotal, 2).ToString();
        //    }
        //}

        //public async Task<ActionResult> Pay(PayInput data)
        //{
        //    bnCalculate(data);

        //    protected void Compute(double bankValue = 0)
        //    {
        //        if (Session["CompanyData"] == null)
        //        {
        //            companyData = accountdb.AccCompanyData();
        //            Session["CompanyData"] = companyData;
        //        }
        //        else
        //        {
        //            companyData = (Business_Layer.Company.Company)Session["CompanyData"];
        //        }


        //        DateTime datePay = DateTime.Today;
        //        if (AccountsDBMethods.IsDate(txtPayDate.Text))
        //        {
        //            datePay = Convert.ToDateTime(txtPayDate.Text);
        //        }

        //        string defaultCurr = accountdb.DefaultCurr(companyData.CO_Ctry);
        //        if (string.IsNullOrEmpty(defaultCurr))
        //        { defaultCurr = "£"; }
        //        lblnetCurr.Text = defaultCurr;
        //        lblbankcurr.Text = accountdb.GeneralQuery("SELECT isnull(BankAcct.CurrCode,'" + defaultCurr + "') FROM nominal RIGHT OUTER JOIN BankAcct ON nominal.NL_Code = BankAcct.ReceiptsControl where ReceiptsControl='" + ddBank.SelectedValue + "'");

        //        double dblOnAcct = 0; // cf.CNo(tbOnAcct.Text);
        //        double dblCurrOnAcct = 0; // cf.CNo(tbCurrOnAcct.Text);

        //        double dblRate = 0;
        //        if (accountdb.GVGet("ECBRate") != "True")
        //        {
        //            dblRate = Math.Round(accountdb.GetExchRate(lblbankcurr.Text.Trim(), datePay, "", defaultCurr), 4);
        //        }
        //        else
        //        {
        //            dblRate = Math.Round(accountdb.GetECBRates(lblbankcurr.Text.Trim(), datePay, "", defaultCurr), 4);
        //        }

        //        if (dblRate <= 0) { dblRate = 1; lblexchrate.Text = "1"; }
        //        lblexchrate.Text = dblRate.ToString();

        //        double dblAlloc = 0; double.TryParse(lblTotals.Text, out dblAlloc);
        //        double dblCurrAlloc = 0; dblCurrAlloc = Math.Round((dblRate * dblAlloc), 2);
        //        double dblrealCurrValue = 0; double.TryParse(lblCurTotals.Text, out dblrealCurrValue);
        //        if (lblnetCurr.Text.Trim() != lblbankcurr.Text.Trim())
        //        {
        //            double realdiff = dblrealCurrValue - dblCurrAlloc;
        //            if (realdiff < 0.5 && realdiff > 0)
        //            {
        //                dblCurrAlloc = dblrealCurrValue;
        //            }
        //            if (lblCurSel.Text.Trim() == lblbankcurr.Text.Trim())
        //            {
        //                dblCurrAlloc = dblrealCurrValue;
        //            }
        //        }
        //        double dblEV = 0;
        //        dblEV = (dblCurrAlloc / dblRate) - dblAlloc;
        //        double dblExchVar = 0.00;
        //        Double.TryParse(txtexchVar.Text, out dblExchVar);
        //        if (dblExchVar != 0 || dblEV != 0)
        //        {
        //            txtexchVar.Text = Math.Round(dblEV, 2).ToString();
        //            dblExchVar = dblEV;
        //        }

        //        double dblDisc = 0; double.TryParse(txtDiscount.Text, out dblDisc);
        //        double dblCurrDisc = 0; dblCurrDisc = Math.Round((dblRate * dblDisc), 2);

        //        double dblCIS = 0;// double.TryParse(txtCIS.Text, out dblCIS);
        //        double dblCurrCIS = 0; dblCurrCIS = Math.Round((dblRate * dblCIS), 2);

        //        double debitnote = 0; //double.TryParse(txtDebitNote.Text, out debitnote);
        //        double dblCurrdebitnote = 0; dblCurrdebitnote = Math.Round((dblRate * debitnote), 2);
        //        if (dblDisc < 0)
        //        {
        //            dblDisc = -dblDisc;
        //        }
        //        if (dblCurrDisc < 0)
        //        {
        //            dblCurrDisc = -dblCurrDisc;
        //        }
        //        double dblTotal = dblAlloc + dblOnAcct - (dblCIS + dblDisc + debitnote);
        //        double dblCurrTotal = dblCurrAlloc + dblCurrOnAcct - (dblCurrCIS + dblCurrDisc + dblCurrdebitnote);

        //        dblTotal = dblTotal + dblEV;

        //        lblTranValue.Text = Math.Round(dblTotal, 2).ToString();
        //        if (bankValue != 0 || isBankValueEdit)
        //        {

        //            txtexchVar.Text = Math.Round(dblCurrTotal - bankValue, 2).ToString();
        //            double exchR = AccountsDBMethods.CNo(lblexchrate.Text) == 0 ? 1 : AccountsDBMethods.CNo(lblexchrate.Text);
        //            txtexchVar.Text = Math.Round((bankValue / exchR) - dblTotal, 2).ToString();
        //            lblBankValue.Text = Math.Round(bankValue, 2).ToString();

        //            IF recalcualte echange rate is active
        //            double exchR = Math.Round(bankValue / dblTotal, 2);
        //            lblexchrate.Text = exchR.ToString();
        //            txtexchVar.Text = Math.Round(dblTotal - (bankValue / exchR), 2).ToString();

        //            isBankValueEdit = false;

        //        }
        //        else
        //        {
        //            lblBankValue.Text = Math.Round(dblCurrTotal, 2).ToString();
        //        }
        //    }


        //}
    }
}