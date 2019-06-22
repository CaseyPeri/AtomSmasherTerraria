using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AtomSmasher.Items
{
	public class AtomSmasherMK4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Atom Smasher MKIV");
			Tooltip.SetDefault("'A legendary weapon forged from the heart of a dying star'");
		}
		public override void SetDefaults()
		{
			item.width = 75;
			item.height = 22;
			item.value = Item.buyPrice(2,20,0,0);
			item.rare = 10;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 4;
			//item.useTurn = true;
			item.autoReuse = true;
			item.mana = 20;

			item.magic = true;

			item.damage = 48;
			item.crit = 0;
			item.knockBack = 4f;
			item.UseSound = SoundID.Item33;
			//item.UseSound = 11;

			//item.shoot = ProjectileID.HellfireArrow;
			item.shoot = mod.ProjectileType("LaserProjectile");

			item.noMelee = true;
			//item.noUseGraphic = true;
			item.channel = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AtomSmasherMK3", 1);
			recipe.AddIngredient(ItemID.LunarBar, 24);
			recipe.AddIngredient(ItemID.FragmentSolar, 30);
			recipe.AddIngredient(ItemID.FragmentVortex, 30);
			recipe.AddIngredient(ItemID.FragmentNebula, 30);
			recipe.AddIngredient(ItemID.FragmentStardust, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-30, -2);
		}

		/* public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		} */
	}
}
