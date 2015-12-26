<!DOCTYPE html>
<html lnag='ja'>
<head>
<metacharset="UTF-8"/>
<title></title>

<link rel="stylesheet" href="<?php echo get_stylesheet_uri();?>">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">


</head>
<body <?php body_class(); ?>>
<?php if(have_posts()): while(have_posts()): the_post();?>
 
	<article <?php post_class(); ?>>

		<h1><?php the_title(); ?></h1>

		<div class='postinfo'>

			<time datetime="<?php echo get_the_date('Y-m-d');?>">
				<?php echo get_the_date(); ?>
			</time>

			<span class="postcat">
				<?php the_category(',');?>
			</span>

		</div>

		<?php the_content();?>

	</article>

<?php endwhile; endif;?>
</body>
</html>