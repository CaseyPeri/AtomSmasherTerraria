using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AtomSmasher.Items
{
	public class AtomSmasherMK1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Atom Smasher MKI");
			Tooltip.SetDefault("'A high power matter vaporizer'");
		}
		public override void SetDefaults()
		{
			item.width = 75;
			item.height = 22;
			item.value = Item.buyPrice(0,35,0,0);
			item.rare = 3;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 4;
			//item.useTurn = true;
			item.autoReuse = true;
			item.mana = 14;

			item.magic = true;

			item.damage = 4;
			item.crit = 0;
			item.knockBack = 1f;
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
			recipe.AddIngredient(ItemID.Diamond, 8);
			recipe.AddIngredient(ItemID.Wire, 24);
			recipe.AddIngredient(ItemID.MeteoriteBar, 18);
			recipe.AddIngredient(ItemID.HellstoneBar, 6);
			recipe.AddIngredient(ItemID.Lens, 3);
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
