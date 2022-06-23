$('#FilterButton').click(function () {
    var FilterObj = { "ContractNumber": "", "CreateBy": "", "DeptName": "", "PartnerName": "", "FromDate": "", "ToDate": "", "TypeContract": "" };
    var DeptNameFilter = $('#sbDeptName option:selected').val();
    var CreateByFilter = $('#sbCreateBy option:selected').val();
    var ContractNumFilter = $('#txtContractNumber').val();
    var PartnerName = $('#txtPartnerName').val();
    var FromDate = $('#txtFromdate').val();
    var ToDate = $('#txtTodate').val();
    var TypeContract = $('#sbContractType option:selected').val();



    if (DeptNameFilter != "" && DeptNameFilter != "0" && DeptNameFilter != null) {
        FilterObj.DeptName = DeptNameFilter;
    }
    if (CreateByFilter != "" && CreateByFilter != "0" && CreateByFilter != null) {
        FilterObj.CreateBy = CreateByFilter;
    }
    if (ContractNumFilter != "" && ContractNumFilter != "0" && ContractNumFilter != null) {
        FilterObj.ContractNumber = ContractNumFilter;
    }
    if (PartnerName != "" && PartnerName != "0" && PartnerName != null) {

        FilterObj.PartnerName = locdau(PartnerName);
    }
    if (FromDate != "" && FromDate != "0" && FromDate != null) {
        FilterObj.FromDate = FromDate;
    }
    if (ToDate != "" && ToDate != "0" && ToDate != null) {
        FilterObj.ToDate = ToDate;
    }
    if (TypeContract != "" && TypeContract != "0" && TypeContract != null) {
        FilterObj.TypeContract = TypeContract;
    }
    $.ajax({
        url: "/Contract/Index",
        datatype: "json",
        type: "POST",
        data: {
            dept: FilterObj.DeptName,
            filterObj: FilterObj
        },

        async: true,
        success: function (result) {
            $("#gridview").html(result);
        }
    })
})
