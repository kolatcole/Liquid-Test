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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nltran>>> GetNltrans()
        {
            return await _context.Nltrans.Take<Nltran>(10).ToArrayAsync();
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

        // POST: api/Nltrans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nltran>> PostNltran(List<InputData> data)
        {

            // if any of the date is invalid return data not valid
            //public int SaveChanges()
            //{
            //    return _context.SaveChanges();
            //}



            // if id already exist in the databse, update else add

            //if (false)
            //{

            //}

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


        [HttpPost("Update")]
        public async Task<ActionResult<Nltran>> UpdateNltran(List<InputData> data)
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

                var lineno =  _context.Nltrans.Where(x => x.NltInvNo == InvNo).Select(x => x.NltLineNo).FirstOrDefault().ToString();

                int.TryParse(lineno,out line);

                if(line>0)
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


                    var firstTran = await _context.Nltrans.Where(x=>x.NltSource==purchases.NLT_Source && x.NltInvNo==InvNo && 
                                                                x.NltLineNo==purchases.NLT_LineNo && x.NlCode == "Original Transaction").SingleOrDefaultAsync();

                    var secTran = await _context.Nltrans.Where(x => x.NltSource == purchases.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == purchases.NLT_LineNo && x.NlCode == "DECTRL").SingleOrDefaultAsync();

                    var thirdTran = await _context.Nltrans.Where(x => x.NltSource == purchases.NLT_Source && x.NltInvNo == InvNo &&
                                                                x.NltLineNo == purchases.NLT_LineNo && x.NlCode== "VATCRTL").SingleOrDefaultAsync();

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
                    secTran.NltCurrNet = (decimal?)(-purchases.NLT_CurrNet-purchases.NLT_CurrVAT);
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
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }


                // if the above action is not succesful ,return

                //else, save stock_costing and save audit
            }

            return Ok();
        }

        //// DELETE: api/Nltrans/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteNltran(long id)
        //{
        //    var nltran = await _context.Nltrans.FindAsync(id);
        //    if (nltran == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Nltrans.Remove(nltran);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool NltranExists(long id)
        //{
        //    return _context.Nltrans.Any(e => e.NltKey == id);
        //}
    }
}
