<%@ Page Title="" Language="C#" MasterPageFile="~/View/FeesMaster/FeesMaster.Master" AutoEventWireup="true" CodeBehind="PayInstal.aspx.cs" Inherits="Fees_Management.View.FeesMaster.PayInstal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css' media="screen" />

    <style type="text/css">
        /* *{
            margin:0;
            padding:0;
            box-sizing:border-box;
            font-family:'Segoe UI',Tahoma,Verdana, Geneva, Tahoma, sans-serif,
        }
        body{
            color:#fff;
            display:flex;
            height:100vh;
            justify-content:center;
            align-items:center;
            background:linear-gradient(135deg,#05073a,#dc0606ca);
            padding:10px;
        }*/
        .container {
            /* max-width: 800px;*/
            height: 80vh;
            width: 100%;
            padding: 25px 30px;
            /* border-radius: 25px;*/
            /* background:linear-gradient(135deg,#dc0606ca,#05073a);*/
            /* background: linear-gradient(#d09a8d,#fdbb2d);*/
        }

            .container .header {
                font-size: 25px;
                font-weight: 500;
                position: relative;
                text-align: center;
                padding: 0 0 20px 0;
            }

                .container .header::before {
                    content: '';
                    position: absolute;
                    height: 3px;
                    left: 0;
                    bottom: 0;
                    width: 100%;
                    background: linear-gradient(135deg,#71b7e6,#9b5b);
                }

            .container .card-details {
                margin-top: 25px;
                display: flex;
                flex-wrap: wrap;
                justify-content: space-between;
            }

        .card-details .card-box {
            width: 300px;
            margin-bottom: 15px;
        }

            .card-details .card-box .details {
                display: block;
                font-weight: 500;
                margin-bottom: 5px;
            }

            .card-details .card-box .txt {
                height: 40px;
                width: 100%;
                outline: none;
                border-radius: 5px;
                border: 1px solid #ccc;
                padding-left: 15px;
                font-size: 16px;
                border-bottom-width: 2px;
                transition: all 0.3s ease;
            }

            .card-details .card-box txt:focus, .card-details .card-box txt:valid {
                border-color: #9b59b6;
            }

        .circle-form .circle-title {
            font-size: 20px;
            font-weight: 500;
            border-bottom: 2px solid;
        }

        .circle-form .catagiry {
            margin-top: 10px;
            margin-bottom: 10px;
        }

        .button {
            text-align: center;
            height: 35px;
        }

            .button .btn {
                padding: 10px 0;
                margin-top: 10px;
                width: 50%;
                outline: none;
                color: white;
                border: none;
                font-size: 18px;
                font-weight: 500;
                border-radius: 5px;
                letter-spacing: 1px;
                /* background:linear-gradient(135deg,#05073a,#dc0606ca);*/
                background: green;
            }

                .button .btn:hover {
                    /* background:linear-gradient(135deg,#05073a,#dc0606ca);*/
                }

        @media(max-width:584px) {
            .container {
                max-width: 100%;
            }

            form .card-details .card-box {
                margin-bottom: 15px;
                width: 100%;
            }

            form .circle-form .catagiry {
                width: 100%;
            }

            .container form .card-details {
                max-height: 300px;
                overflow: scroll;
            }
            /*.card-details::_webkit-scrollbar{
                     width:0;
                 }*/
        }

        .rdbb {
            margin-right: 50px;
        }

        .dd1 {
            width: 300px;
            height: 40px;
            border-radius: 5px;
            outline: none;
        }

        h2 {
            border-bottom: 2px solid pink;
            width: fit-content;
            color: #086922;
        }
        /*.hov{
            height:5px;
            width:20%;
            transition: width 2s, height 4s;
             background: linear-gradient(to right, red , yellow);
        }
         .hov:hover{
             height:40px;
             width:100%;
         }*/
         .grd{
              background:linear-gradient(rgb(188, 12, 241), rgb(212, 4, 4));          
         }
    </style>
    <script type="text/javascript" language="javascript">
        function numeric(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && ((charCode >= 48 && charCode <= 57) || charCode == 46))
                return true;
            else {
                alert('Please Enter Numeric values.');
                return false;
            }
        }
    </script>

    <script type="text/javascript">      
        function ShowPopup(Id, Name, Email, Joining_Date, GroupName, CourseYear, Fees, Installments, First_Installment, Balence, Second_Installment, Third_Installment) {
           

            var options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
            var today = new Date();

            let ltd = document.getElementById("ltd").textContent = today.toLocaleDateString("en-US", options);
            let id = document.getElementById("id").textContent = Id;
            let name = document.getElementById("name").textContent = Name;
            let email = document.getElementById("email").textContent = Email;
            let joiningDate = document.getElementById("joiningDate").textContent = Joining_Date;
            let groupName = document.getElementById("groupName").textContent = GroupName;
            let courseYear = document.getElementById("courseYear").textContent = CourseYear;
            let fees = document.getElementById("fees").textContent = Fees;
            let installment = document.getElementById("installment").textContent = Installments;
            let firstInstallment = document.getElementById("firstInstallment").textContent = First_Installment;
            let balence = document.getElementById("balence").textContent = Balence;
            let secondInstallment = document.getElementById("secondInstallment").textContent = Second_Installment;
            let thirdInstallment = document.getElementById("thirdInstallment").textContent = Third_Installment;

            $("#MyPopup").modal("show");          
            console.log(ltd);
            console.log(name);
        }
        function PrintPanel() {
            var PGrid = document.getElementById('<%=Panel1.ClientID %>');

            PGrid.border = 0;

            var Pwin = window.open('', 'PrintGrid', 'left=100,top=100,width=1024,height=768,tollbar=0,scrollbars=1,status=0,resizable=1');

            Pwin.document.write(PGrid.outerHTML);

            Pwin.document.close();

            Pwin.focus();

            Pwin.print();

            Pwin.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="main-content">
        <section class="wrapper site-min-height">
            <div class="container">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <h2>Pay Installments</h2>
                <div class="card-details">
                    <div class="card-box">
                        <asp:Label ID="Label1" runat="server" Text="Register Id" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"><asp:TextBox ID="txtid" runat="server" CssClass="txt hov" OnTextChanged="txtid_TextChanged" AutoPostBack="true" onkeypress="return numeric(event)" placeholder="Enter Register Id.."></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label2" runat="server" Text="Name:" ForeColor="Blue"></asp:Label>
                         <h6 class="grd"><asp:TextBox ID="txtname" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label3" runat="server" Text="Email" ForeColor="Blue"></asp:Label>
                        <h6 class="grd"> <asp:TextBox ID="txtemail" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label4" runat="server" Text="Joining Date" ForeColor="Blue"></asp:Label>
                        <h6 class="grd">  <asp:TextBox ID="txtjoin" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label5" runat="server" Text="Group Name" ForeColor="Blue"></asp:Label>
                        <h6 class="grd">  <asp:TextBox ID="txtgroup" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label11" runat="server" Text="Course Year" ForeColor="Blue"></asp:Label>
                        <h6 class="grd">  <asp:TextBox ID="txtcourseyear" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label6" runat="server" Text="Fees" ForeColor="Blue"></asp:Label>
                        <h6 class="grd">  <asp:TextBox ID="txtfees" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label7" runat="server" Text="Installments" ForeColor="Blue"></asp:Label>
                       <h6 class="grd">   <asp:TextBox ID="txtinstalments" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label8" runat="server" Text="First Installment" ForeColor="Blue"></asp:Label>
                        <h6 class="grd">  <asp:TextBox ID="txtfirst" runat="server" CssClass="txt hov" AutoPostBack="true" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label9" runat="server" Text="Balance" ForeColor="Blue"></asp:Label>
                        <h6 class="grd">  <asp:TextBox ID="txtbalence" runat="server" CssClass="txt hov" ReadOnly="true"></asp:TextBox></h6>
                    </div>
                    <div class="card-box">
                        <asp:Label ID="Label10" runat="server" Text="Second Installment" ForeColor="Blue"></asp:Label>
                       <h6 class="grd">   <asp:TextBox ID="txtsecond" runat="server" CssClass="txt hov" onkeypress="return numeric(event)"></asp:TextBox></h6>
                    </div>                  
                    <div class="card-box">
                        <asp:Label ID="lblthird" runat="server" Text="Third Installment" ForeColor="Blue"></asp:Label>
                        <h6 class="grd">  <asp:TextBox ID="txtthird" runat="server" CssClass="txt hov" onkeypress="return numeric(event)"></asp:TextBox></h6>
                    </div>
                </div>
                <div class="button">
                    <asp:Button ID="btnpayinstallments" runat="server" Text="Pay Amount" CssClass="btn" ForeColor="#003366" OnClick="btnpayinstallments_Click" OnClientClick="return ShowPop" />
                </div>
            </div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            
   <div id="MyPopup" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">
                    &times;</button>
                <h4 class="modal-title">
                </h4>
            </div>
             <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1">
            <div class="modal-body">
                <label id="ltd"></label>
              <table class="auto-style1" border="1" align="center" id="tbl1">
                  <tr>
                        <td colspan="2" align="center"><h3 style="color:red;"><b>Visya Jyothi School</b></h3></td> 
                     
                    </tr>
                    <tr>
                        <td>Id</td>                      
                        <td> <lable id ="id"></lable></td>
                       
                       
                    </tr>
                     <tr>
                        <td>Name:</td>                       
                        <td><lable id ="name"></lable></td>
                    </tr>
                   <tr>
                        <td>Email:</td>                      
                        <td><lable id ="email"></lable></td>
                    </tr>
                     <tr>
                        <td>Joining Date:</td>                       
                        <td> <lable id ="joiningDate"></lable></td>
                    </tr>
                   <tr>
                        <td>Group Name:</td>                      
                        <td><lable id ="groupName"></lable></td>
                    </tr>
                     <tr>
                        <td>Course Year:</td>                       
                        <td><lable id ="courseYear"></lable></td>
                    </tr>
                   <tr>
                        <td>Fees:</td>                      
                        <td> <lable id ="fees"></lable></td>
                    </tr>
                     <tr>
                        <td>Installment:</td>                       
                        <td> <lable id ="installment"></lable></td>
                    </tr>
                   <tr>
                        <td>First Installment:</td>                      
                        <td> <lable id ="firstInstallment"></lable></td>
                    </tr>
                     <tr>
                        <td>Balance</td>                       
                        <td>  <lable id ="balence"></lable></td>
                    </tr>
                   <tr>
                        <td>Second Installment:</td>                      
                        <td> <lable id ="secondInstallment"></lable></td>
                    </tr>
                     <tr>
                        <td>Third Installment:</td>                       
                        <td>  <lable id ="thirdInstallment"></td>
                    </tr>
                </table>
            </div>
                  </asp:Panel>
            <div class="modal-footer">
                <asp:Button ID="btnprint" runat="server" Text="Print" ForeColor="white" OnClick="btnprint_Click" OnClientClick="return PrintPanel()" BackColor="Red" />               
            </div>
        </div>
    </div>
</div>
                
        </section>
    </section>
</asp:Content>
