// --------------------------------------------------------------------------------
// Copyright AspDotNetStorefront.com. All Rights Reserved.
// http://www.aspdotnetstorefront.com
// For details on this license please visit the product homepage at the URL above.
// THE ABOVE NOTICE MUST REMAIN INTACT. 
// --------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using AspDotNetStorefrontCore;

namespace AspDotNetStorefrontAdmin.Controls
{
	public partial class Admin_controls_editkitgrouptemplate : System.Web.UI.UserControl
	{
		private KitGroupData m_kitgroup;
		private List<KitGroupType> m_grouptypes;

		public KitGroupData KitGroup
		{
			get { return m_kitgroup; }
			set { m_kitgroup = value; }
		}

		public List<KitGroupType> GroupTypes
		{
			get { return m_grouptypes; }
			set { m_grouptypes = value; }
		}

		private Action<TextBox, ModalPopupExtender> m_registervarianttextcontrolandextenderroutine;
		public Action<TextBox, ModalPopupExtender> RegisterVariantTextControlAndExtenderRoutine
		{
			get { return m_registervarianttextcontrolandextenderroutine; }
			set { m_registervarianttextcontrolandextenderroutine = value; }
		}

		protected string GenerateManageImagesLink()
		{
			return string.Format("javascript:window.open('./kitgroupimageupload.aspx?kitid={0}&groupid={1}', 'manageimages', 'scrollbars=1;width:800;status=0;toolbar=0;location=0;'); javascript:void(0);", KitGroup.Kit.Id, KitGroup.Id);
		}

		protected override void OnPreRender(EventArgs e)
		{
			ResolveDefaultSelectionControl();

			base.OnPreRender(e);
		}

		private void ResolveDefaultSelectionControl()
		{
			var lstItem = cboGroupType.Items.FindByValue(KitGroup.SelectionControl.ToString());
			if(lstItem != null)
			{
				lstItem.Selected = true;
			}
		}

		public void ReconcileChanges()
		{
			ReconcileGroupChanges();
			ReconcileKitItemChanges();
		}

		private void ReconcileGroupChanges()
		{
			KitGroup.Name = txtGroupName.Text;
			KitGroup.Description = txtGroupDescription.Text;
			KitGroup.Summary = txtGroupSummary.Text;
			KitGroup.DisplayOrder = txtDisplayOrder.Text.ToNativeInt();
			KitGroup.IsRequired = chkRequired.Checked;
			KitGroup.IsReadOnly = chkReadOnly.Checked;

			var lstItem = cboGroupType.SelectedItem;
			if(lstItem != null)
			{
				KitGroup.SelectionControl = lstItem.Value.ToNativeInt();
			}
		}

		private void ReconcileKitItemChanges()
		{
			ExtractEditTemplate(dlItemsGeneralGroup, ReconcileGeneralGroupChanges);
			ExtractEditTemplate(dltemsInventoryVariantGroup, ReconcileInventoryGroupChanges);
			ExtractEditTemplate(dlItemsPricingGroup, ReconcilePricingGroupChanges);
		}

		private void ExtractEditTemplate(DataList ctrlList, Action<DataListItem, KitItemData> extractAndReconcileRoutine)
		{
			foreach(DataListItem item in ctrlList.Items)
			{
				if(item.ItemType == ListItemType.Item ||
					item.ItemType == ListItemType.AlternatingItem)
				{
					var hdfKitItemId = item.FindControl<HiddenField>("hdfKitItemId");
					if(hdfKitItemId != null)
					{
						int id = hdfKitItemId.Value.ToNativeInt();
						// find the associated kit item
						KitItemData kitItem = KitGroup.GetItem(id);

						if(kitItem != null)
						{
							// determine if this is a new one                            
							extractAndReconcileRoutine(item, kitItem);
						}
					}
				}
			}
		}

		private void ReconcileGeneralGroupChanges(DataListItem container, KitItemData kitItem)
		{
			TextBox txtKitItemDisplayOrder = container.FindControl<TextBox>("txtKitItemDisplayOrder");
			TextBox txtKitItemName = container.FindControl<TextBox>("txtKitItemName");
			TextBox txtKitItemDescription = container.FindControl<TextBox>("txtKitItemDescription");
			CheckBox chkKitItemDefault = container.FindControl<CheckBox>("chkKitItemDefault");

			kitItem.Name = txtKitItemName.Text;
			kitItem.Description = txtKitItemDescription.Text;
			kitItem.DisplayOrder = txtKitItemDisplayOrder.Text.ToNativeInt();
			kitItem.IsDefault = chkKitItemDefault.Checked;
		}

		private void ReconcileInventoryGroupChanges(DataListItem container, KitItemData kitItem)
		{
			var txtInventoryVariantId = container.FindControl<TextBox>("txtInventoryVariantId");
			var txtInventoryQuantityDelta = container.FindControl<TextBox>("txtInventoryQuantityDelta");
			var txtInventoryVariantColor = container.FindControl<TextBox>("txtInventoryVariantColor");
			var txtInventoryVariantSize = container.FindControl<TextBox>("txtInventoryVariantSize");

			var variantId = txtInventoryVariantId.Text.ToNativeInt();
			if(variantId == 0)
			{
				//Nothing was entered for the variantId so it doesn't make sense to save any of the other values that might have been entered.
				//Clear everything out in case they're de-coupling this item from a variant that had been saved previously

				kitItem.InventoryVariantId = 0;
				kitItem.InventoryQuantityDelta = 0;
				kitItem.InventoryVariantColor = string.Empty;
				kitItem.InventoryVariantSize = string.Empty;
				return;
			}

			var variant = new ProductVariant(variantId);
			if(variant.CreatedOn == DateTime.MinValue)
				return; //The variant doesn't exist, so don't save anything

			var color = txtInventoryVariantColor.Text;
			if(!variant.Colors.ContainsIgnoreCase(color))
				color = string.Empty;   //This isn't a valid color for this variant

			var size = txtInventoryVariantSize.Text;
			if(!variant.Sizes.ContainsIgnoreCase(size))
				size = string.Empty;   //This isn't a valid size for this variant

			kitItem.InventoryVariantId = variantId;
			kitItem.InventoryQuantityDelta = txtInventoryQuantityDelta.Text.ToNativeInt();
			kitItem.InventoryVariantColor = color;
			kitItem.InventoryVariantSize = size;
		}

		private void ReconcilePricingGroupChanges(DataListItem container, KitItemData kitItem)
		{
			TextBox txtPriceDelta = container.FindControl<TextBox>("txtPriceDelta");
			TextBox txtWeightDelta = container.FindControl<TextBox>("txtWeightDelta");

			kitItem.PriceDelta = txtPriceDelta.Text.ToNativeDecimal();
			kitItem.WeightDelta = txtWeightDelta.Text.ToNativeDecimal();
		}

		protected string DetermineDisplayId(int id)
		{
			if(id > 0)
			{
				return id.ToString();
			}
			else
			{
				return "[New]";
			}
		}

		protected void dlItemsGeneralGroup_ItemCreated(object sender, DataListItemEventArgs e)
		{
			if(e.Item.ItemType == ListItemType.Item ||
			   e.Item.ItemType == ListItemType.AlternatingItem)
			{
				string confirmDeleteScript = "return confirm('Are you sure you want to delete this kit item?');";

				LinkButton cmdDeleteItem = e.Item.FindControl<LinkButton>("cmdDeleteItem");
				cmdDeleteItem.Text = String.Format("<i class=\"fa fa-times\"></i> {0}", AppLogic.GetString("admin.common.delete", Context.GetCustomer().LocaleSetting));
				cmdDeleteItem.Attributes["onclick"] = confirmDeleteScript;
			}
		}

		protected void dltemsInventoryVariantGroup_ItemDataBound(object sender, DataListItemEventArgs e)
		{
		}

		protected void dlItemsGeneralGroup_ItemCommand(object sender, DataListCommandEventArgs e)
		{
			// Allow the container Datalist to consume this event
			// via it's ItemCommand event
			RaiseBubbleEvent(this, e);
		}

		public override void RenderControl(HtmlTextWriter writer)
		{
			StringBuilder script = new StringBuilder();
			script.Append("<script type=\"text/javascript\" language=\"Javascript\">\n");
			script.Append("    Sys.Application.add_load(function() {\n");

			Func<DataListItem, string, string> extractClientId = (item, controlName) =>
			{
				return item.FindControl(controlName).ClientID;
			};

			for(int ctr = 0; ctr < this.KitGroup.Items.Count; ctr++)
			{
				KitItemData kitItem = this.KitGroup.Items[ctr];
				string txtNameClientId = extractClientId(dlItemsGeneralGroup.Items[ctr], "txtKitItemName");
				string txtDescriptionClientId = extractClientId(dlItemsGeneralGroup.Items[ctr], "txtKitItemDescription");

				string lnkSelectClientId = extractClientId(dltemsInventoryVariantGroup.Items[ctr], "lnkSelect");
				string txtVariantIdClientId = extractClientId(dltemsInventoryVariantGroup.Items[ctr], "txtInventoryVariantId");

				string txtPriceClientId = extractClientId(dlItemsPricingGroup.Items[ctr], "txtPriceDelta");
				string txtWeightClientId = extractClientId(dlItemsPricingGroup.Items[ctr], "txtWeightDelta");

				script.AppendFormat("aspdnsf.Pages.EditKit.addKitItemLineControl( new aspdnsf.Controls.KitItemLineControl('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}') );\n",
					kitItem.Id,
					lnkSelectClientId,
					txtNameClientId,
					txtDescriptionClientId,
					txtVariantIdClientId,
					txtPriceClientId,
					txtWeightClientId);
			}

			script.Append("    });\n");

			script.Append("</script>\n");

			ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), script.ToString(), false);

			base.RenderControl(writer);
		}

		protected string ShowDeleteHeader()
		{
			string text = "Delete";
			if(KitGroup.NonNewItems.Count() == 0)
			{
				text = string.Empty;
			}

			return text;
		}
	}
}
