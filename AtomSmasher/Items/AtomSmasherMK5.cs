using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AtomSmasher.Items
{
	public class AtomSmasherMK5 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Atom Smasher MKV");
			Tooltip.SetDefault("'And you thought the prism was OP'");
		}
		public override void SetDefaults()
		{
			item.width = 75;
			item.height = 22;
			item.value = Item.buyPrice(6,0,0,0);
			item.rare = 11;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 4;
			//item.useTurn = true;
			item.autoReuse = true;
			item.mana = 24;

			item.magic = true;

			item.damage = 100;
			item.crit = 26;
			item.knockBack = 16f;
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
			recipe.AddIngredient(null, "AtomSmasherMK1", 1);
			recipe.AddIngredient(null, "AtomSmasherMK2", 1);
			recipe.AddIngredient(null, "AtomSmasherMK3", 1);
			recipe.AddIngredient(null, "AtomSmasherMK4", 1);
			recipe.AddIngredient(ItemID.LastPrism, 1);
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
